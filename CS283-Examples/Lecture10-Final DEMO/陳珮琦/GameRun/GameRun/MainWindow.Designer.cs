namespace GameRun
{
    partial class MainWindow
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
            this.CharacterBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterBox
            // 
            this.CharacterBox.BackColor = System.Drawing.Color.Transparent;
            this.CharacterBox.Image = global::GameRun.Properties.Resources.walk1;
            this.CharacterBox.Location = new System.Drawing.Point(139, 252);
            this.CharacterBox.Name = "CharacterBox";
            this.CharacterBox.Size = new System.Drawing.Size(100, 68);
            this.CharacterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharacterBox.TabIndex = 0;
            this.CharacterBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameRun.Properties.Resources.Back0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 392);
            this.Controls.Add(this.CharacterBox);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindow_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CharacterBox;
    }
}