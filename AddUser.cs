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
	public partial class AddUser : Form
	{
		public AddUser()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btn_AddUser_Click(object sender, EventArgs e)
		{
			//txtBox_Name , txtBox_Password , cb_admin , btn_Add
			string uLogin = txtBox_Name.Text;
			string uPassw = txtBox_Password.Text;
			bool uAdmin = cb_admin.Checked;
			ServiceSynchro.User newUser = new ServiceSynchro.User();
			newUser.Login = uLogin;
			newUser.Password = uPassw;
			newUser.Admin = uAdmin;
			newUser.State = true;
			newUser.Id = -1;
			Gestinv.Classes.User.AddUser(newUser);
		}
	}
}
