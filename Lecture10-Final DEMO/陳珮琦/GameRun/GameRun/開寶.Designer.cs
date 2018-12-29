namespace GameRun
{
    partial class 開寶
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
            this.treasureBox = new System.Windows.Forms.PictureBox();
            this.PropsBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.treasureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treasureBox
            // 
            this.treasureBox.Image = global::GameRun.Properties.Resources.Box1;
            this.treasureBox.Location = new System.Drawing.Point(25, 35);
            this.treasureBox.Name = "treasureBox";
            this.treasureBox.Size = new System.Drawing.Size(234, 215);
            this.treasureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.treasureBox.TabIndex = 0;
            this.treasureBox.TabStop = false;
            this.treasureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PropsBox
            // 
            this.PropsBox.BackColor = System.Drawing.SystemColors.Info;
            this.PropsBox.Image = global::GameRun.Properties.Resources.Defence1;
            this.PropsBox.Location = new System.Drawing.Point(86, 88);
            this.PropsBox.Name = "PropsBox";
            this.PropsBox.Size = new System.Drawing.Size(100, 100);
            this.PropsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PropsBox.TabIndex = 1;
            this.PropsBox.TabStop = false;
            this.PropsBox.Visible = false;
            this.PropsBox.Click += new System.EventHandler(this.PropsBox_Click);
            // 
            // 開寶
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PropsBox);
            this.Controls.Add(this.treasureBox);
            this.Name = "開寶";
            this.Text = "開寶";
            ((System.ComponentModel.ISupportInitialize)(this.treasureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropsBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox treasureBox;
        private System.Windows.Forms.PictureBox PropsBox;
    }
}