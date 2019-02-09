namespace IntSys05_EmguCV
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
            this.sliderFilterByColor = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFilterByColor = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.toolTipArea = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Button();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.btnEdgeDetect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxOriginal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFilterByColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.LightCyan;
            this.btnStart.Location = new System.Drawing.Point(431, 492);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgBoxDetected
            // 
            this.imgBoxDetected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxDetected.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgBoxDetected.Location = new System.Drawing.Point(502, 12);
            this.imgBoxDetected.Name = "imgBoxDetected";
            this.imgBoxDetected.Size = new System.Drawing.Size(480, 270);
            this.imgBoxDetected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBoxDetected.TabIndex = 2;
            this.imgBoxDetected.TabStop = false;
            this.imgBoxDetected.DoubleClick += new System.EventHandler(this.imgBoxDetected_DoubleClick);
            // 
            // imgBoxOriginal
            // 
            this.imgBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.imgBoxOriginal.Name = "imgBoxOriginal";
            this.imgBoxOriginal.Size = new System.Drawing.Size(480, 270);
            this.imgBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBoxOriginal.TabIndex = 3;
            this.imgBoxOriginal.TabStop = false;
            this.imgBoxOriginal.DoubleClick += new System.EventHandler(this.imgBoxOriginal_DoubleClick);
            // 
            // tboxImagePath
            // 
            this.tboxImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tboxImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxImagePath.ForeColor = System.Drawing.Color.LightCyan;
            this.tboxImagePath.Location = new System.Drawing.Point(12, 308);
            this.tboxImagePath.Name = "tboxImagePath";
            this.tboxImagePath.Size = new System.Drawing.Size(440, 24);
            this.tboxImagePath.TabIndex = 18;
            this.tboxImagePath.Text = "  Load image...";
            // 
            // btnImagePath
            // 
            this.btnImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnImagePath.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagePath.ForeColor = System.Drawing.Color.LightCyan;
            this.btnImagePath.Location = new System.Drawing.Point(458, 308);
            this.btnImagePath.Name = "btnImagePath";
            this.btnImagePath.Size = new System.Drawing.Size(34, 24);
            this.btnImagePath.TabIndex = 19;
            this.btnImagePath.Text = "...";
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
            this.groupBox1.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 108);
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
            this.cbHexagons.Location = new System.Drawing.Point(110, 65);
            this.cbHexagons.Name = "cbHexagons";
            this.cbHexagons.Size = new System.Drawing.Size(94, 22);
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
            this.cbRectangles.Location = new System.Drawing.Point(110, 32);
            this.cbRectangles.Name = "cbRectangles";
            this.cbRectangles.Size = new System.Drawing.Size(101, 22);
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
            this.cbTriangles.Location = new System.Drawing.Point(12, 65);
            this.cbTriangles.Name = "cbTriangles";
            this.cbTriangles.Size = new System.Drawing.Size(87, 22);
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
            this.cbCircles.Location = new System.Drawing.Point(12, 32);
            this.cbCircles.Name = "cbCircles";
            this.cbCircles.Size = new System.Drawing.Size(73, 22);
            this.cbCircles.TabIndex = 0;
            this.cbCircles.Text = "Circles";
            this.cbCircles.UseVisualStyleBackColor = true;
            // 
            // sliderFilterByColor
            // 
            this.sliderFilterByColor.AutoSize = false;
            this.sliderFilterByColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sliderFilterByColor.Enabled = false;
            this.sliderFilterByColor.Location = new System.Drawing.Point(1, 48);
            this.sliderFilterByColor.Maximum = 180;
            this.sliderFilterByColor.Name = "sliderFilterByColor";
            this.sliderFilterByColor.Size = new System.Drawing.Size(251, 28);
            this.sliderFilterByColor.TabIndex = 21;
            this.sliderFilterByColor.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::IntSys05_EmguCV.Properties.Resources.SpectrumSmall;
            this.pictureBox1.Location = new System.Drawing.Point(10, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // cbFilterByColor
            // 
            this.cbFilterByColor.AutoSize = true;
            this.cbFilterByColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByColor.ForeColor = System.Drawing.Color.LightCyan;
            this.cbFilterByColor.Location = new System.Drawing.Point(9, 20);
            this.cbFilterByColor.Name = "cbFilterByColor";
            this.cbFilterByColor.Size = new System.Drawing.Size(116, 22);
            this.cbFilterByColor.TabIndex = 4;
            this.cbFilterByColor.Text = "Filter by color";
            this.cbFilterByColor.UseVisualStyleBackColor = true;
            this.cbFilterByColor.CheckedChanged += new System.EventHandler(this.cbFilterByColor_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cbFilterByColor);
            this.groupBox2.Controls.Add(this.sliderFilterByColor);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Location = new System.Drawing.Point(235, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 108);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // tbArea
            // 
            this.tbArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArea.ForeColor = System.Drawing.Color.LightCyan;
            this.tbArea.Location = new System.Drawing.Point(62, 461);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(167, 24);
            this.tbArea.TabIndex = 22;
            this.toolTipArea.SetToolTip(this.tbArea, "Only detect shapes of specified area. Leave empty to detect all sizes.");
            // 
            // toolTipArea
            // 
            this.toolTipArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolTipArea.ForeColor = System.Drawing.Color.LightCyan;
            this.toolTipArea.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipArea.ToolTipTitle = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(18, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Area:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbBrightness);
            this.groupBox3.Controls.Add(this.tbContrast);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnContrast);
            this.groupBox3.Controls.Add(this.btnBrightness);
            this.groupBox3.Controls.Add(this.btnEdgeDetect);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox3.Location = new System.Drawing.Point(502, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 155);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightCyan;
            this.btnReset.Location = new System.Drawing.Point(358, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 30);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnContrast
            // 
            this.btnContrast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnContrast.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnContrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrast.ForeColor = System.Drawing.Color.LightCyan;
            this.btnContrast.Location = new System.Drawing.Point(16, 113);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(105, 30);
            this.btnContrast.TabIndex = 27;
            this.btnContrast.Text = "Contrast";
            this.btnContrast.UseVisualStyleBackColor = false;
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
            // 
            // btnBrightness
            // 
            this.btnBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBrightness.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrightness.ForeColor = System.Drawing.Color.LightCyan;
            this.btnBrightness.Location = new System.Drawing.Point(16, 68);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(105, 30);
            this.btnBrightness.TabIndex = 26;
            this.btnBrightness.Text = "Brightness";
            this.btnBrightness.UseVisualStyleBackColor = false;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // btnEdgeDetect
            // 
            this.btnEdgeDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEdgeDetect.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEdgeDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdgeDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdgeDetect.ForeColor = System.Drawing.Color.LightCyan;
            this.btnEdgeDetect.Location = new System.Drawing.Point(16, 23);
            this.btnEdgeDetect.Name = "btnEdgeDetect";
            this.btnEdgeDetect.Size = new System.Drawing.Size(105, 30);
            this.btnEdgeDetect.TabIndex = 25;
            this.btnEdgeDetect.Text = "Edge detect";
            this.btnEdgeDetect.UseVisualStyleBackColor = false;
            this.btnEdgeDetect.Click += new System.EventHandler(this.btnEdgeDetect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.LightCyan;
            this.lblStatus.Location = new System.Drawing.Point(18, 508);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 18);
            this.lblStatus.TabIndex = 25;
            // 
            // tbContrast
            // 
            this.tbContrast.AutoSize = false;
            this.tbContrast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbContrast.Location = new System.Drawing.Point(127, 113);
            this.tbContrast.Maximum = 150;
            this.tbContrast.Minimum = 50;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(336, 28);
            this.tbContrast.TabIndex = 29;
            this.tbContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbContrast.Value = 100;
            // 
            // tbBrightness
            // 
            this.tbBrightness.AutoSize = false;
            this.tbBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbBrightness.Location = new System.Drawing.Point(127, 68);
            this.tbBrightness.Maximum = 100;
            this.tbBrightness.Minimum = -100;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(336, 28);
            this.tbBrightness.SmallChange = 2;
            this.tbBrightness.TabIndex = 30;
            this.tbBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(7, 9);
            this.label2.TabIndex = 26;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 9);
            this.label3.TabIndex = 31;
            this.label3.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(994, 537);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgBoxDetected);
            this.Controls.Add(this.btnImagePath);
            this.Controls.Add(this.imgBoxOriginal);
            this.Controls.Add(this.tboxImagePath);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
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
        public System.Windows.Forms.TrackBar sliderFilterByColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.CheckBox cbFilterByColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTipArea;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.Button btnEdgeDetect;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.Label label3;
    }
}

