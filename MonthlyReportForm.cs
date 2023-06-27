using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace HealthNote
{
    public partial class MonthlyReportForm : Form
    {
        private static DataBaseManager dataBaseManager = DataBaseManager.Instance;
        private List<WorkOutInfo> healthInfos = new List<WorkOutInfo>();
        private Dictionary<string, int> healthInfoDays = new Dictionary<string, int>();
        public List<WorkOutInfo> HealthInfos
        {
            get
            {
                return healthInfos;
            }
            set
            {
                this.healthInfos = value;
            }
        }
        public Dictionary<string, int> HealthInfoDays
        {
            get
            {
                return healthInfoDays;
            }
            set
            {
                this.healthInfoDays = value;
            }
        }
        public MonthlyReportForm(ListView.ListViewItemCollection items)
        {
            InitializeComponent();

            List<WorkOutInfo> days = new List<WorkOutInfo>();
            for (int i = 0; i < items.Count; i++)
            {
                days.Add(new WorkOutInfo
                {
                    WorkDateTime = items[i].SubItems[3].Text,
                    WorkType = items[i].SubItems[0].Text
                });
            }
            healthInfoDays = days.DistinctBy(x => x.WorkDateTime).GroupBy(x => DateTime.Parse(x.WorkDateTime!).ToString("yyyy-MM")).ToDictionary(x => x.Key!, x => x.Count());
        } 

        private void MonthlyReportForm_Load(object sender, EventArgs e)
        {
            SelectMonth();
        }

        private void SelectMonth()
        {
            HealthInfos = dataBaseManager.SelectMonthlyReportInfo();

            lv_monthList.Items.Clear();

            lv_monthList.BeginUpdate();

            lv_monthList.View = View.Details;

            List<string> months = HealthInfos.DistinctBy(x => x.WorkDateTime).Select(x=>x.WorkDateTime).ToList()!;

            for (int i = 0; i < months.Count; i++)
            {
                ListViewItem items = new ListViewItem("");

                items.SubItems.Add(months[i] + "월");

                lv_monthList.Items.Add(items);
            }

            lv_monthList.EndUpdate();
        }

        private void SelectMonthlyData(string workOutYearMonth)
        {
            lv_dataList.Items.Clear();

            lv_dataList.BeginUpdate();

            lv_dataList.View = View.Details;

            for (int i = 0; i < HealthInfos.Count; i++)
            {
                if (HealthInfos[i].WorkDateTime!.Equals(workOutYearMonth))
                {
                    ListViewItem items = new ListViewItem("");

                    items.SubItems.Add(healthInfos[i].WorkDateTime + "월");

                    items.SubItems.Add(healthInfos[i].WorkType);

                    if (healthInfos[i].WorkType == "필라테스" || healthInfos[i].WorkType == "요가" || healthInfos[i].WorkType == "스트레칭")
                        items.SubItems.Add(healthInfos[i].TotalCount.ToString() + "분");
                    else items.SubItems.Add(healthInfos[i].TotalCount.ToString() + "개");

                    if (healthInfos[i].WorkType == "필라테스" || healthInfos[i].WorkType == "요가" || healthInfos[i].WorkType == "스트레칭")
                        items.SubItems.Add(healthInfos[i].Count.ToString() + "분");
                    else items.SubItems.Add(healthInfos[i].Count.ToString() + "개");

                    items.SubItems.Add(healthInfos[i].TotalSet.ToString() + "번");

                    lv_dataList.Items.Add(items);
                }              
            }
            lv_dataList.EndUpdate();

            lblMonth.Text = workOutYearMonth + "월";
            lblWorkInfo.Text = "총 " +
                DateTime.DaysInMonth(int.Parse(workOutYearMonth.Substring(0, 4)), int.Parse(workOutYearMonth.Substring(5, 2))) +
                "일 중 " + healthInfoDays[workOutYearMonth.Replace("년", "-")] + "일 운동!  ( " +
                 (Math.Round((double)(healthInfoDays[workOutYearMonth.Replace("년", "-")] / (double)DateTime.DaysInMonth(int.Parse(workOutYearMonth.Substring(0, 4)), int.Parse(workOutYearMonth.Substring(5, 2))))
                 * 100)).ToString() + "% )";
        }

        private void MonthlyReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
            {
                this.Close();
            }
        }
        private void lv_monthList_MouseClick(object sender, MouseEventArgs e)
        {
            SelectMonthlyData(lv_monthList.SelectedItems[0].SubItems[1].Text.Replace("월", ""));
        }
    }
}
