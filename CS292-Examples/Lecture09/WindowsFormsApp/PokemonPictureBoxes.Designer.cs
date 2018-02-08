namespace WindowsFormsApp
{
    partial class PokemonPictureBoxes
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pokemonPictureBox1 = new WindowsFormsApp.PokemonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemovePictureBoxes);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pokemonPictureBox1
            // 
            this.pokemonPictureBox1.Image = global::WindowsFormsApp.Properties.Resources._001;
            this.pokemonPictureBox1.Location = new System.Drawing.Point(44, 16);
            this.pokemonPictureBox1.Name = "pokemonPictureBox1";
            this.pokemonPictureBox1.Pokemon = null;
            this.pokemonPictureBox1.Size = new System.Drawing.Size(174, 133);
            this.pokemonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pokemonPictureBox1.TabIndex = 2;
            this.pokemonPictureBox1.TabStop = false;
            // 
            // PokemonPictureBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pokemonPictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PokemonPictureBoxes";
            this.Size = new System.Drawing.Size(414, 311);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private PokemonPictureBox pokemonPictureBox1;
    }
}
