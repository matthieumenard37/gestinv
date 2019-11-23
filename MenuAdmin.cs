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

        private void btn_voir_stocks_Click(object sender, EventArgs e)
        {
            Stock_admin fStockAdmin = new Stock_admin();
            fStockAdmin.ShowDialog();
            this.Visible = false;
        }

        private void btn_gerer_utilsateurs_Click(object sender, EventArgs e)
        {
            UsersManagement fUsersManagement = new UsersManagement();
            fUsersManagement.ShowDialog();
        }

        private void btn_consulter_journal_log_Click(object sender, EventArgs e)
        {
            LogsView fLogs = new LogsView();
            fLogs.ShowDialog();
        }
        public void btn_menu_admin_deconnect_Click(object sender, EventArgs e)
        {
            //Connection.ActiveForm.Visible = true;
            //Close();
            var form1 = (Connection)Tag;
            form1.Show();
            Close();
        }
    }
}
