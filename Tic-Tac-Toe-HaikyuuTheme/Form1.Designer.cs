namespace Tic_Tac_Toe_HaikyuuTheme
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.WelcomePic = new System.Windows.Forms.PictureBox();
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePic)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomePic
            // 
            this.WelcomePic.Image = global::Tic_Tac_Toe_HaikyuuTheme.Properties.Resources.Welcome;
            this.WelcomePic.Location = new System.Drawing.Point(12, 12);
            this.WelcomePic.Name = "WelcomePic";
            this.WelcomePic.Size = new System.Drawing.Size(643, 546);
            this.WelcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WelcomePic.TabIndex = 0;
            this.WelcomePic.TabStop = false;
            this.WelcomePic.Click += new System.EventHandler(this.WelcomePic_Click);
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.DarkOrange;
            this.Yes.Font = new System.Drawing.Font("04b", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yes.ForeColor = System.Drawing.Color.OrangeRed;
            this.Yes.Location = new System.Drawing.Point(185, 564);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(116, 32);
            this.Yes.TabIndex = 1;
            this.Yes.Text = "YES";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.LightSlateGray;
            this.No.Font = new System.Drawing.Font("04b", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.No.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.No.Location = new System.Drawing.Point(365, 564);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(116, 32);
            this.No.TabIndex = 2;
            this.No.Text = "NO";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("rainyhearts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(20, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click to add music";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(667, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.WelcomePic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox WelcomePic;
        private Button Yes;
        private Button No;
        private Button button1;
    }
}