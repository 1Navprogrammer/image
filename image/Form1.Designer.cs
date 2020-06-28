namespace image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Gunsound = new System.Windows.Forms.Button();
            this.Gunsound2 = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gunsound
            // 
            this.Gunsound.Location = new System.Drawing.Point(39, 117);
            this.Gunsound.Name = "Gunsound";
            this.Gunsound.Size = new System.Drawing.Size(138, 56);
            this.Gunsound.TabIndex = 0;
            this.Gunsound.Text = " Shootahead";
            this.Gunsound.UseVisualStyleBackColor = true;
            this.Gunsound.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gunsound2
            // 
            this.Gunsound2.Location = new System.Drawing.Point(39, 191);
            this.Gunsound2.Name = "Gunsound2";
            this.Gunsound2.Size = new System.Drawing.Size(138, 54);
            this.Gunsound2.TabIndex = 1;
            this.Gunsound2.Text = "Shootaway";
            this.Gunsound2.UseVisualStyleBackColor = true;
            this.Gunsound2.Click += new System.EventHandler(this.Gunsound2_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.Location = new System.Drawing.Point(657, 12);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(135, 44);
            this.PlayAgain.TabIndex = 2;
            this.PlayAgain.Text = "PlayAgain ";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(39, 379);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(138, 37);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Spin
            // 
            this.Spin.Location = new System.Drawing.Point(39, 327);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(138, 37);
            this.Spin.TabIndex = 4;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(534, 393);
            this.Score.MaximumSize = new System.Drawing.Size(200, 50);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(51, 20);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score";
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 26);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Gunsound2);
            this.Controls.Add(this.Gunsound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gunsound;
        private System.Windows.Forms.Button Gunsound2;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

