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
		
		public UsersManagement()
        {
            InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void UsersManagement_Load(object sender, EventArgs e)
		{
			//Remplir la dtgv
			//dtgv_usersList.DataSource = activUsers;
			//BUG dtgv_usersList.Sort(dtgv_usersList.Columns[4], ListSortDirection.Descending);
			//dtgv_usersList.Refresh();
		}

		private void btn_addUser_Click(object sender, EventArgs e)
		{
			//
		}

		private void cb_filter_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_filter.Checked)
			{
				dtgv_usersList.DataSource = Synchro.Users(true);
			}
			else
				dtgv_usersList.DataSource = Synchro.Users(false);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void dtgv_usersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
