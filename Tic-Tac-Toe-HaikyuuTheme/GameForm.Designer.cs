namespace Tic_Tac_Toe_HaikyuuTheme
{
    partial class GameForm
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
            this.GameTitle = new System.Windows.Forms.PictureBox();
            this.PlayerSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTitle
            // 
            this.GameTitle.Image = global::Tic_Tac_Toe_HaikyuuTheme.Properties.Resources.GameTitle;
            this.GameTitle.Location = new System.Drawing.Point(12, 12);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(305, 139);
            this.GameTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameTitle.TabIndex = 0;
            this.GameTitle.TabStop = false;
            // 
            // PlayerSet
            // 
            this.PlayerSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PlayerSet.Image = global::Tic_Tac_Toe_HaikyuuTheme.Properties.Resources.PlayerSet11;
            this.PlayerSet.Location = new System.Drawing.Point(12, 169);
            this.PlayerSet.Name = "PlayerSet";
            this.PlayerSet.Size = new System.Drawing.Size(305, 188);
            this.PlayerSet.TabIndex = 2;
            this.PlayerSet.UseVisualStyleBackColor = false;
            this.PlayerSet.Click += new System.EventHandler(this.PlayerSet_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(874, 507);
            this.Controls.Add(this.PlayerSet);
            this.Controls.Add(this.GameTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.GameTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox GameTitle;
        private Button PlayerSet;
    }
}