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
		int IdSynchro = 0;
		UsersManagement FUsersManagement;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_IdSynchro"></param>
		/// <param name="_FUsersManagement">Récupère l'instance de la fenêtre 'gestion utilisateur' pour mettre à jour la dataGridView</param>
		public AddUser(int _IdSynchro, Gestinv.UsersManagement _FUsersManagement)
		{
			InitializeComponent();
			IdSynchro = _IdSynchro;
			FUsersManagement = _FUsersManagement;
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
			if (txtBox_Password_1.Text == txtBox_Password_2.Text)
			{
				//txtBox_Name , txtBox_Password , cb_admin , btn_Add
				string uLogin = txtBox_Name.Text;
				string uPassw = txtBox_Password_1.Text;
				bool uAdmin = cb_admin.Checked;
				ServiceSynchro.User newUser = new ServiceSynchro.User();
				newUser.Login = uLogin;
				newUser.Password = md5.CalculateMD5Hash(uPassw).ToLower();
				newUser.Admin = uAdmin;
				newUser.State = true;
				newUser.Id = -1;
				ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
				if (ssc.SetUser(-1, newUser, IdSynchro) == 1)
				{
					MessageBox.Show("L'utilisateur a bien été ajouté");
					FUsersManagement.dtgv_usersList.DataSource = ssc.GetUsers(true);
				}
				else
					MessageBox.Show("Une erreur est survenue");
				this.Close();
			}
			else
				MessageBox.Show("Les deux mdp ne correspondent pas");
			txtBox_Password_1.Text = txtBox_Password_2.Text = txtBox_Name.Text = string.Empty;
			cb_admin.Checked = false;
		}
	}
}
