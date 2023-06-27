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
            this.lv_monthList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.month = new System.Windows.Forms.ColumnHeader();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblWorkInfo = new System.Windows.Forms.Label();
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
            this.lv_dataList.Location = new System.Drawing.Point(135, 55);
            this.lv_dataList.Name = "lv_dataList";
            this.lv_dataList.Size = new System.Drawing.Size(551, 383);
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
            this.workMonth.Width = 100;
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
            // lv_monthList
            // 
            this.lv_monthList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.month});
            this.lv_monthList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_monthList.FullRowSelect = true;
            this.lv_monthList.GridLines = true;
            this.lv_monthList.Location = new System.Drawing.Point(12, 55);
            this.lv_monthList.Name = "lv_monthList";
            this.lv_monthList.Size = new System.Drawing.Size(104, 238);
            this.lv_monthList.TabIndex = 3;
            this.lv_monthList.UseCompatibleStateImageBehavior = false;
            this.lv_monthList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_monthList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // month
            // 
            this.month.Text = "월";
            this.month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month.Width = 100;
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(11, 16);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(127, 23);
            this.lblMonth.TabIndex = 4;
            // 
            // lblWorkInfo
            // 
            this.lblWorkInfo.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWorkInfo.Location = new System.Drawing.Point(144, 16);
            this.lblWorkInfo.Name = "lblWorkInfo";
            this.lblWorkInfo.Size = new System.Drawing.Size(332, 23);
            this.lblWorkInfo.TabIndex = 5;
            // 
            // MonthlyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 453);
            this.Controls.Add(this.lblWorkInfo);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lv_monthList);
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
        private ListView lv_monthList;
        private ColumnHeader columnHeader1;
        private ColumnHeader month;
        private Label lblMonth;
        private Label lblWorkInfo;
    }
}