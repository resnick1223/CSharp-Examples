namespace StudentsAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.資料維護ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增學生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新學生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsDataGrid = new System.Windows.Forms.DataGridView();
            this.讀取資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.資料維護ToolStripMenuItem,
            this.讀取資料ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 資料維護ToolStripMenuItem
            // 
            this.資料維護ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增學生ToolStripMenuItem,
            this.更新學生ToolStripMenuItem});
            this.資料維護ToolStripMenuItem.Name = "資料維護ToolStripMenuItem";
            this.資料維護ToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.資料維護ToolStripMenuItem.Text = "資料維護";
            // 
            // 新增學生ToolStripMenuItem
            // 
            this.新增學生ToolStripMenuItem.Name = "新增學生ToolStripMenuItem";
            this.新增學生ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.新增學生ToolStripMenuItem.Text = "新增學生";
            this.新增學生ToolStripMenuItem.Click += new System.EventHandler(this.新增學生ToolStripMenuItem_Click);
            // 
            // 更新學生ToolStripMenuItem
            // 
            this.更新學生ToolStripMenuItem.Name = "更新學生ToolStripMenuItem";
            this.更新學生ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.更新學生ToolStripMenuItem.Text = "更新學生";
            this.更新學生ToolStripMenuItem.Click += new System.EventHandler(this.更新學生ToolStripMenuItem_Click);
            // 
            // studentsDataGrid
            // 
            this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StudentName,
            this.Phone});
            this.studentsDataGrid.Location = new System.Drawing.Point(12, 39);
            this.studentsDataGrid.Name = "studentsDataGrid";
            this.studentsDataGrid.RowTemplate.Height = 27;
            this.studentsDataGrid.Size = new System.Drawing.Size(697, 364);
            this.studentsDataGrid.TabIndex = 1;
            // 
            // 讀取資料ToolStripMenuItem
            // 
            this.讀取資料ToolStripMenuItem.Name = "讀取資料ToolStripMenuItem";
            this.讀取資料ToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.讀取資料ToolStripMenuItem.Text = "讀取資料";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 406);
            this.Controls.Add(this.studentsDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 資料維護ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增學生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新學生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 讀取資料ToolStripMenuItem;
        private System.Windows.Forms.DataGridView studentsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}