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
            this.workType = new System.Windows.Forms.ColumnHeader();
            this.workCount = new System.Windows.Forms.ColumnHeader();
            this.workTime = new System.Windows.Forms.ColumnHeader();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_dataList
            // 
            this.lv_dataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workType,
            this.workCount,
            this.workTime});
            this.lv_dataList.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_dataList.FullRowSelect = true;
            this.lv_dataList.GridLines = true;
            this.lv_dataList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_dataList.Location = new System.Drawing.Point(14, 73);
            this.lv_dataList.Name = "lv_dataList";
            this.lv_dataList.Size = new System.Drawing.Size(366, 232);
            this.lv_dataList.TabIndex = 1;
            this.lv_dataList.UseCompatibleStateImageBehavior = false;
            // 
            // workType
            // 
            this.workType.Text = "종목";
            this.workType.Width = 120;
            // 
            // workCount
            // 
            this.workCount.Text = "횟수/시간";
            this.workCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workCount.Width = 100;
            // 
            // workTime
            // 
            this.workTime.Text = "날짜";
            this.workTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workTime.Width = 120;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateTime.Location = new System.Drawing.Point(16, 19);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(364, 40);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 324);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lv_dataList);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lv_dataList;
        private ColumnHeader workType;
        private ColumnHeader workCount;
        private ColumnHeader workTime;
        private Label lblDateTime;
    }
}