using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectEmgu {
    public partial class Form1 : Form {
        public string imagePath;
        public Image<Bgr, Byte> image;

        public List<CircleF> circles;
        public List<Triangle2DF> triangles;
        public List<RotatedRect> rectangles;
        public List<LineSegment2D[]> hexagons;

        public Form1(){
            InitializeComponent();
            lblStatus.Text = "Welcome!";
        }

        void DetectCircles(UMat uImage, int area){
            circles = new List<CircleF>();

            double cannyThreshold = 180.0;
            double circleAccumulatorThreshold = 120;

            CircleF[] circlesArray = CvInvoke.HoughCircles(uImage, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, 5);

            //Add circle
            foreach (CircleF circle in circlesArray){
                circles.Add(circle);
            }

            FilterCirclesByArea(area);
        }
        void DetectCirclesColored(UMat uBinaryImage, int area){
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

            //Add circle
            foreach(CircleF circle in circlesArray){
                circles.Add(circle);
            }

            FilterCirclesByArea(area);
        }
        void FilterCirclesByArea(int area){
            //Delete circle outside the area
            //If area is specified
            if (area != 0){
                int areaTresshold = 1000;
                CircleF[] circlesTmp;
                for (int i = 0; i < circles.Count; i++){
                    //If circle is smaller than min or bigger than max->delete from array
                    if (circles[i].Area < area - areaTresshold || circles[i].Area > area + areaTresshold){
                        circles.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        UMat DetectEdges(UMat uImage){
            double cannyThreshold = 180.0;
            double cannyThresholdLinking = 120.0;
            UMat cannyEdgesImg = new UMat();

            //Detect edges using canny algorithm and save them as a binary image
            CvInvoke.Canny(uImage, cannyEdgesImg, cannyThreshold, cannyThresholdLinking);

            return cannyEdgesImg;
        }
        void DetectPolygons(UMat cannyEdgesImg, bool detectTriangles, bool detectRectangles, bool detectHexagons, int area){
            triangles = new List<Triangle2DF>();
            rectangles = new List<RotatedRect>();
            hexagons = new List<LineSegment2D[]>();

            //Find contours
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(cannyEdgesImg, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            //Check all contours
            for (int i = 0; i < contours.Size; i++){
                VectorOfPoint contour = contours[i];

                //Approximate a polygon
                VectorOfPoint approxContour = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.025, true);

                //Contours bigger than defined area
                if (CvInvoke.ContourArea(approxContour, false) > 250){
                    int areaTresshold = 1000;
                    if(area != 0){
                        if (CvInvoke.ContourArea(approxContour, false) < area - areaTresshold ||
                            CvInvoke.ContourArea(approxContour, false) > area + areaTresshold){
                            //Consider contours near defined area
                            //If area is smaller or bigger than defined -> continue to next countour as this one doesn't fit
                            continue;
                        }
                    }
                    
                    //Add triangle
                    if (approxContour.Size == 3 && detectTriangles){
                        Point[] pts = approxContour.ToArray();
                        triangles.Add(new Triangle2DF(pts[0], pts[1], pts[2]));
                    }
                    //Add rectangle
                    else if (approxContour.Size == 4 && detectRectangles){
                        //Determine if all angles in the contour are within [80, 100] degree
                        bool isRectangle = true;
                        Point[] pts = approxContour.ToArray();
                        LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                        for (int j = 0; j < edges.Length; j++){
                            double angle = Math.Abs(edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                            if (angle < 80 || angle > 100){
                                isRectangle = false;
                                break;
                            }
                        }

                        if (isRectangle){
                            rectangles.Add(CvInvoke.MinAreaRect(approxContour));
                        }
                    }
                    //Add hexagon
                    else if(approxContour.Size == 6 && detectHexagons){
                        // Determine if all the angles in the contour are within [50, 70] degree
                        bool isHexagon = true;
                        Point[] pts = approxContour.ToArray();
                        LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                        for (int j = 0; j < edges.Length; j++){
                            double angle = Math.Abs(edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                            if (angle < 50 || angle > 70){
                                isHexagon = false;
                                break;
                            }
                        }

                        if (isHexagon){
                            hexagons.Add(edges);
                        }     
                    }
                }               
            }
        }

        void DrawShapes(){
            Image<Bgr, Byte> detectedImage = image.CopyBlank();

            //Draw circle
            if(circles != null){
                foreach (CircleF circle in circles)
                    detectedImage.Draw(circle, new Bgr(Color.Crimson), 2);
            }
            
            //Draw triangle
            if (triangles != null){
                foreach (Triangle2DF triangle in triangles)
                    detectedImage.Draw(triangle, new Bgr(Color.LimeGreen), 2);
            }
            
            //Draw rectangle
            if (rectangles != null){
                foreach (RotatedRect box in rectangles)
                    detectedImage.Draw(box, new Bgr(Color.DodgerBlue), 2);
            }

            //Draw hexagon
            if (hexagons != null){
                foreach (LineSegment2D[] hexagon in hexagons){
                    foreach(LineSegment2D edge in hexagon){
                        detectedImage.Draw(edge, new Bgr(Color.DarkViolet), 2);
                    }
                }
            }

            imgBoxDetected.Image = detectedImage;
        }

        UMat DetectColor(int hue){
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

        void SetWorking(){
            lblStatus.Text = "Processing...";
            this.Update();
        }

        /* Bitmap Contrast(Bitmap img, float value){
            for(int i = 0; i < img.Width; i++){
                for (int j = 0; j < img.Height; j++){
                    Color pixel = img.GetPixel(i, j);

                    int newR = (int)(value * (pixel.R - 128) + 128);
                    int newG = (int)(value * (pixel.G - 128) + 128);
                    int newB = (int)(value * (pixel.B - 128) + 128);

                    if (newR < 0)
                        newR = 0;
                    if (newR > 255)
                        newR = 255;
                    if (newG < 0)
                        newG = 0;
                    if (newG > 255)
                        newG = 255;
                    if (newB < 0)
                        newB = 0;
                    if (newB > 255)
                        newB = 255;

                    Color newPixel = Color.FromArgb(newR, newG, newB);

                    img.SetPixel(i, j, newPixel);
                }
            }

            return img;
        }*/

        private void btnImagePath_Click_1(object sender, EventArgs e){
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp;)|*.jpg;*.jpeg;*.png;*.bmp;|All files (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.Cancel){
                return;
            }
            imagePath = ofd.FileName;
            tboxImagePath.Text = "  " + imagePath;

            if (imagePath != ""){
                try {
                    Image<Bgr, Byte> img = new Image<Bgr, byte>(imagePath);
                    imgBoxOriginal.Image = img;
                }
                catch {
                    MessageBox.Show("Could not load the image. Are you sure it was a proper image file?", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else {
                return;
            }

            image = new Image<Bgr, byte>(imagePath);
            lblStatus.Text = "Done!";
        }

        private void imgBoxOriginal_DoubleClick(object sender, EventArgs e){
            FormImage formImage = new FormImage();
            bool success = formImage.SetImage(imgBoxOriginal.Image);
            if(success)
                formImage.Show();
        }

        private void imgBoxDetected_DoubleClick(object sender, EventArgs e){
            FormImage formImage = new FormImage();
            bool success = formImage.SetImage(imgBoxDetected.Image);
            if (success)
                formImage.Show();
        }

        private void cbFilterByColor_CheckedChanged(object sender, EventArgs e){
            if(cbFilterByColor.Checked){
                sliderFilterByColor.Enabled = true;
            }
            else {
                sliderFilterByColor.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e){
            if (image == null){
                MessageBox.Show("Please load image first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetWorking();

            //Convert the image to grayscale and filter out the noise
            UMat uImage = new UMat();
            //uImage = image.ToUMat();  //uncomment this and comment next line to skip graying out the image
            CvInvoke.CvtColor(image, uImage, ColorConversion.Bgr2Gray);

            //Use image pyr to remove noise
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uImage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uImage);
            //Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

            //Reset shape
            circles = null;
            triangles = null;
            rectangles = null;
            hexagons = null;

            //Get area value from text box
            int area = 0;
            //int.TryParse(tbArea.Text, out area);

            //Filter by color
            if (cbFilterByColor.Checked){
                uImage = DetectColor(sliderFilterByColor.Value);

                if (cbCircles.Checked){
                    DetectCirclesColored(uImage, area);
                }

                DetectPolygons(uImage, cbTriangles.Checked, cbRectangles.Checked, cbHexagons.Checked, area);
            }
            //Detect all color
            else {
                if (cbCircles.Checked){
                    DetectCircles(uImage, area);
                }

                UMat cannyEdgesImg = DetectEdges(uImage);
                DetectPolygons(cannyEdgesImg, cbTriangles.Checked, cbRectangles.Checked, cbHexagons.Checked, area);
            }

            DrawShapes();
            lblStatus.Text = "Done!";
        }
        private void btnEdgeDetect_Click(object sender, EventArgs e){
            if (image == null){
                MessageBox.Show("Please load image first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SetWorking();

            UMat uImage = new UMat();
            uImage = image.ToUMat();

            image = DetectEdges(uImage).ToImage<Bgr, byte>();

            imgBoxOriginal.Image = image;

            lblStatus.Text = "Done!";
        }
        private void btnReset_Click(object sender, EventArgs e){
            if (image == null){
                MessageBox.Show("Please load image first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            image = new Image<Bgr, byte>(imagePath);
            imgBoxOriginal.Image = image;
        }
    }
}
