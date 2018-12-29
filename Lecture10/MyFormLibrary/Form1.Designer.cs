namespace MyFormLibrary
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
            this.firebaseControl1 = new MyFormLibrary.FirebaseControl();
            this.myButton1 = new MyFormLibrary.MyButton();
            this.myButton2 = new MyFormLibrary.MyButton();
            this.myButton3 = new MyFormLibrary.MyButton();
            this.SuspendLayout();
            // 
            // firebaseControl1
            // 
            this.firebaseControl1.Location = new System.Drawing.Point(12, 12);
            this.firebaseControl1.Name = "firebaseControl1";
            this.firebaseControl1.Size = new System.Drawing.Size(348, 227);
            this.firebaseControl1.TabIndex = 0;
            // 
            // myButton1
            // 
            this.myButton1.Location = new System.Drawing.Point(312, 239);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(290, 115);
            this.myButton1.TabIndex = 1;
            this.myButton1.Text = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // myButton2
            // 
            this.myButton2.Location = new System.Drawing.Point(58, 147);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(174, 92);
            this.myButton2.TabIndex = 2;
            this.myButton2.Text = "myButton2";
            this.myButton2.UseVisualStyleBackColor = true;
            // 
            // myButton3
            // 
            this.myButton3.Location = new System.Drawing.Point(404, 103);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(165, 78);
            this.myButton3.TabIndex = 3;
            this.myButton3.Text = "myButton3";
            this.myButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.firebaseControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FirebaseControl firebaseControl1;
        private MyButton myButton1;
        private MyButton myButton2;
        private MyButton myButton3;
    }
}