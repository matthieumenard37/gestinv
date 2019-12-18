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
		//(public) ServiceSynchro.ServiceSynchroClient sscPublic = new ServiceSynchro.ServiceSynchroClient();
		ServiceSynchro.User _u = null;
		ServiceSynchro.User CurrentUser = null;
		int IdSynchro = 0;
		public UpdateUser(int idUser, int idCurrentUser, int _IdSynchro)
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
			IdSynchro = _IdSynchro;

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
			//Désactive le bouton supprimer user si il concerne l'utilisateur connecté
			if (_u.Id == CurrentUser.Id)
			{
				btn_delete.Enabled = false;
			}
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
			if (_u.Id == CurrentUser.Id)
			{
				_u.Admin = true;
				MessageBox.Show("AVERTISSEMENT: Vous ne pouvez pas rétrograder vos droits utilisateurs.");
			}else
				_u.Admin = cb_admin.Checked;

			ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
			//creer la synchro
			if (ssc.SetUser(_u.Id, _u, IdSynchro) == 1)
			{
				MessageBox.Show("L'utilisateur " + _u.Login + " a été mis à jour avec succès.");
			}
			else
				MessageBox.Show("Une erreur est survenue.");
			this.Close();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if (_u.Id == CurrentUser.Id)
			{
				MessageBox.Show("AVERTISSEMENT: Vous ne pouvez pas supprimer votre compte.");
			}
			else
			{
				DialogResult dialogR = MessageBox.Show("Êtes-vous sûr de vouloir supprimer " + _u.Login + " ?", "Supprimer Utilisateur", MessageBoxButtons.YesNo);
				if (dialogR == DialogResult.Yes)
				{
					ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
					if (ssc.DelUser(_u.Id, IdSynchro) == 1)
					{
						MessageBox.Show("L'utilisateur a bien été supprimé");
						this.Close();
					}
					else
					{
						MessageBox.Show("Une erreur est survenue");
						this.Close();
					}
				}
				//else ? if (dialogR == DialogResult.Yes){}
			}
		}
	}
}
