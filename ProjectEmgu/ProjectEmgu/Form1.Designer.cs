namespace ProjectEmgu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.imgBoxDetected = new Emgu.CV.UI.ImageBox();
            this.imgBoxOriginal = new Emgu.CV.UI.ImageBox();
            this.tboxImagePath = new System.Windows.Forms.TextBox();
            this.btnImagePath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHexagons = new System.Windows.Forms.CheckBox();
            this.cbRectangles = new System.Windows.Forms.CheckBox();
            this.cbTriangles = new System.Windows.Forms.CheckBox();
            this.cbCircles = new System.Windows.Forms.CheckBox();
            this.toolTipArea = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdgeDetect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.sliderFilterByColor = new System.Windows.Forms.TrackBar();
            this.cbFilterByColor = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxOriginal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFilterByColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(695, 483);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Process";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgBoxDetected
            // 
            this.imgBoxDetected.BackColor = System.Drawing.Color.Black;
            this.imgBoxDetected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxDetected.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgBoxDetected.Location = new System.Drawing.Point(439, 14);
            this.imgBoxDetected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgBoxDetected.Name = "imgBoxDetected";
            this.imgBoxDetected.Size = new System.Drawing.Size(400, 400);
            this.imgBoxDetected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBoxDetected.TabIndex = 2;
            this.imgBoxDetected.TabStop = false;
            this.imgBoxDetected.DoubleClick += new System.EventHandler(this.imgBoxDetected_DoubleClick);
            // 
            // imgBoxOriginal
            // 
            this.imgBoxOriginal.BackColor = System.Drawing.Color.Black;
            this.imgBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxOriginal.Location = new System.Drawing.Point(22, 14);
            this.imgBoxOriginal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgBoxOriginal.Name = "imgBoxOriginal";
            this.imgBoxOriginal.Size = new System.Drawing.Size(400, 400);
            this.imgBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBoxOriginal.TabIndex = 3;
            this.imgBoxOriginal.TabStop = false;
            this.imgBoxOriginal.DoubleClick += new System.EventHandler(this.imgBoxOriginal_DoubleClick);
            // 
            // tboxImagePath
            // 
            this.tboxImagePath.BackColor = System.Drawing.Color.White;
            this.tboxImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tboxImagePath.ForeColor = System.Drawing.Color.Black;
            this.tboxImagePath.Location = new System.Drawing.Point(22, 436);
            this.tboxImagePath.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tboxImagePath.Name = "tboxImagePath";
            this.tboxImagePath.Size = new System.Drawing.Size(652, 35);
            this.tboxImagePath.TabIndex = 18;
            this.tboxImagePath.Text = "Please load image first!";
            // 
            // btnImagePath
            // 
            this.btnImagePath.BackColor = System.Drawing.Color.White;
            this.btnImagePath.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImagePath.ForeColor = System.Drawing.Color.Black;
            this.btnImagePath.Location = new System.Drawing.Point(695, 429);
            this.btnImagePath.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.btnImagePath.Name = "btnImagePath";
            this.btnImagePath.Size = new System.Drawing.Size(144, 48);
            this.btnImagePath.TabIndex = 19;
            this.btnImagePath.Text = "Browse";
            this.btnImagePath.UseVisualStyleBackColor = false;
            this.btnImagePath.Click += new System.EventHandler(this.btnImagePath_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHexagons);
            this.groupBox1.Controls.Add(this.cbRectangles);
            this.groupBox1.Controls.Add(this.cbTriangles);
            this.groupBox1.Controls.Add(this.cbCircles);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(863, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(388, 166);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detect shapes";
            // 
            // cbHexagons
            // 
            this.cbHexagons.AutoSize = true;
            this.cbHexagons.Checked = true;
            this.cbHexagons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHexagons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHexagons.ForeColor = System.Drawing.Color.Black;
            this.cbHexagons.Location = new System.Drawing.Point(212, 100);
            this.cbHexagons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHexagons.Name = "cbHexagons";
            this.cbHexagons.Size = new System.Drawing.Size(136, 30);
            this.cbHexagons.TabIndex = 3;
            this.cbHexagons.Text = "Hexagons";
            this.cbHexagons.UseVisualStyleBackColor = true;
            // 
            // cbRectangles
            // 
            this.cbRectangles.AutoSize = true;
            this.cbRectangles.Checked = true;
            this.cbRectangles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRectangles.ForeColor = System.Drawing.Color.Black;
            this.cbRectangles.Location = new System.Drawing.Point(212, 49);
            this.cbRectangles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRectangles.Name = "cbRectangles";
            this.cbRectangles.Size = new System.Drawing.Size(147, 30);
            this.cbRectangles.TabIndex = 2;
            this.cbRectangles.Text = "Rectangles";
            this.cbRectangles.UseVisualStyleBackColor = true;
            // 
            // cbTriangles
            // 
            this.cbTriangles.AutoSize = true;
            this.cbTriangles.Checked = true;
            this.cbTriangles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTriangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTriangles.ForeColor = System.Drawing.Color.Black;
            this.cbTriangles.Location = new System.Drawing.Point(18, 100);
            this.cbTriangles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTriangles.Name = "cbTriangles";
            this.cbTriangles.Size = new System.Drawing.Size(126, 30);
            this.cbTriangles.TabIndex = 1;
            this.cbTriangles.Text = "Triangles";
            this.cbTriangles.UseVisualStyleBackColor = true;
            // 
            // cbCircles
            // 
            this.cbCircles.AutoSize = true;
            this.cbCircles.Checked = true;
            this.cbCircles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCircles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCircles.ForeColor = System.Drawing.Color.Black;
            this.cbCircles.Location = new System.Drawing.Point(18, 49);
            this.cbCircles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCircles.Name = "cbCircles";
            this.cbCircles.Size = new System.Drawing.Size(105, 30);
            this.cbCircles.TabIndex = 0;
            this.cbCircles.Text = "Circles";
            this.cbCircles.UseVisualStyleBackColor = true;
            // 
            // toolTipArea
            // 
            this.toolTipArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolTipArea.ForeColor = System.Drawing.Color.LightCyan;
            this.toolTipArea.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipArea.ToolTipTitle = "Area";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(1064, 463);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(187, 68);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdgeDetect
            // 
            this.btnEdgeDetect.BackColor = System.Drawing.Color.White;
            this.btnEdgeDetect.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEdgeDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdgeDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdgeDetect.ForeColor = System.Drawing.Color.Black;
            this.btnEdgeDetect.Location = new System.Drawing.Point(863, 463);
            this.btnEdgeDetect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdgeDetect.Name = "btnEdgeDetect";
            this.btnEdgeDetect.Size = new System.Drawing.Size(187, 68);
            this.btnEdgeDetect.TabIndex = 25;
            this.btnEdgeDetect.Text = "Edge detect";
            this.btnEdgeDetect.UseVisualStyleBackColor = false;
            this.btnEdgeDetect.Click += new System.EventHandler(this.btnEdgeDetect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(17, 494);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 26);
            this.lblStatus.TabIndex = 25;
            // 
            // sliderFilterByColor
            // 
            this.sliderFilterByColor.AutoSize = false;
            this.sliderFilterByColor.BackColor = System.Drawing.Color.White;
            this.sliderFilterByColor.Enabled = false;
            this.sliderFilterByColor.Location = new System.Drawing.Point(2, 74);
            this.sliderFilterByColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sliderFilterByColor.Maximum = 180;
            this.sliderFilterByColor.Name = "sliderFilterByColor";
            this.sliderFilterByColor.Size = new System.Drawing.Size(376, 43);
            this.sliderFilterByColor.TabIndex = 21;
            this.sliderFilterByColor.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // cbFilterByColor
            // 
            this.cbFilterByColor.AutoSize = true;
            this.cbFilterByColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByColor.ForeColor = System.Drawing.Color.Black;
            this.cbFilterByColor.Location = new System.Drawing.Point(14, 31);
            this.cbFilterByColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFilterByColor.Name = "cbFilterByColor";
            this.cbFilterByColor.Size = new System.Drawing.Size(168, 30);
            this.cbFilterByColor.TabIndex = 4;
            this.cbFilterByColor.Text = "Filter by color";
            this.cbFilterByColor.UseVisualStyleBackColor = true;
            this.cbFilterByColor.CheckedChanged += new System.EventHandler(this.cbFilterByColor_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::ProjectEmgu.Properties.Resources.SpectrumSmall;
            this.pictureBox1.Location = new System.Drawing.Point(15, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cbFilterByColor);
            this.groupBox2.Controls.Add(this.sliderFilterByColor);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(863, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(388, 166);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(859, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Detect Shape and Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(860, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "EmguCV Project - 140810160065";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 545);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEdgeDetect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgBoxDetected);
            this.Controls.Add(this.btnImagePath);
            this.Controls.Add(this.imgBoxOriginal);
            this.Controls.Add(this.tboxImagePath);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmguCV";
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxOriginal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFilterByColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private Emgu.CV.UI.ImageBox imgBoxDetected;
        private Emgu.CV.UI.ImageBox imgBoxOriginal;
        private System.Windows.Forms.TextBox tboxImagePath;
        private System.Windows.Forms.Button btnImagePath;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox cbHexagons;
        public System.Windows.Forms.CheckBox cbRectangles;
        public System.Windows.Forms.CheckBox cbTriangles;
        public System.Windows.Forms.CheckBox cbCircles;
        private System.Windows.Forms.ToolTip toolTipArea;
        private System.Windows.Forms.Button btnEdgeDetect;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.TrackBar sliderFilterByColor;
        public System.Windows.Forms.CheckBox cbFilterByColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

