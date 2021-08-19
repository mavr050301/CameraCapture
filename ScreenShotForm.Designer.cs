
namespace CameraCapture
{
    partial class ScreenShotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenShotForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveScreenShotButton = new System.Windows.Forms.ToolStripButton();
            this.ScreenShotScreen = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShotScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveScreenShotButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SaveScreenShotButton
            // 
            this.SaveScreenShotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveScreenShotButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveScreenShotButton.Image")));
            this.SaveScreenShotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveScreenShotButton.Name = "SaveScreenShotButton";
            this.SaveScreenShotButton.Size = new System.Drawing.Size(44, 24);
            this.SaveScreenShotButton.Text = "Save";
            this.SaveScreenShotButton.Click += new System.EventHandler(this.SaveScreenShotButton_Click);
            // 
            // ScreenShotScreen
            // 
            this.ScreenShotScreen.BackColor = System.Drawing.Color.LightGray;
            this.ScreenShotScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenShotScreen.Location = new System.Drawing.Point(0, 27);
            this.ScreenShotScreen.Name = "ScreenShotScreen";
            this.ScreenShotScreen.Size = new System.Drawing.Size(800, 423);
            this.ScreenShotScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScreenShotScreen.TabIndex = 1;
            this.ScreenShotScreen.TabStop = false;
            // 
            // ScreenShotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScreenShotScreen);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ScreenShotForm";
            this.Text = "ScreenShotForm";
            this.Load += new System.EventHandler(this.ScreenShotForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShotScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveScreenShotButton;
        private System.Windows.Forms.PictureBox ScreenShotScreen;
    }
}