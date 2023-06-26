namespace HealthNote
{
    partial class MonthlyReportForm
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
            this.lv_dataList = new System.Windows.Forms.ListView();
            this.header = new System.Windows.Forms.ColumnHeader();
            this.workMonth = new System.Windows.Forms.ColumnHeader();
            this.workType = new System.Windows.Forms.ColumnHeader();
            this.workTotalCount = new System.Windows.Forms.ColumnHeader();
            this.workAvgCount = new System.Windows.Forms.ColumnHeader();
            this.workSet = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lv_dataList
            // 
            this.lv_dataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header,
            this.workMonth,
            this.workType,
            this.workTotalCount,
            this.workAvgCount,
            this.workSet});
            this.lv_dataList.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_dataList.FullRowSelect = true;
            this.lv_dataList.GridLines = true;
            this.lv_dataList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_dataList.Location = new System.Drawing.Point(12, 12);
            this.lv_dataList.Name = "lv_dataList";
            this.lv_dataList.Size = new System.Drawing.Size(512, 426);
            this.lv_dataList.TabIndex = 2;
            this.lv_dataList.UseCompatibleStateImageBehavior = false;
            // 
            // header
            // 
            this.header.Width = 0;
            // 
            // workMonth
            // 
            this.workMonth.Text = "월";
            this.workMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // workType
            // 
            this.workType.Text = "종목";
            this.workType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workType.Width = 120;
            // 
            // workTotalCount
            // 
            this.workTotalCount.Text = "총 횟수/시간";
            this.workTotalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workTotalCount.Width = 120;
            // 
            // workAvgCount
            // 
            this.workAvgCount.Text = "평균 횟수/시간";
            this.workAvgCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workAvgCount.Width = 120;
            // 
            // workSet
            // 
            this.workSet.Text = "총 세트";
            this.workSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workSet.Width = 80;
            // 
            // MonthlyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.lv_dataList);
            this.KeyPreview = true;
            this.Name = "MonthlyReportForm";
            this.Text = "MonthlyReportForm";
            this.Load += new System.EventHandler(this.MonthlyReportForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MonthlyReportForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lv_dataList;
        private ColumnHeader header;
        private ColumnHeader workMonth;
        private ColumnHeader workType;
        private ColumnHeader workTotalCount;
        private ColumnHeader workAvgCount;
        private ColumnHeader workSet;
    }
}