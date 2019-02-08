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

        public List<CircleF> circles;
        public List<Triangle2DF> triangles;
        public List<RotatedRect> rectangles;
        public List<LineSegment2D[]> hexagons;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // debug path
            //imagePath = "D://Workbench//Shapes.jpg";
            //imgBoxOriginal.Image = image;

            // Convert the image to grayscale and filter out the noise
            UMat uImage = new UMat();
            //uImage = image.ToUMat();  // uncomment this and comment next line to skip graying out the image
            CvInvoke.CvtColor(image, uImage, ColorConversion.Bgr2Gray);

            // Use image pyr to remove noise
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uImage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uImage);
            //Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

            // reset lists
            circles = null;
            triangles = null;
            rectangles = null;
            hexagons = null;

            // get area value from text box
            int area = 0;
            int.TryParse(tbArea.Text, out area);

            if(cbFilterByColor.Checked)
            { // filter by colors
                uImage = DetectColor(sliderFilterByColor.Value);    // returns UMat binary image

                if (cbCircles.Checked)
                {
                    DetectCirclesColored(uImage, area);
                }

                DetectPolygons(uImage, cbTriangles.Checked, cbRectangles.Checked, cbHexagons.Checked, area);
            }
            else
            { // detect all colors
                if (cbCircles.Checked)
                {
                    DetectCircles(uImage, area);
                }

                UMat cannyEdgesImg = DetectEdges(uImage);

                DetectPolygons(cannyEdgesImg, cbTriangles.Checked, cbRectangles.Checked, cbHexagons.Checked, area);
            }
            

            DrawShapes();
        }

        void DetectCircles(UMat uImage, int area)
        {
            circles = new List<CircleF>();

            double cannyThreshold = 180.0;
            double circleAccumulatorThreshold = 120;

            CircleF[] circlesArray = CvInvoke.HoughCircles(uImage, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, 5);

            foreach (CircleF circle in circlesArray)
            { // add circles from array to circles list
                circles.Add(circle);
            }

            FilterCirclesByArea(area);
        }

        void DetectCirclesColored(UMat uBinaryImage, int area)
        {
            circles = new List<CircleF>();

            Image<Bgr, byte> img;
            img = uBinaryImage.ToImage<Bgr, byte>();
            Image<Gray, Byte> gray = img.Convert<Gray, Byte>();

            Gray cannyThreshold = new Gray(180);
            Gray cannyThresholdLinking = new Gray(120);
            Gray circleAccumulatorThreshold = new Gray(90);    // default 60

            CircleF[] circlesArray = gray.HoughCircles(
                cannyThreshold,
                circleAccumulatorThreshold,
                4.0, //Resolution of the accumulator used to detect centers of the circles
                50.0, //min distance 
                2, //min radius
                100 //max radius
                )[0]; //Get the circles from the first channel

            foreach(CircleF circle in circlesArray)
            { // add circles from array to circles list
                circles.Add(circle);
            }

            FilterCirclesByArea(area);
        }

        void FilterCirclesByArea(int area)
        {
            // delete circles outside of defined area
            if (area != 0)
            { // but, only if area is specified
                int areaTresshold = 1000;
                CircleF[] circlesTmp;
                for (int i = 0; i < circles.Count; i++)
                {
                    if (circles[i].Area < area - areaTresshold || circles[i].Area > area + areaTresshold)
                    { // if circle is smaller than min or bigger than max -> delete from array
                        circles.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        UMat DetectEdges(UMat uImage)
        {
            double cannyThreshold = 180.0;
            double cannyThresholdLinking = 120.0;
            UMat cannyEdgesImg = new UMat();

            // detect edges using canny algorithm and save them as a binary image
            CvInvoke.Canny(uImage, cannyEdgesImg, cannyThreshold, cannyThresholdLinking);

            return cannyEdgesImg;
        }

        void DetectPolygons(UMat cannyEdgesImg, bool detectTriangles, bool detectRectangles, bool detectHexagons, int area)
        {
            triangles = new List<Triangle2DF>();
            rectangles = new List<RotatedRect>();
            hexagons = new List<LineSegment2D[]>();

            // find contours from binary image
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(cannyEdgesImg, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < contours.Size; i++)
            { // go trough all detected contours

                VectorOfPoint contour = contours[i];    // select i-th contour

                // approximate a polygon
                VectorOfPoint approxContour = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.025, true);

                if (CvInvoke.ContourArea(approxContour, false) > 250) //only consider contours bigger than defined area
                {
                    int areaTresshold = 1000;
                    if(area != 0)
                    {
                        if (CvInvoke.ContourArea(approxContour, false) < area - areaTresshold || CvInvoke.ContourArea(approxContour, false) > area + areaTresshold)
                        { //only consider contours near defined area
                          // if area is smaller or bigger than defined -> continue to next countour as this one doesn't fit
                            continue;
                        }

                        // debug - min area
                        //if (CvInvoke.ContourArea(approxContour, false) > area)
                        //    continue;
                    }
                    

                    if (approxContour.Size == 3 && detectTriangles)
                    { // triangle

                        Point[] pts = approxContour.ToArray();      // take points that define a triangle
                        triangles.Add(new Triangle2DF(pts[0], pts[1], pts[2]));     // add triangle to the list
                    }
                    else if (approxContour.Size == 4 && detectRectangles)
                    { // rectangle

                        // Determine if all the angles in the contour are within [80, 100] degree
                        bool isRectangle = true;

                        // create a line segment from points
                        Point[] pts = approxContour.ToArray();
                        LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                        for (int j = 0; j < edges.Length; j++)
                        { // go trough all edges of a potential rectangle

                            // get angle between two adjcent edges
                            double angle = Math.Abs(edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                            if (angle < 80 || angle > 100)
                            {
                                isRectangle = false;
                                break;
                            }
                        }
                        
                        if (isRectangle)
                            rectangles.Add(CvInvoke.MinAreaRect(approxContour)); // if it's a rectangle add it to the list
                    }
                    else if(approxContour.Size == 6 && detectHexagons)
                    { // hexagon

                        // Determine if all the angles in the contour are within [50, 70] degree
                        bool isHexagon = true;

                        // create a line segment from points
                        Point[] pts = approxContour.ToArray();
                        LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                        for (int j = 0; j < edges.Length; j++)
                        { // go trough all edges of a potential hexagon

                            // get angle between two adjcent edges
                            double angle = Math.Abs(edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                            if (angle < 50 || angle > 70)
                            {
                                isHexagon = false;
                                break;
                            }
                        }

                        if (isHexagon)
                        { // if it's a hexagon add it to the list
                            hexagons.Add(edges);
                        }
                            
                    }

                }
                
            }
        }

        void DrawShapes()
        {
            Image<Bgr, Byte> detectedImage = image.CopyBlank();

            // draw circles
            if(circles != null)
            {
                foreach (CircleF circle in circles)
                    detectedImage.Draw(circle, new Bgr(Color.Crimson), 2);
            }
            
            // draw triangles
            if (triangles != null)
            {
                foreach (Triangle2DF triangle in triangles)
                    detectedImage.Draw(triangle, new Bgr(Color.LimeGreen), 2);
            }
            
            // draw rectangles
            if (rectangles != null)
            {
                foreach (RotatedRect box in rectangles)
                    detectedImage.Draw(box, new Bgr(Color.DodgerBlue), 2);
            }

            // draw hexagons
            if (hexagons != null)
            {
                foreach (LineSegment2D[] hexagon in hexagons)
                {
                    foreach(LineSegment2D edge in hexagon)
                    {
                        detectedImage.Draw(edge, new Bgr(Color.DarkViolet), 2);
                    }
                }
            }


            imgBoxDetected.Image = detectedImage;
            
            // debug cross
            //triangleRectangleImage.Draw(new Cross2DF(new PointF(367, 181), 30, 30), new Bgr(Color.White), 2);
        }

        UMat DetectColor(int hue)
        {
            Hsv targetColor = new Hsv(hue, 210, 210);
            int tressholdHue = 15;
            int tressholdSat = 45;
            int tressholdVal = 45;

            Image<Bgr, Byte> image = new Image<Bgr, byte>(imagePath);
            //image = image.SmoothGaussian(3, 3, 1, 1);
            
            Hsv m_Lower = new Hsv(targetColor.Hue - tressholdHue, targetColor.Satuation - tressholdSat, targetColor.Value - tressholdVal);
            Hsv m_Higher = new Hsv(targetColor.Hue + tressholdHue, targetColor.Satuation + tressholdSat, targetColor.Value + tressholdVal);

            Image<Hsv, Byte> HsvImage = image.Convert<Hsv, byte>();
            HsvImage = HsvImage.SmoothGaussian(5, 5, 0.1, 0.1);
            Image<Gray, byte> detectedImage = HsvImage.InRange(m_Lower, m_Higher);

            //detectedImage = detectedImage.Not();
            return detectedImage.ToUMat();
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
                    return;
                }
            }
            else
            {
                return;
            }

            // if all ok set image
            image = new Image<Bgr, byte>(imagePath);
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

        private void cbFilterByColor_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFilterByColor.Checked)
            {
                sliderFilterByColor.Enabled = true;
            }
            else
            {
                sliderFilterByColor.Enabled = false;
            }
        }

        private void btnEdgeDetect_Click(object sender, EventArgs e)
        {
            if(image == null)
            {
                MessageBox.Show("Maybe load the image first?", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UMat uImage = new UMat();
            uImage = image.ToUMat();

            uImage = DetectEdges(uImage);

            imgBoxOriginal.Image = uImage;
        }
    }
}
