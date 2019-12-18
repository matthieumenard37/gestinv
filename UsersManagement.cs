using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestinv.Classes;

namespace Gestinv
{
    public partial class UsersManagement : Form
    {
		ServiceSynchro.User CurrentUser = new ServiceSynchro.User();
		public UsersManagement(int IdCurrentUser)
        {
            InitializeComponent();
			ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
			dtgv_usersList.DataSource = ssc.GetUsers(true);
			ServiceSynchro.User[] allUser = ssc.GetUsers(false);
			foreach (ServiceSynchro.User user in allUser)
			{
				if (user.Id == IdCurrentUser)
				{
					CurrentUser = user;
				}
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void UsersManagement_Load(object sender, EventArgs e)
		{
		}

		private void btn_addUser_Click(object sender, EventArgs e)
		{
			AddUser adduser = new AddUser();
			adduser.Show();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void dtgv_usersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_updateUser_Click(object sender, EventArgs e)
		{

		}

		private void dtgv_usersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				UpdateUser FUpdateUser = new UpdateUser((int)dtgv_usersList["Id", e.RowIndex].Value, CurrentUser.Id);
				FUpdateUser.Show();
			}
		}

		private void btn_deleteUser_Click(object sender, EventArgs e)
		{

		}
	}
}
