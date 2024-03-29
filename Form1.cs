using System.Timers;

namespace HealthNote
{
    public partial class MainForm : Form
    {
        private static DataBaseManager dataBaseManager = DataBaseManager.Instance;

        private int workOutTimerSecond = 0;
        private int workOutTimerMinute = 0;

        private int currentYear = 0;

        Button[] buttons = new Button[DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)];
        public MainForm()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectWorkOutData();

            Update_WorkComboBox();

            Create_Calendar();

            currentYear = DateTime.Now.Year;
        }

        private void cbbKind_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbKind.SelectedItem.ToString() == "필라테스" || cbbKind.SelectedItem.ToString() == "요가"
              || cbbKind.SelectedItem.ToString() == "스트레칭" || cbbKind.SelectedItem.ToString() == "폼롤러스트레칭") label1.Text = "시간 : ";
            else label1.Text = "횟수 : ";

            lblSetCount.Text = "0";
            txtCount.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtCount.Text) == 0)
            {
                MessageBox.Show("0개/0분 은 기록할 수 없습니다.");
                return;
            }
            WorkOutInfo newWorkOutInfo = new WorkOutInfo();
            newWorkOutInfo.WorkType = cbbKind.SelectedItem.ToString();
            newWorkOutInfo.Count = int.Parse(txtCount.Text);
            newWorkOutInfo.WorkDateTime = DateTime.Now.ToString("yyyy-MM-dd");

            if(dataBaseManager.InsertWorkData(newWorkOutInfo)) MessageBox.Show("Data Insert Success");
            else MessageBox.Show("Data Insert Fail");

            int curSetCount = int.Parse(lblSetCount.Text);
            curSetCount += 1;

            lblSetCount.Text = curSetCount.ToString();

            SelectWorkOutData();

            Update_Calendar(newWorkOutInfo.WorkDateTime, "Add");

            this.Cursor = Cursors.Default;
        }

        private void Update_Calendar(string workDateTime, string addOrDelete)
        {
            int date = int.Parse(workDateTime.Substring(8, 2));

            if (addOrDelete.Equals("Add"))
            {
                this.Controls.Remove(buttons[date - 1]);
                this.buttons[date - 1].Enabled = true;
                this.buttons[date - 1].BackColor = Color.LightSkyBlue;
                this.buttons[date - 1].ForeColor = Color.White;
                this.Controls.Add(buttons[date - 1]);
            }
            else if (addOrDelete.Equals("Delete"))
            {
                for (int i = 0; i < lv_dataList.Items.Count; i++) 
                {
                    if (lv_dataList.Items[i].SubItems[3].Text == workDateTime) return;
                }
                this.Controls.Remove(buttons[date - 1]);
                this.buttons[date - 1].Enabled = false;
                this.buttons[date - 1].BackColor = Color.White;
                this.buttons[date - 1].ForeColor = Color.Black;
                this.Controls.Add(buttons[date - 1]);
            }
            
        }

        private void SelectWorkOutData()
        {
            lv_dataList.Items.Clear();

            lv_dataList.BeginUpdate();

            lv_dataList.View = View.Details;

            List<WorkOutInfo> healthInfos = dataBaseManager.SelectHealthInfo();
            for (int i = 0; i < healthInfos.Count; i++)
            {
                ListViewItem items = new ListViewItem("");
                items.SubItems.Add(healthInfos[i].WorkType);

                if (healthInfos[i].WorkType == "필라테스" || healthInfos[i].WorkType == "요가" || healthInfos[i].WorkType == "스트레칭" || healthInfos[i].WorkType == "폼롤러스트레칭")
                    items.SubItems.Add(healthInfos[i].Count.ToString() + "분");
                else items.SubItems.Add(healthInfos[i].Count.ToString() + "개");

                items.SubItems.Add(healthInfos[i].WorkDateTime);

                lv_dataList.Items.Add(items);
            }

            lv_dataList.EndUpdate();
        }

        private void Create_Calendar()
        {       
            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            int checkStartWeekDay = (int)dateTime.DayOfWeek;
            int checkWeekVertical = 0;
            int checkWeekHorizontal = checkStartWeekDay;

            this.lblMonth.Text = DateTime.Now.Month.ToString() + "월";

            for (int i = 0; i < DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                if (checkWeekHorizontal % 7 == 0)
                {
                    checkWeekVertical += 7;
                    checkWeekHorizontal = 0;
                }

                buttons[i] = new Button();
                buttons[i].Location = new Point(400 + (checkWeekHorizontal * 56), 200 + (checkWeekVertical * 8));
                buttons[i].Size = new Size(50, 40);
                buttons[i].Text = (i+1).ToString();
                buttons[i].BackColor = Color.White;
                buttons[i].ForeColor = Color.Black;
                buttons[i].Enabled = false;
                buttons[i].Click += (sender, e2) => Day_Button_Click(sender!, e2);

                for (int k = 0; k < lv_dataList.Items.Count; k++)
                {
                    if (lv_dataList.Items[k].SubItems[3].Text == $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("D2")}-{i.ToString("D2")}")
                    {
                        buttons[i - 1].Enabled = true;
                        buttons[i - 1].BackColor = Color.LightSkyBlue;
                        buttons[i - 1].ForeColor = Color.White;
                        break;
                    }
                }

                this.Controls.Add(buttons[i]);

                checkWeekHorizontal++;
            }
        }

        private void Day_Button_Click(object sender, EventArgs e2)
        {
            int currentMonth = int.Parse(this.lblMonth.Text.Replace("월", "").Trim());

            string openDateTime = String.Format("{0}-{1}-{2}", currentYear, currentMonth.ToString("D2"), ((Control)sender).Text.PadLeft(2, '0'));
            
            SummaryForm summaryForm = new SummaryForm(openDateTime);
            summaryForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WorkOutInfo workData = new WorkOutInfo();
            workData.WorkType = lv_dataList.SelectedItems[0].SubItems[1].Text;
            
            if (workData.WorkType == "필라테스" || workData.WorkType == "요가" || workData.WorkType == "스트레칭" || workData.WorkType == "폼롤러스트레칭")
                workData.Count = int.Parse(lv_dataList.SelectedItems[0].SubItems[2].Text.Replace("분", ""));
            else workData.Count = int.Parse(lv_dataList.SelectedItems[0].SubItems[2].Text.Replace("개", ""));
            
            workData.WorkDateTime = lv_dataList.SelectedItems[0].SubItems[3].Text;

            if (dataBaseManager.DeleteWorkData(workData)) MessageBox.Show("Delete Success");
            else MessageBox.Show("Delete Failed");

            SelectWorkOutData();

            Update_Calendar(workData.WorkDateTime, "Delete");

            this.Cursor = Cursors.Default;
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            AddWorkForm addWorkForm = new AddWorkForm();
            addWorkForm.FormClosed += AddWorkForm_FormClosed;
            addWorkForm.ShowDialog();
        }

        private void AddWorkForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Update_WorkComboBox();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Update_WorkComboBox();
        }
        private void Update_WorkComboBox()
        {
            cbbKind.Items.Clear();

            List<string> workTypes = dataBaseManager.SelectWorkTypes();

            for (int i = 0; i < workTypes.Count; i++)
            {
                cbbKind.Items.Add(workTypes[i]);
            }

            cbbKind.SelectedItem = workTypes[0];
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            MonthlyReportForm monthlyReportForm = new MonthlyReportForm(lv_dataList.Items);
            monthlyReportForm.ShowDialog();
        }

        private void btnTimerControl_Click(object sender, EventArgs e)
        {
            if (this.btnTimerControl.Text == "Start")
            {
                workTimer.Start();
                this.btnTimerControl.Text = "Stop";
            }
            else 
            {
                workTimer.Stop();
                if (workOutTimerSecond > 50) workOutTimerMinute++;
                txtCount.Text = workOutTimerMinute.ToString();
                workOutTimerSecond = 0;
                workOutTimerMinute = 0;
                this.lblTimerCount.Text = "0분 0초";
                this.btnTimerControl.Text = "Start";
            }
            this.Cursor = Cursors.Default;
        }

        private void workTimer_Tick(object sender, EventArgs e)
        {
            workOutTimerSecond++;
            if (workOutTimerSecond > 59)
            {
                workOutTimerSecond = 0;
                workOutTimerMinute++;
            }
            this.lblTimerCount.Text = workOutTimerMinute.ToString() + "분 " + workOutTimerSecond.ToString() + "초";
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            try
            {
                int currentMonth = int.Parse(this.lblMonth.Text.Replace("월", "").Trim());

                for (int i = 0; i < DateTime.DaysInMonth(currentYear, currentMonth); i++)
                {
                    this.Controls.Remove(buttons[i]);
                }

                if (currentMonth == 1)
                {
                    currentYear -= 1;

                    currentMonth = 12;
                }
                else currentMonth -= 1;

                DateTime dateTime = new DateTime(currentYear, currentMonth, 1);

                int checkStartWeekDay = (int)dateTime.DayOfWeek;
                int checkWeekVertical = 0;
                int checkWeekHorizontal = checkStartWeekDay;

                this.lblMonth.Text = currentMonth.ToString() + "월";

                buttons = new Button[DateTime.DaysInMonth(currentYear, currentMonth)];

                for (int i = 0; i < DateTime.DaysInMonth(currentYear, currentMonth); i++)
                {
                    if (i != 0 && checkWeekHorizontal % 7 == 0)
                    {
                        checkWeekVertical += 7;
                        checkWeekHorizontal = 0;
                    }

                    buttons[i] = new Button();
                    buttons[i].Location = new Point(400 + (checkWeekHorizontal * 56), 200 + (checkWeekVertical * 8));
                    buttons[i].Size = new Size(50, 40);
                    buttons[i].Text = (i + 1).ToString();
                    buttons[i].BackColor = Color.White;
                    buttons[i].ForeColor = Color.Black;
                    buttons[i].Enabled = false;
                    buttons[i].Click += (sender, e2) => Day_Button_Click(sender!, e2);

                    for (int k = 0; k < lv_dataList.Items.Count; k++)
                    {
                        if (lv_dataList.Items[k].SubItems[3].Text == $"{currentYear}-{currentMonth.ToString("D2")}-{i.ToString("D2")}")
                        {
                            buttons[i - 1].Enabled = true;
                            buttons[i - 1].BackColor = Color.LightSkyBlue;
                            buttons[i - 1].ForeColor = Color.White;
                            break;
                        }
                    }

                    this.Controls.Add(buttons[i]);

                    checkWeekHorizontal++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            try
            {
                int currentMonth = int.Parse(this.lblMonth.Text.Replace("월", "").Trim());

                for (int i = 0; i < DateTime.DaysInMonth(currentYear, currentMonth); i++)
                {
                    this.Controls.Remove(buttons[i]);
                }

                if (currentMonth == 12)
                {
                    currentYear += 1;

                    currentMonth = 1;
                }
                else currentMonth += 1;

                DateTime dateTime = new DateTime(currentYear, currentMonth, 1);

                int checkStartWeekDay = (int)dateTime.DayOfWeek;
                int checkWeekVertical = 0;
                int checkWeekHorizontal = checkStartWeekDay;

                this.lblMonth.Text = currentMonth.ToString() + "월";

                buttons = new Button[DateTime.DaysInMonth(currentYear, currentMonth)];

                for (int i = 0; i < DateTime.DaysInMonth(currentYear, currentMonth); i++)
                {
                    if (i != 0 && checkWeekHorizontal % 7 == 0)
                    {
                        checkWeekVertical += 7;
                        checkWeekHorizontal = 0;
                    }

                    buttons[i] = new Button();
                    buttons[i].Location = new Point(400 + (checkWeekHorizontal * 56), 200 + (checkWeekVertical * 8));
                    buttons[i].Size = new Size(50, 40);
                    buttons[i].Text = (i + 1).ToString();
                    buttons[i].BackColor = Color.White;
                    buttons[i].ForeColor = Color.Black;
                    buttons[i].Enabled = false;
                    buttons[i].Click += (sender, e2) => Day_Button_Click(sender!, e2);

                    for (int k = 0; k < lv_dataList.Items.Count; k++)
                    {
                        if (lv_dataList.Items[k].SubItems[3].Text == $"{currentYear}-{currentMonth.ToString("D2")}-{i.ToString("D2")}")
                        {
                            buttons[i - 1].Enabled = true;
                            buttons[i - 1].BackColor = Color.LightSkyBlue;
                            buttons[i - 1].ForeColor = Color.White;
                            break;
                        }
                    }

                    this.Controls.Add(buttons[i]);

                    checkWeekHorizontal++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}