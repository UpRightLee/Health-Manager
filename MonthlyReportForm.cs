using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthNote
{
    public partial class MonthlyReportForm : Form
    {
        private static DataBaseManager dataBaseManager = DataBaseManager.Instance;
        public MonthlyReportForm()
        {
            InitializeComponent();
        }

        private void MonthlyReportForm_Load(object sender, EventArgs e)
        {
            SelectMonthlyData();
        }

        private void SelectMonthlyData()
        {
            lv_dataList.Items.Clear();

            lv_dataList.BeginUpdate();

            lv_dataList.View = View.Details;

            List<WorkOutInfo> healthInfos = dataBaseManager.SelectMonthlyReportInfo();
            for (int i = 0; i < healthInfos.Count; i++)
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

            lv_dataList.EndUpdate();
        }

        private void MonthlyReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
