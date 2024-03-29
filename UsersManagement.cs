﻿using System;
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
		int IdSynchro = 0;
		public UsersManagement(int IdCurrentUser, int _IdSynchro)
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
			IdSynchro = _IdSynchro;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void UsersManagement_Load(object sender, EventArgs e)
		{
		}

		private void btn_addUser_Click(object sender, EventArgs e)
		{
			AddUser adduser = new AddUser(IdSynchro,this);
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
				UpdateUser FUpdateUser = new UpdateUser((int)dtgv_usersList["Id", e.RowIndex].Value, CurrentUser.Id, IdSynchro, this);
				FUpdateUser.Show();
			}
		}

		private void btn_deleteUser_Click(object sender, EventArgs e)
		{

		}
    }
}
