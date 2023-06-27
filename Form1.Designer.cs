namespace HealthNote
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_dataList = new System.Windows.Forms.ListView();
            this.header = new System.Windows.Forms.ColumnHeader();
            this.workType = new System.Windows.Forms.ColumnHeader();
            this.workCount = new System.Windows.Forms.ColumnHeader();
            this.workTime = new System.Windows.Forms.ColumnHeader();
            this.cbbKind = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSetCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTues = new System.Windows.Forms.Label();
            this.lblWednes = new System.Windows.Forms.Label();
            this.lblThurs = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblSun = new System.Windows.Forms.Label();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_dataList
            // 
            this.lv_dataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header,
            this.workType,
            this.workCount,
            this.workTime});
            this.lv_dataList.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_dataList.FullRowSelect = true;
            this.lv_dataList.GridLines = true;
            this.lv_dataList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_dataList.Location = new System.Drawing.Point(12, 12);
            this.lv_dataList.Name = "lv_dataList";
            this.lv_dataList.Size = new System.Drawing.Size(365, 497);
            this.lv_dataList.TabIndex = 0;
            this.lv_dataList.UseCompatibleStateImageBehavior = false;
            // 
            // header
            // 
            this.header.DisplayIndex = 3;
            this.header.Width = 0;
            // 
            // workType
            // 
            this.workType.DisplayIndex = 0;
            this.workType.Text = "종목";
            this.workType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workType.Width = 120;
            // 
            // workCount
            // 
            this.workCount.DisplayIndex = 1;
            this.workCount.Text = "횟수/시간";
            this.workCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workCount.Width = 100;
            // 
            // workTime
            // 
            this.workTime.DisplayIndex = 2;
            this.workTime.Text = "날짜";
            this.workTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workTime.Width = 120;
            // 
            // cbbKind
            // 
            this.cbbKind.FormattingEnabled = true;
            this.cbbKind.Location = new System.Drawing.Point(425, 12);
            this.cbbKind.Name = "cbbKind";
            this.cbbKind.Size = new System.Drawing.Size(130, 23);
            this.cbbKind.TabIndex = 1;
            this.cbbKind.SelectedValueChanged += new System.EventHandler(this.cbbKind_SelectedValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(593, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "기록하기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(593, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 26);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSetCount
            // 
            this.lblSetCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSetCount.Location = new System.Drawing.Point(497, 85);
            this.lblSetCount.Name = "lblSetCount";
            this.lblSetCount.Size = new System.Drawing.Size(58, 23);
            this.lblSetCount.TabIndex = 5;
            this.lblSetCount.Text = "0";
            this.lblSetCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(425, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "횟수 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(425, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "세트 수 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCount.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCount.Location = new System.Drawing.Point(497, 49);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(58, 18);
            this.txtCount.TabIndex = 8;
            this.txtCount.Text = "0";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(530, 120);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(100, 40);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonday.Location = new System.Drawing.Point(460, 162);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(50, 20);
            this.lblMonday.TabIndex = 10;
            this.lblMonday.Text = "월요일";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTues
            // 
            this.lblTues.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTues.Location = new System.Drawing.Point(516, 162);
            this.lblTues.Name = "lblTues";
            this.lblTues.Size = new System.Drawing.Size(50, 20);
            this.lblTues.TabIndex = 11;
            this.lblTues.Text = "화요일";
            this.lblTues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWednes
            // 
            this.lblWednes.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWednes.Location = new System.Drawing.Point(572, 162);
            this.lblWednes.Name = "lblWednes";
            this.lblWednes.Size = new System.Drawing.Size(50, 20);
            this.lblWednes.TabIndex = 12;
            this.lblWednes.Text = "수요일";
            this.lblWednes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThurs
            // 
            this.lblThurs.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThurs.Location = new System.Drawing.Point(628, 162);
            this.lblThurs.Name = "lblThurs";
            this.lblThurs.Size = new System.Drawing.Size(50, 20);
            this.lblThurs.TabIndex = 13;
            this.lblThurs.Text = "목요일";
            this.lblThurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFri
            // 
            this.lblFri.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFri.Location = new System.Drawing.Point(684, 162);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(50, 20);
            this.lblFri.TabIndex = 14;
            this.lblFri.Text = "금요일";
            this.lblFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSat
            // 
            this.lblSat.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSat.Location = new System.Drawing.Point(740, 162);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(50, 20);
            this.lblSat.TabIndex = 15;
            this.lblSat.Text = "토요일";
            this.lblSat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSun
            // 
            this.lblSun.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSun.Location = new System.Drawing.Point(404, 162);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(50, 20);
            this.lblSun.TabIndex = 16;
            this.lblSun.Text = "일요일";
            this.lblSun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddWork
            // 
            this.btnAddWork.Location = new System.Drawing.Point(716, 12);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(88, 26);
            this.btnAddWork.TabIndex = 17;
            this.btnAddWork.Text = "운동추가";
            this.btnAddWork.UseVisualStyleBackColor = true;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Location = new System.Drawing.Point(716, 47);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(88, 26);
            this.btnMonthlyReport.TabIndex = 18;
            this.btnMonthlyReport.Text = "월별 레포트";
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 521);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.btnAddWork);
            this.Controls.Add(this.lblSun);
            this.Controls.Add(this.lblSat);
            this.Controls.Add(this.lblFri);
            this.Controls.Add(this.lblThurs);
            this.Controls.Add(this.lblWednes);
            this.Controls.Add(this.lblTues);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSetCount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbKind);
            this.Controls.Add(this.lv_dataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Health_Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_dataList;
        private ComboBox cbbKind;
        private Button btnAdd;
        private Button btnDelete;
        private Label lblSetCount;
        private Label label1;
        private Label label2;
        private TextBox txtCount;
        private ColumnHeader workType;
        private ColumnHeader workCount;
        private ColumnHeader workTime;
        private Label lblMonth;
        private Label lblMonday;
        private Label lblTues;
        private Label lblWednes;
        private Label lblThurs;
        private Label lblFri;
        private Label lblSat;
        private Label lblSun;
        private ColumnHeader header;
        private Button btnAddWork;
        private Button btnMonthlyReport;
    }
}