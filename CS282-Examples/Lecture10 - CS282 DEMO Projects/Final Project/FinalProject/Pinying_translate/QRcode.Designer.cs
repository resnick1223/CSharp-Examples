namespace Pinying_translate
{
    partial class QRcode
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
            this.QR_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QR_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QR_pictureBox
            // 
            this.QR_pictureBox.Location = new System.Drawing.Point(26, 15);
            this.QR_pictureBox.Name = "QR_pictureBox";
            this.QR_pictureBox.Size = new System.Drawing.Size(356, 341);
            this.QR_pictureBox.TabIndex = 0;
            this.QR_pictureBox.TabStop = false;
            // 
            // QRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 368);
            this.Controls.Add(this.QR_pictureBox);
            this.Name = "QRcode";
            this.Text = "QRcode";
            ((System.ComponentModel.ISupportInitialize)(this.QR_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox QR_pictureBox;
    }
}