using Emgu.CV;
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

namespace ProjectEmgu
{
    public partial class FormImage : Form
    {
        IImage iImage;
        UMat uMatImage;

        public FormImage()
        {
            InitializeComponent();
        }

        public bool SetImage(IImage img)
        {
            iImage = img;

            if (iImage != null)
                return true;
            else
                return false;
        }

        public bool SetImage(UMat img)
        {
            uMatImage = img;

            if (uMatImage != null)
                return true;
            else
                return false;
        }

        private void FormImage_Shown(object sender, EventArgs e)
        {
            try
            {
                if (iImage != null)
                {
                    imgBox.Image = iImage;
                }
                else if (uMatImage != null)
                {
                    imgBox.Image = uMatImage;
                }
            }
            catch
            {
                Debug.WriteLine("Could not load image in large preview mode!");
            }
        }

    }
}
