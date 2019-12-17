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
	public partial class UpdateUser : Form
	{
		ServiceSynchro.User _u = null;
		public UpdateUser(int idUser)
		{
			InitializeComponent(); 
			ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
			ServiceSynchro.User[] Allusers = ssc.GetUsers(false);
			foreach (ServiceSynchro.User user in Allusers)
			{
				if (user.Id == idUser)
				{
					_u = user;
				}
			}


			lbl_titre.Text += " " + _u.Login;

		}

		private void lbl_titre_Click(object sender, EventArgs e)
		{

		}

		private void tv_Login_Click(object sender, EventArgs e)
		{

		}

		private void UpdateUser_Load(object sender, EventArgs e)
		{
			// txtb_Login txtb_password1 txtb_password2 cb_admin cb_actif btn_Submit
			txtb_Login.Text = _u.Login;
			cb_admin.Checked = _u.Admin;
			cb_admin.Checked = _u.State;
		}
	}
}
