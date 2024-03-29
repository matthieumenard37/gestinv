﻿using System;
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
	public partial class MenuAdmin : Form
	{
		ServiceSynchro.User CurrentUser = new ServiceSynchro.User();
		int IdSynchro = 0;
		public MenuAdmin(int IdCurrentUser, int _IdSynchro)
		{
			InitializeComponent();
			ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
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

		private void btn_gerer_utilsateurs_Click(object sender, EventArgs e)
		{
			UsersManagement fUsersManagement = new UsersManagement(CurrentUser.Id, IdSynchro);
			fUsersManagement.Show();
		}

		private void btn_voir_stocks_Click(object sender, EventArgs e)
		{
			Stock_admin fStockUserAdmin = new Stock_admin(CurrentUser.Id, IdSynchro);
			fStockUserAdmin.Show();
		}

		private void btn_consulter_journal_log_Click(object sender, EventArgs e)
		{
			LogsView fLogsView = new LogsView();
			fLogsView.Show();
		}
	}
}
