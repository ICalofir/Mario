namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ciuperca = new System.Windows.Forms.PictureBox();
            this.start2 = new System.Windows.Forms.PictureBox();
            this.start1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ciuperca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 527;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ciuperca
            // 
            this.ciuperca.BackColor = System.Drawing.Color.Transparent;
            this.ciuperca.Image = global::WindowsFormsApplication1.Properties.Resources.selectare;
            this.ciuperca.Location = new System.Drawing.Point(255, 97);
            this.ciuperca.Name = "ciuperca";
            this.ciuperca.Size = new System.Drawing.Size(31, 32);
            this.ciuperca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ciuperca.TabIndex = 2;
            this.ciuperca.TabStop = false;
            // 
            // start2
            // 
            this.start2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start2.Image = global::WindowsFormsApplication1.Properties.Resources.start2;
            this.start2.Location = new System.Drawing.Point(0, 0);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(709, 534);
            this.start2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start2.TabIndex = 1;
            this.start2.TabStop = false;
            this.start2.Visible = false;
            // 
            // start1
            // 
            this.start1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start1.Image = global::WindowsFormsApplication1.Properties.Resources.start1;
            this.start1.Location = new System.Drawing.Point(0, 0);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(709, 534);
            this.start1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start1.TabIndex = 0;
            this.start1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 534);
            this.Controls.Add(this.ciuperca);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.start1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ciuperca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox start1;
        private System.Windows.Forms.PictureBox start2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ciuperca;
    }
}