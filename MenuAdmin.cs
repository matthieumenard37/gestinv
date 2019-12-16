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
	public partial class MenuAdmin : Form
	{
		public MenuAdmin()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btn_gerer_utilsateurs_Click(object sender, EventArgs e)
		{
			UsersManagement fUsersManagement = new UsersManagement();
			fUsersManagement.Show();
		}

		private void btn_voir_stocks_Click(object sender, EventArgs e)
		{
			Stock_admin fStockUserAdmin = new Stock_admin();
			fStockUserAdmin.Show();
		}

		private void btn_consulter_journal_log_Click(object sender, EventArgs e)
		{
			LogsView fLogsView = new LogsView();
			fLogsView.Show();
		}
	}
}
