namespace HealthNote
{
    partial class SummaryForm
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
            this.workType = new System.Windows.Forms.ColumnHeader();
            this.workTotalCount = new System.Windows.Forms.ColumnHeader();
            this.workAvgCount = new System.Windows.Forms.ColumnHeader();
            this.workSet = new System.Windows.Forms.ColumnHeader();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_dataList
            // 
            this.lv_dataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header,
            this.workType,
            this.workTotalCount,
            this.workAvgCount,
            this.workSet});
            this.lv_dataList.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_dataList.FullRowSelect = true;
            this.lv_dataList.GridLines = true;
            this.lv_dataList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_dataList.Location = new System.Drawing.Point(14, 73);
            this.lv_dataList.Name = "lv_dataList";
            this.lv_dataList.Size = new System.Drawing.Size(452, 232);
            this.lv_dataList.TabIndex = 1;
            this.lv_dataList.UseCompatibleStateImageBehavior = false;
            // 
            // header
            // 
            this.header.DisplayIndex = 4;
            this.header.Width = 0;
            // 
            // workType
            // 
            this.workType.DisplayIndex = 0;
            this.workType.Text = "종목";
            this.workType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workType.Width = 120;
            // 
            // workTotalCount
            // 
            this.workTotalCount.DisplayIndex = 1;
            this.workTotalCount.Text = "총 횟수/시간";
            this.workTotalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workTotalCount.Width = 120;
            // 
            // workAvgCount
            // 
            this.workAvgCount.DisplayIndex = 2;
            this.workAvgCount.Text = "평균 횟수/시간";
            this.workAvgCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workAvgCount.Width = 120;
            // 
            // workSet
            // 
            this.workSet.DisplayIndex = 3;
            this.workSet.Text = "세트";
            this.workSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateTime.Location = new System.Drawing.Point(16, 19);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(450, 40);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 319);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lv_dataList);
            this.KeyPreview = true;
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SummaryForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lv_dataList;
        private ColumnHeader workType;
        private ColumnHeader workAvgCount;
        private ColumnHeader workTotalCount;
        private Label lblDateTime;
        private ColumnHeader workSet;
        private ColumnHeader header;
    }
}