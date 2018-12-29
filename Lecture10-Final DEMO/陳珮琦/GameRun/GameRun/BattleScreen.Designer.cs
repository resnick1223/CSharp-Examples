namespace GameRun
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
            this.CharacterBox = new System.Windows.Forms.PictureBox();
            this.PokemonBox = new System.Windows.Forms.PictureBox();
            this.pokemonHpLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FinalorderAttack = new System.Windows.Forms.Button();
            this.SecondorderAttack = new System.Windows.Forms.Button();
            this.FirstorderAttack = new System.Windows.Forms.Button();
            this.baceAttack = new System.Windows.Forms.Button();
            this.playerHpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterBox
            // 
            this.CharacterBox.BackColor = System.Drawing.Color.Transparent;
            this.CharacterBox.Image = global::GameRun.Properties.Resources.battle;
            this.CharacterBox.Location = new System.Drawing.Point(12, 118);
            this.CharacterBox.Name = "CharacterBox";
            this.CharacterBox.Size = new System.Drawing.Size(220, 305);
            this.CharacterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharacterBox.TabIndex = 0;
            this.CharacterBox.TabStop = false;
            // 
            // PokemonBox
            // 
            this.PokemonBox.BackColor = System.Drawing.Color.Transparent;
            this.PokemonBox.Image = global::GameRun.Properties.Resources._001;
            this.PokemonBox.Location = new System.Drawing.Point(377, 85);
            this.PokemonBox.Name = "PokemonBox";
            this.PokemonBox.Size = new System.Drawing.Size(156, 160);
            this.PokemonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PokemonBox.TabIndex = 1;
            this.PokemonBox.TabStop = false;
            // 
            // pokemonHpLabel
            // 
            this.pokemonHpLabel.AutoSize = true;
            this.pokemonHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.pokemonHpLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemonHpLabel.Location = new System.Drawing.Point(451, 51);
            this.pokemonHpLabel.Name = "pokemonHpLabel";
            this.pokemonHpLabel.Size = new System.Drawing.Size(82, 31);
            this.pokemonHpLabel.TabIndex = 2;
            this.pokemonHpLabel.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.FinalorderAttack);
            this.groupBox1.Controls.Add(this.SecondorderAttack);
            this.groupBox1.Controls.Add(this.FirstorderAttack);
            this.groupBox1.Controls.Add(this.baceAttack);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(287, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // FinalorderAttack
            // 
            this.FinalorderAttack.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FinalorderAttack.Location = new System.Drawing.Point(169, 62);
            this.FinalorderAttack.Name = "FinalorderAttack";
            this.FinalorderAttack.Size = new System.Drawing.Size(160, 46);
            this.FinalorderAttack.TabIndex = 3;
            this.FinalorderAttack.Text = "重捶";
            this.FinalorderAttack.UseVisualStyleBackColor = true;
            this.FinalorderAttack.Click += new System.EventHandler(this.FinalorderAttack_Click);
            // 
            // SecondorderAttack
            // 
            this.SecondorderAttack.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SecondorderAttack.Location = new System.Drawing.Point(5, 62);
            this.SecondorderAttack.Name = "SecondorderAttack";
            this.SecondorderAttack.Size = new System.Drawing.Size(160, 46);
            this.SecondorderAttack.TabIndex = 2;
            this.SecondorderAttack.Text = "橫掃";
            this.SecondorderAttack.UseVisualStyleBackColor = true;
            this.SecondorderAttack.Click += new System.EventHandler(this.SecondorderAttack_Click);
            // 
            // FirstorderAttack
            // 
            this.FirstorderAttack.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FirstorderAttack.Location = new System.Drawing.Point(169, 14);
            this.FirstorderAttack.Name = "FirstorderAttack";
            this.FirstorderAttack.Size = new System.Drawing.Size(160, 46);
            this.FirstorderAttack.TabIndex = 1;
            this.FirstorderAttack.Text = "劈砍";
            this.FirstorderAttack.UseVisualStyleBackColor = true;
            this.FirstorderAttack.Click += new System.EventHandler(this.FirstorderAttack_Click);
            // 
            // baceAttack
            // 
            this.baceAttack.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.baceAttack.Location = new System.Drawing.Point(5, 14);
            this.baceAttack.Name = "baceAttack";
            this.baceAttack.Size = new System.Drawing.Size(160, 46);
            this.baceAttack.TabIndex = 0;
            this.baceAttack.Text = "拳擊";
            this.baceAttack.UseVisualStyleBackColor = true;
            this.baceAttack.Click += new System.EventHandler(this.baceAttack_Click);
            // 
            // playerHpLabel
            // 
            this.playerHpLabel.AutoSize = true;
            this.playerHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHpLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playerHpLabel.Location = new System.Drawing.Point(216, 229);
            this.playerHpLabel.Name = "playerHpLabel";
            this.playerHpLabel.Size = new System.Drawing.Size(82, 31);
            this.playerHpLabel.TabIndex = 4;
            this.playerHpLabel.Text = "label1";
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameRun.Properties.Resources.Gym1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 377);
            this.Controls.Add(this.playerHpLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pokemonHpLabel);
            this.Controls.Add(this.PokemonBox);
            this.Controls.Add(this.CharacterBox);
            this.Name = "BattleScreen";
            this.Text = "Battle";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CharacterBox;
        private System.Windows.Forms.PictureBox PokemonBox;
        public System.Windows.Forms.Label pokemonHpLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button FirstorderAttack;
        public System.Windows.Forms.Button baceAttack;
        public System.Windows.Forms.Button FinalorderAttack;
        public System.Windows.Forms.Button SecondorderAttack;
        public System.Windows.Forms.Label playerHpLabel;
    }
}