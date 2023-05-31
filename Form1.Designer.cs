namespace HealthNote
{
    partial class Form1
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
            this.lv_dataList.Location = new System.Drawing.Point(12, 12);
            this.lv_dataList.Name = "lv_dataList";
            this.lv_dataList.Size = new System.Drawing.Size(365, 426);
            this.lv_dataList.TabIndex = 0;
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
            this.btnAdd.Location = new System.Drawing.Point(608, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "기록하기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(608, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 26);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSetCount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbKind);
            this.Controls.Add(this.lv_dataList);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}