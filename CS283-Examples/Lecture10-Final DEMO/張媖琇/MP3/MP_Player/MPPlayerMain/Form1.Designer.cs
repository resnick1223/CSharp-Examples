namespace MPPlayerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AXwmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.add_button = new System.Windows.Forms.Button();
            this.musiclistbox = new System.Windows.Forms.ListBox();
            this.play_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AXwmp)).BeginInit();
            this.SuspendLayout();
            // 
            // AXwmp
            // 
            this.AXwmp.Enabled = true;
            this.AXwmp.Location = new System.Drawing.Point(12, 12);
            this.AXwmp.Name = "AXwmp";
            this.AXwmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AXwmp.OcxState")));
            this.AXwmp.Size = new System.Drawing.Size(404, 106);
            this.AXwmp.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add_button.Location = new System.Drawing.Point(12, 137);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(117, 46);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "加入音樂選單";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // musiclistbox
            // 
            this.musiclistbox.FormattingEnabled = true;
            this.musiclistbox.ItemHeight = 12;
            this.musiclistbox.Location = new System.Drawing.Point(151, 137);
            this.musiclistbox.Name = "musiclistbox";
            this.musiclistbox.Size = new System.Drawing.Size(265, 160);
            this.musiclistbox.TabIndex = 3;
            this.musiclistbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // play_button
            // 
            this.play_button.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.play_button.Location = new System.Drawing.Point(12, 199);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(117, 40);
            this.play_button.TabIndex = 4;
            this.play_button.Text = "播放";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // stop_button
            // 
            this.stop_button.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stop_button.Location = new System.Drawing.Point(12, 257);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(117, 40);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "停止";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MPPlayerMain.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(428, 309);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.musiclistbox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.AXwmp);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AXwmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer AXwmp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListBox musiclistbox;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button stop_button;
    }
}

