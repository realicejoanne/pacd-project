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
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.LightCyan;
            this.btnStart.Location = new System.Drawing.Point(460, 505);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgBoxDetected
            // 
            this.imgBoxDetected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxDetected.Location = new System.Drawing.Point(504, 12);
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
            this.imgBoxOriginal.Size = new System.Drawing.Size(486, 270);
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
            this.tboxImagePath.Location = new System.Drawing.Point(12, 307);
            this.tboxImagePath.Name = "tboxImagePath";
            this.tboxImagePath.Size = new System.Drawing.Size(404, 24);
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
            this.btnImagePath.Location = new System.Drawing.Point(422, 307);
            this.btnImagePath.Name = "btnImagePath";
            this.btnImagePath.Size = new System.Drawing.Size(34, 24);
            this.btnImagePath.TabIndex = 19;
            this.btnImagePath.Text = "...";
            this.btnImagePath.UseVisualStyleBackColor = false;
            this.btnImagePath.Click += new System.EventHandler(this.btnImagePath_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(994, 568);
            this.Controls.Add(this.btnImagePath);
            this.Controls.Add(this.imgBoxOriginal);
            this.Controls.Add(this.imgBoxDetected);
            this.Controls.Add(this.tboxImagePath);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmguCV";
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private Emgu.CV.UI.ImageBox imgBoxDetected;
        private Emgu.CV.UI.ImageBox imgBoxOriginal;
        private System.Windows.Forms.TextBox tboxImagePath;
        private System.Windows.Forms.Button btnImagePath;
    }
}

