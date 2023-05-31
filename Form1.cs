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

            cbbKind.SelectedItem = "��Ʈ��Ī";
        }

        private void cbbKind_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbKind.SelectedItem.ToString() == "�ʶ��׽�" || cbbKind.SelectedItem.ToString() == "�䰡"
              || cbbKind.SelectedItem.ToString() == "��Ʈ��Ī") label1.Text = "�ð� : ";
            else label1.Text = "Ƚ�� : ";

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
                if (healthInfos[i].WorkType == "�ʶ��׽�" || healthInfos[i].WorkType == "�䰡" || healthInfos[i].WorkType == "��Ʈ��Ī")
                    items.SubItems.Add(healthInfos[i].Count.ToString() + "��");
                else items.SubItems.Add(healthInfos[i].Count.ToString() + "��");
                items.SubItems.Add(healthInfos[i].WorkDateTime);

                lv_dataList.Items.Add(items);
            }

            lv_dataList.EndUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WorkOutInfo workData = new WorkOutInfo();
            workData.WorkType = lv_dataList.SelectedItems[0].SubItems[0].Text;
            
            if (workData.WorkType == "�ʶ��׽�" || workData.WorkType == "�䰡" || workData.WorkType == "��Ʈ��Ī")
                workData.Count = int.Parse(lv_dataList.SelectedItems[0].SubItems[1].Text.Replace("��", ""));
            else workData.Count = int.Parse(lv_dataList.SelectedItems[0].SubItems[1].Text.Replace("��", ""));
            
            workData.WorkDateTime = lv_dataList.SelectedItems[0].SubItems[2].Text;

            if (dataBaseManager.DeleteWorkData(workData)) MessageBox.Show("Delete Success");
            else MessageBox.Show("Delete Failed");

            SelectWorkOutData();
        }
    }
}