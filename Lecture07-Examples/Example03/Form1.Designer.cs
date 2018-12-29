namespace Example03
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.pokemonSelector = new System.Windows.Forms.ComboBox();
            this.createPokemonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pokemonSelector
            // 
            this.pokemonSelector.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemonSelector.FormattingEnabled = true;
            this.pokemonSelector.Items.AddRange(new object[] {
            "Bulbasaur",
            "Ivysaur"});
            this.pokemonSelector.Location = new System.Drawing.Point(12, 31);
            this.pokemonSelector.Name = "pokemonSelector";
            this.pokemonSelector.Size = new System.Drawing.Size(246, 37);
            this.pokemonSelector.TabIndex = 0;
            this.pokemonSelector.Text = "請選擇一個Pokemon";
            // 
            // createPokemonButton
            // 
            this.createPokemonButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.createPokemonButton.Location = new System.Drawing.Point(285, 25);
            this.createPokemonButton.Name = "createPokemonButton";
            this.createPokemonButton.Size = new System.Drawing.Size(177, 47);
            this.createPokemonButton.TabIndex = 1;
            this.createPokemonButton.Text = "產生Pokemon";
            this.createPokemonButton.UseVisualStyleBackColor = true;
            this.createPokemonButton.Click += new System.EventHandler(this.createPokemonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 455);
            this.Controls.Add(this.createPokemonButton);
            this.Controls.Add(this.pokemonSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox pokemonSelector;
        private System.Windows.Forms.Button createPokemonButton;
    }
}

