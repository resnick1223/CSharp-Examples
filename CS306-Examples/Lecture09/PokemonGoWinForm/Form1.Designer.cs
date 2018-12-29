namespace PokemonGoWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pokemon1 = new PokemonGoWinForm.Pokemon();
            this.pokemon2 = new PokemonGoWinForm.Pokemon();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon2)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemon1
            // 
            this.pokemon1.Hp = 0;
            this.pokemon1.Location = new System.Drawing.Point(48, 75);
            this.pokemon1.MaxHp = 0;
            this.pokemon1.Name = "pokemon1";
            this.pokemon1.NationalId = 0;
            this.pokemon1.Size = new System.Drawing.Size(159, 198);
            this.pokemon1.TabIndex = 0;
            this.pokemon1.TabStop = false;
            this.pokemon1.PowerUp += new System.EventHandler(this.pokemon1_PowerUp);
            // 
            // pokemon2
            // 
            this.pokemon2.Hp = 0;
            this.pokemon2.Location = new System.Drawing.Point(313, 103);
            this.pokemon2.MaxHp = 0;
            this.pokemon2.Name = "pokemon2";
            this.pokemon2.NationalId = 0;
            this.pokemon2.Size = new System.Drawing.Size(142, 170);
            this.pokemon2.TabIndex = 1;
            this.pokemon2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(102, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pokemon2);
            this.Controls.Add(this.pokemon1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Pokemon pokemon1;
        private Pokemon pokemon2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

