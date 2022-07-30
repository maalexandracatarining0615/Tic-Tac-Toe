namespace Tic_Tac_Toe_HaikyuuTheme
{
    partial class ThankYou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThankYou));
            this.ThankYouPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThankYouPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ThankYouPic
            // 
            this.ThankYouPic.Image = global::Tic_Tac_Toe_HaikyuuTheme.Properties.Resources.ThankYou;
            this.ThankYouPic.Location = new System.Drawing.Point(12, 12);
            this.ThankYouPic.Name = "ThankYouPic";
            this.ThankYouPic.Size = new System.Drawing.Size(515, 465);
            this.ThankYouPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThankYouPic.TabIndex = 0;
            this.ThankYouPic.TabStop = false;
            // 
            // ThankYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(538, 488);
            this.Controls.Add(this.ThankYouPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThankYou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thank You!";
            ((System.ComponentModel.ISupportInitialize)(this.ThankYouPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ThankYouPic;
    }
}