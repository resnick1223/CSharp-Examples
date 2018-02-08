namespace PokemonRun
{
    partial class BattleScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pokemonBox = new PokemonRun.PokemonBox();
            this.battleTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PokemonRun.Properties.Resources._580b57fcd9996e24bc43c31e;
            this.pictureBox1.Location = new System.Drawing.Point(275, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pokemonBox
            // 
            this.pokemonBox.BackColor = System.Drawing.Color.Transparent;
            this.pokemonBox.Location = new System.Drawing.Point(246, 108);
            this.pokemonBox.Name = "pokemonBox";
            this.pokemonBox.Size = new System.Drawing.Size(205, 266);
            this.pokemonBox.TabIndex = 1;
            // 
            // battleTitleLabel
            // 
            this.battleTitleLabel.AutoSize = true;
            this.battleTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.battleTitleLabel.Enabled = false;
            this.battleTitleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.battleTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.battleTitleLabel.Location = new System.Drawing.Point(298, 77);
            this.battleTitleLabel.Name = "battleTitleLabel";
            this.battleTitleLabel.Size = new System.Drawing.Size(102, 38);
            this.battleTitleLabel.TabIndex = 2;
            this.battleTitleLabel.Text = "label1";
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonRun.Properties.Resources.hZOCpmN;
            this.ClientSize = new System.Drawing.Size(713, 699);
            this.Controls.Add(this.battleTitleLabel);
            this.Controls.Add(this.pokemonBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BattleScreen";
            this.Text = "BattleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public PokemonBox pokemonBox;
        public System.Windows.Forms.Label battleTitleLabel;
    }
}