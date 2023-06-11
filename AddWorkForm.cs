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
    public partial class AddWorkForm : Form
    {
        private static DataBaseManager dataBaseManager = DataBaseManager.Instance;
        public AddWorkForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("새로운 운동을 등록하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataBaseManager.InsertNewWorkType(txtWork.Text))
                {
                    MessageBox.Show("Insert Success");
                    txtWork.Text = "";
                }
                else MessageBox.Show("Insert Failed");
            }
        }
    }
}
