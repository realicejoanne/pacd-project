using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntSys05_EmguCV
{
    public partial class Form1 : Form
    {
        public string imagePath;
        public Image<Bgr, Byte> image;

        public CircleF[] circles;
        public List<Triangle2DF> triangleList;
        public List<RotatedRect> boxList;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // debug path
            imagePath = "D://Workbench//Shapes.jpg";

            // Load image
            image = new Image<Bgr, byte>(imagePath);



            // Convert the image to grayscale and filter out the noise
            UMat uImage = new UMat();
            //uImage = image.ToUMat();
            CvInvoke.CvtColor(image, uImage, ColorConversion.Bgr2Gray);

            // Use image pyr to remove noise
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uImage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uImage);
            //Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();


            DetectCircles(uImage);
            UMat cannyEdgesImg = DetectEdges(uImage);
            DetectPolygons(cannyEdgesImg);

            DrawShapes();





        }

        void DetectCircles(UMat uImage)
        {
            double cannyThreshold = 180.0;
            double circleAccumulatorThreshold = 120;
            circles = CvInvoke.HoughCircles(uImage, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, 5);
        }

        UMat DetectEdges(UMat uImage)
        {
            double cannyThreshold = 180.0;
            double cannyThresholdLinking = 120.0;
            UMat cannyEdgesImg = new UMat();
            CvInvoke.Canny(uImage, cannyEdgesImg, cannyThreshold, cannyThresholdLinking);

            return cannyEdgesImg;
        }

        void DetectPolygons(UMat cannyEdgesImg)
        {
            triangleList = new List<Triangle2DF>();
            boxList = new List<RotatedRect>();

            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(cannyEdgesImg, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {

                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.025, true);

                        if (CvInvoke.ContourArea(approxContour, false) > 250) //only consider contours with area greater than 250
                        {
                            if (approxContour.Size == 3) //The contour has 3 vertices, it is a triangle
                            {
                                Point[] pts = approxContour.ToArray();
                                triangleList.Add(new Triangle2DF(
                                   pts[0],
                                   pts[1],
                                   pts[2]
                                   ));
                            }
                            else if (approxContour.Size == 4) //The contour has 4 vertices.
                            {
                                // Determine if all the angles in the contour are within [80, 100] degree
                                bool isRectangle = true;
                                Point[] pts = approxContour.ToArray();
                                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                                for (int j = 0; j < edges.Length; j++)
                                {
                                    double angle = Math.Abs(
                                       edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                    if (angle < 80 || angle > 100)
                                    {
                                        isRectangle = false;
                                        break;
                                    }
                                }


                                if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approxContour));
                            }
                        }
                    }
                }
            }
        }

        void DrawShapes()
        {
            
            // draw triangles and rectangles
            Image<Bgr, Byte> triangleRectangleImage = image.CopyBlank();
            foreach (Triangle2DF triangle in triangleList)
                triangleRectangleImage.Draw(triangle, new Bgr(Color.DarkBlue), 2);
            foreach (RotatedRect box in boxList)
                triangleRectangleImage.Draw(box, new Bgr(Color.DarkOrange), 2);

            imgBoxDetected.Image = triangleRectangleImage;


            // draw circles
            Image<Bgr, Byte> circleImage = image.CopyBlank();
            foreach (CircleF circle in circles)
                triangleRectangleImage.Draw(circle, new Bgr(Color.Brown), 2);

            imgBoxDetected.Image = triangleRectangleImage;
            

            // debug cross
            //triangleRectangleImage.Draw(new Cross2DF(new PointF(367, 181), 30, 30), new Bgr(Color.White), 2);
        }

        void DetectColor()
        {
            Hsv targetColor = new Hsv(100, 210, 210);
            int tressholdHue = 15;
            int tressholdSat = 45;
            int tressholdVal = 45;

            Image<Bgr, Byte> image = new Image<Bgr, byte>(imagePath);
            //frame = frame.SmoothGaussian(3, 3, 1, 1);
            
            Hsv m_Lower = new Hsv(targetColor.Hue - tressholdHue, targetColor.Satuation - tressholdSat, targetColor.Value - tressholdVal);
            Hsv m_Higher = new Hsv(targetColor.Hue + tressholdHue, targetColor.Satuation + tressholdSat, targetColor.Value + tressholdVal);

            Image<Hsv, Byte> HsvImage = image.Convert<Hsv, byte>();
            HsvImage = HsvImage.SmoothGaussian(5, 5, 0.1, 0.1);
            Image<Gray, byte> detectedImage = HsvImage.InRange(m_Lower, m_Higher);

            // return detected image here
        }


        // Form controls ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

        private void btnImagePath_Click_1(object sender, EventArgs e)
        { // set image path
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp;)|*.jpg;*.jpeg;*.png;*.bmp;|All files (*.*)|*.*";
            ofd.ShowDialog();
            imagePath = ofd.FileName;

            tboxImagePath.Text = "  " + imagePath;   // update label

            // display image if loaded
            if (imagePath != "")
            {
                try
                {
                    Image<Bgr, Byte> img = new Image<Bgr, byte>(imagePath);
                    imgBoxOriginal.Image = img;
                }
                catch
                {
                    MessageBox.Show("Could not load the image. Are you sure it was a proper image file?", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void imgBoxOriginal_DoubleClick(object sender, EventArgs e)
        {
            FormImage formImage = new FormImage();
            bool success = formImage.SetImage(imgBoxOriginal.Image);
            if(success)
                formImage.Show();
        }

        private void imgBoxDetected_DoubleClick(object sender, EventArgs e)
        {
            FormImage formImage = new FormImage();
            bool success = formImage.SetImage(imgBoxDetected.Image);
            if (success)
                formImage.Show();
        }

    }
}
