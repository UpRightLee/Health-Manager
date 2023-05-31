namespace HealthNote
{
    public partial class Form1 : Form
    {
        private static DataBaseManager dataBaseManager = DataBaseManager.Instance;
        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SelectWorkOutData();

            List<string> workTypes = dataBaseManager.SelectWorkTypes();

            for (int i = 0; i < workTypes.Count; i++)
            {
                cbbKind.Items.Add(workTypes[i]);
            }

            cbbKind.SelectedItem = "스트레칭";
        }

        private void cbbKind_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbKind.SelectedItem.ToString() == "필라테스" || cbbKind.SelectedItem.ToString() == "요가"
              || cbbKind.SelectedItem.ToString() == "스트레칭") label1.Text = "시간 : ";
            else label1.Text = "횟수 : ";

            lblSetCount.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
        }

        private void SelectWorkOutData()
        {
            lv_dataList.Items.Clear();

            lv_dataList.BeginUpdate();

            lv_dataList.View = View.Details;

            List<WorkOutInfo> healthInfos = dataBaseManager.SelectHealthInfo();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WorkOutInfo workData = new WorkOutInfo();
            workData.WorkType = lv_dataList.SelectedItems[0].SubItems[0].Text;
            
            if (workData.WorkType == "필라테스" || workData.WorkType == "요가" || workData.WorkType == "스트레칭")
                workData.Count = int.Parse(lv_dataList.SelectedItems[0].SubItems[1].Text.Replace("분", ""));
            else workData.Count = int.Parse(lv_dataList.SelectedItems[0].SubItems[1].Text.Replace("개", ""));
            
            workData.WorkDateTime = lv_dataList.SelectedItems[0].SubItems[2].Text;

            if (dataBaseManager.DeleteWorkData(workData)) MessageBox.Show("Delete Success");
            else MessageBox.Show("Delete Failed");

            SelectWorkOutData();
        }
    }
}