﻿using System;
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
    public partial class SummaryForm : Form
    {
        private static DataBaseManager dataBaseManager = DataBaseManager.Instance;
        public SummaryForm(string dateTime)
        {
            InitializeComponent();

            this.lblDateTime.Text = String.Format("{0}년 {1}월 {2}일", 
                dateTime.Substring(0, 4), dateTime.Substring(5, 2), dateTime.Substring(8, 2));

            SelectSummaryWorkOutData(dateTime);
        }

        private void SelectSummaryWorkOutData(string dateTime)
        {
            lv_dataList.Items.Clear();

            lv_dataList.BeginUpdate();

            lv_dataList.View = View.Details;

            List<WorkOutInfo> healthInfos = dataBaseManager.SelectHealthInfo(dateTime);
            for (int i = 0; i < healthInfos.Count; i++)
            {
                ListViewItem items = new ListViewItem(healthInfos[i].WorkType);
                if (healthInfos[i].WorkType == "필라테스" || healthInfos[i].WorkType == "요가" || healthInfos[i].WorkType == "스트레칭")
                    items.SubItems.Add(healthInfos[i].Count.ToString() + "분");
                else items.SubItems.Add(healthInfos[i].Count.ToString() + "개");
                items.SubItems.Add(healthInfos[i].WorkDateTime);

                lv_dataList.Items.Add(items);
            }

            lv_dataList.EndUpdate();
        }
    }
}
