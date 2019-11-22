using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestinv
{
    public partial class UsersManagement : Form
    {
		ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
		public UsersManagement()
        {
            InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void UsersManagement_Load(object sender, EventArgs e)
		{

			var activUsers = ssc.GetUsers(true);
			dtgv_usersList.DataSource = activUsers;
			dtgv_usersList.Refresh();
			//string test = ssc.Test();
			//MessageBox.Show(test);
		}

		private void btn_addUser_Click(object sender, EventArgs e)
		{
			//
		}

		private void cb_filter_CheckedChanged(object sender, EventArgs e)
		{
			var allUsers = ssc.GetUsers(false);
			if (cb_filter.Checked)
			{
				dtgv_usersList.DataSource = allUsers;
			}
			else
				dtgv_usersList.DataSource = ssc.GetUsers(true);
		}
	}
}
