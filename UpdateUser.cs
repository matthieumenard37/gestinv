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
		ServiceSynchro.User CurrentUser = null;
		public UpdateUser(int idUser, int idCurrentUser)
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
				if (user.Id == idCurrentUser)
				{
					CurrentUser = user;
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
		}

		private void btn_Submit_Click(object sender, EventArgs e)
		{
			_u.Login = txtb_Login.Text;
			if (txtb_password1.Text != "" && (txtb_password1.Text == txtb_password2.Text))
			{
				//Hasher la string md5.CalculateMD5Hash(uPassw).ToLower();
				_u.Password = md5.CalculateMD5Hash(txtb_password1.Text).ToLower();
			}
			else if (txtb_password1.Text != txtb_password2.Text)
			{
				MessageBox.Show("Veuillez renseigner deux mdp identiques");
			}else
				MessageBox.Show("Le mot de passe n'a pas été modifié");
			_u.Admin = cb_admin.Checked;

			ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();

			//creer la synchro
			int SynchroId = ssc.CreateSynchro(CurrentUser.Id);
			if (ssc.SetUser(_u.Id, _u, SynchroId) == 1)
			{
				MessageBox.Show("L'utilisateur " + _u.Login + " a été mis à jour avec succès.");
			}
			else
				MessageBox.Show("Une erreur est survenue.");
			this.Close();
		}
	}
}
