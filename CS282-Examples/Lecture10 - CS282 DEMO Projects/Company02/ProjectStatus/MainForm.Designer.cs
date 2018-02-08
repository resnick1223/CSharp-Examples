namespace ProjectStatus
{
    partial class MainForm
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
            this.formHeaderPanel = new System.Windows.Forms.Panel();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.projectOpenDateTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.projectNumberTextBox = new System.Windows.Forms.TextBox();
            this.yearValueTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.openDateLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.projectNumberLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.pageChangePanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.slashLabel = new System.Windows.Forms.Label();
            this.totalItemLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.currentItemLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.projectStatusLabel = new System.Windows.Forms.Label();
            this.projectStatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saftyStatusPanel = new System.Windows.Forms.Panel();
            this.saftyStatusLabel = new System.Windows.Forms.Label();
            this.saftyStatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.projectNotePanel = new System.Windows.Forms.Panel();
            this.projectNoteLabel = new System.Windows.Forms.Label();
            this.projectNoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.formHeaderPanel.SuspendLayout();
            this.pageChangePanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.saftyStatusPanel.SuspendLayout();
            this.projectNotePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formHeaderPanel
            // 
            this.formHeaderPanel.Controls.Add(this.descriptionRichTextBox);
            this.formHeaderPanel.Controls.Add(this.projectOpenDateTextBox);
            this.formHeaderPanel.Controls.Add(this.productNameTextBox);
            this.formHeaderPanel.Controls.Add(this.projectNumberTextBox);
            this.formHeaderPanel.Controls.Add(this.yearValueTextBox);
            this.formHeaderPanel.Controls.Add(this.descriptionLabel);
            this.formHeaderPanel.Controls.Add(this.openDateLabel);
            this.formHeaderPanel.Controls.Add(this.productNameLabel);
            this.formHeaderPanel.Controls.Add(this.projectNumberLabel);
            this.formHeaderPanel.Controls.Add(this.yearLabel);
            this.formHeaderPanel.Location = new System.Drawing.Point(12, 12);
            this.formHeaderPanel.Name = "formHeaderPanel";
            this.formHeaderPanel.Size = new System.Drawing.Size(832, 70);
            this.formHeaderPanel.TabIndex = 0;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(438, 3);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(391, 64);
            this.descriptionRichTextBox.TabIndex = 2;
            this.descriptionRichTextBox.Text = "";
            this.descriptionRichTextBox.TextChanged += new System.EventHandler(this.descriptionRichTextBox_TextChanged);
            // 
            // projectOpenDateTextBox
            // 
            this.projectOpenDateTextBox.Location = new System.Drawing.Point(233, 36);
            this.projectOpenDateTextBox.Name = "projectOpenDateTextBox";
            this.projectOpenDateTextBox.Size = new System.Drawing.Size(118, 29);
            this.projectOpenDateTextBox.TabIndex = 2;
            this.projectOpenDateTextBox.Text = "2017/10/30";
            this.projectOpenDateTextBox.Leave += new System.EventHandler(this.projectOpenDateTextBox_Leave);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(63, 36);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(97, 29);
            this.productNameTextBox.TabIndex = 2;
            this.productNameTextBox.Text = "BOS-515S";
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
            // 
            // projectNumberTextBox
            // 
            this.projectNumberTextBox.Location = new System.Drawing.Point(233, 3);
            this.projectNumberTextBox.Name = "projectNumberTextBox";
            this.projectNumberTextBox.Size = new System.Drawing.Size(118, 29);
            this.projectNumberTextBox.TabIndex = 2;
            this.projectNumberTextBox.Text = "DP-1706";
            this.projectNumberTextBox.TextChanged += new System.EventHandler(this.projectNumberTextBox_TextChanged);
            // 
            // yearValueTextBox
            // 
            this.yearValueTextBox.Location = new System.Drawing.Point(63, 3);
            this.yearValueTextBox.MaxLength = 4;
            this.yearValueTextBox.Name = "yearValueTextBox";
            this.yearValueTextBox.ShortcutsEnabled = false;
            this.yearValueTextBox.Size = new System.Drawing.Size(97, 29);
            this.yearValueTextBox.TabIndex = 2;
            this.yearValueTextBox.Text = "2017";
            this.yearValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearValueTextBox_KeyPress);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.descriptionLabel.Location = new System.Drawing.Point(371, 3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(75, 27);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "敘述：";
            // 
            // openDateLabel
            // 
            this.openDateLabel.AutoSize = true;
            this.openDateLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openDateLabel.Location = new System.Drawing.Point(173, 36);
            this.openDateLabel.Name = "openDateLabel";
            this.openDateLabel.Size = new System.Drawing.Size(54, 27);
            this.openDateLabel.TabIndex = 1;
            this.openDateLabel.Text = "日期";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productNameLabel.Location = new System.Drawing.Point(3, 36);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(54, 27);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "產品";
            // 
            // projectNumberLabel
            // 
            this.projectNumberLabel.AutoSize = true;
            this.projectNumberLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectNumberLabel.Location = new System.Drawing.Point(173, 3);
            this.projectNumberLabel.Name = "projectNumberLabel";
            this.projectNumberLabel.Size = new System.Drawing.Size(54, 27);
            this.projectNumberLabel.TabIndex = 1;
            this.projectNumberLabel.Text = "編號";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearLabel.Location = new System.Drawing.Point(3, 3);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(54, 27);
            this.yearLabel.TabIndex = 1;
            this.yearLabel.Text = "年度";
            // 
            // pageChangePanel
            // 
            this.pageChangePanel.Controls.Add(this.saveButton);
            this.pageChangePanel.Controls.Add(this.slashLabel);
            this.pageChangePanel.Controls.Add(this.totalItemLabel);
            this.pageChangePanel.Controls.Add(this.nextButton);
            this.pageChangePanel.Controls.Add(this.currentItemLabel);
            this.pageChangePanel.Controls.Add(this.backButton);
            this.pageChangePanel.Location = new System.Drawing.Point(764, 125);
            this.pageChangePanel.Name = "pageChangePanel";
            this.pageChangePanel.Size = new System.Drawing.Size(80, 237);
            this.pageChangePanel.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 188);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 34);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.slashLabel.Location = new System.Drawing.Point(31, 65);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(21, 27);
            this.slashLabel.TabIndex = 1;
            this.slashLabel.Text = "/";
            // 
            // totalItemLabel
            // 
            this.totalItemLabel.AutoSize = true;
            this.totalItemLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalItemLabel.Location = new System.Drawing.Point(25, 95);
            this.totalItemLabel.Name = "totalItemLabel";
            this.totalItemLabel.Size = new System.Drawing.Size(36, 27);
            this.totalItemLabel.TabIndex = 1;
            this.totalItemLabel.Text = "50";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(18, 138);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(46, 30);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "︾";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // currentItemLabel
            // 
            this.currentItemLabel.AutoSize = true;
            this.currentItemLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.currentItemLabel.Location = new System.Drawing.Point(23, 37);
            this.currentItemLabel.Name = "currentItemLabel";
            this.currentItemLabel.Size = new System.Drawing.Size(36, 27);
            this.currentItemLabel.TabIndex = 1;
            this.currentItemLabel.Text = "10";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(18, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(46, 30);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "︽";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.projectStatusLabel);
            this.statusPanel.Controls.Add(this.projectStatusRichTextBox);
            this.statusPanel.Location = new System.Drawing.Point(12, 89);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(200, 423);
            this.statusPanel.TabIndex = 2;
            // 
            // projectStatusLabel
            // 
            this.projectStatusLabel.AutoSize = true;
            this.projectStatusLabel.Location = new System.Drawing.Point(76, 0);
            this.projectStatusLabel.Name = "projectStatusLabel";
            this.projectStatusLabel.Size = new System.Drawing.Size(41, 20);
            this.projectStatusLabel.TabIndex = 3;
            this.projectStatusLabel.Text = "狀態";
            // 
            // projectStatusRichTextBox
            // 
            this.projectStatusRichTextBox.Location = new System.Drawing.Point(7, 23);
            this.projectStatusRichTextBox.Name = "projectStatusRichTextBox";
            this.projectStatusRichTextBox.Size = new System.Drawing.Size(190, 397);
            this.projectStatusRichTextBox.TabIndex = 0;
            this.projectStatusRichTextBox.Text = "";
            this.projectStatusRichTextBox.TextChanged += new System.EventHandler(this.projectStatusRichTextBox_TextChanged);
            // 
            // saftyStatusPanel
            // 
            this.saftyStatusPanel.Controls.Add(this.saftyStatusLabel);
            this.saftyStatusPanel.Controls.Add(this.saftyStatusRichTextBox);
            this.saftyStatusPanel.Location = new System.Drawing.Point(218, 89);
            this.saftyStatusPanel.Name = "saftyStatusPanel";
            this.saftyStatusPanel.Size = new System.Drawing.Size(200, 423);
            this.saftyStatusPanel.TabIndex = 2;
            // 
            // saftyStatusLabel
            // 
            this.saftyStatusLabel.AutoSize = true;
            this.saftyStatusLabel.Location = new System.Drawing.Point(76, 0);
            this.saftyStatusLabel.Name = "saftyStatusLabel";
            this.saftyStatusLabel.Size = new System.Drawing.Size(41, 20);
            this.saftyStatusLabel.TabIndex = 3;
            this.saftyStatusLabel.Text = "安規";
            // 
            // saftyStatusRichTextBox
            // 
            this.saftyStatusRichTextBox.Location = new System.Drawing.Point(7, 23);
            this.saftyStatusRichTextBox.Name = "saftyStatusRichTextBox";
            this.saftyStatusRichTextBox.Size = new System.Drawing.Size(190, 397);
            this.saftyStatusRichTextBox.TabIndex = 0;
            this.saftyStatusRichTextBox.Text = "";
            this.saftyStatusRichTextBox.TextChanged += new System.EventHandler(this.saftyStatusRichTextBox_TextChanged);
            // 
            // projectNotePanel
            // 
            this.projectNotePanel.Controls.Add(this.projectNoteLabel);
            this.projectNotePanel.Controls.Add(this.projectNoteRichTextBox);
            this.projectNotePanel.Location = new System.Drawing.Point(424, 89);
            this.projectNotePanel.Name = "projectNotePanel";
            this.projectNotePanel.Size = new System.Drawing.Size(334, 423);
            this.projectNotePanel.TabIndex = 2;
            // 
            // projectNoteLabel
            // 
            this.projectNoteLabel.AutoSize = true;
            this.projectNoteLabel.Location = new System.Drawing.Point(146, 0);
            this.projectNoteLabel.Name = "projectNoteLabel";
            this.projectNoteLabel.Size = new System.Drawing.Size(41, 20);
            this.projectNoteLabel.TabIndex = 3;
            this.projectNoteLabel.Text = "說明";
            // 
            // projectNoteRichTextBox
            // 
            this.projectNoteRichTextBox.Location = new System.Drawing.Point(7, 23);
            this.projectNoteRichTextBox.Name = "projectNoteRichTextBox";
            this.projectNoteRichTextBox.Size = new System.Drawing.Size(324, 397);
            this.projectNoteRichTextBox.TabIndex = 0;
            this.projectNoteRichTextBox.Text = "";
            this.projectNoteRichTextBox.TextChanged += new System.EventHandler(this.projectNoteRichTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 524);
            this.Controls.Add(this.projectNotePanel);
            this.Controls.Add(this.saftyStatusPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.pageChangePanel);
            this.Controls.Add(this.formHeaderPanel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "ProjectControl";
            this.Leave += new System.EventHandler(this.projectOpenDateTextBox_Leave);
            this.formHeaderPanel.ResumeLayout(false);
            this.formHeaderPanel.PerformLayout();
            this.pageChangePanel.ResumeLayout(false);
            this.pageChangePanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.saftyStatusPanel.ResumeLayout(false);
            this.saftyStatusPanel.PerformLayout();
            this.projectNotePanel.ResumeLayout(false);
            this.projectNotePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formHeaderPanel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Panel pageChangePanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.Label totalItemLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label currentItemLabel;
        private System.Windows.Forms.TextBox yearValueTextBox;
        private System.Windows.Forms.TextBox projectNumberTextBox;
        private System.Windows.Forms.Label projectNumberLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox projectOpenDateTextBox;
        private System.Windows.Forms.Label openDateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label projectStatusLabel;
        private System.Windows.Forms.RichTextBox projectStatusRichTextBox;
        private System.Windows.Forms.Panel saftyStatusPanel;
        private System.Windows.Forms.Label saftyStatusLabel;
        private System.Windows.Forms.RichTextBox saftyStatusRichTextBox;
        private System.Windows.Forms.Panel projectNotePanel;
        private System.Windows.Forms.Label projectNoteLabel;
        private System.Windows.Forms.RichTextBox projectNoteRichTextBox;
    }
}

