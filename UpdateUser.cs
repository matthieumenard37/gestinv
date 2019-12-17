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
			ServiceSynchro.User[] Allusers = ssc.GetUsers(true);
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
	}
}
