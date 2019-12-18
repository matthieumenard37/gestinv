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
    public partial class UpdateFamily : Form
    {
        ServiceSynchro.Family _f = null;
        ServiceSynchro.User CurrentUser = null;
        int IdSynchro = 0;
        public UpdateFamily(int idFamily, int idCurrentUser, int _IdSynchro)
        {
            InitializeComponent();

            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.User[] Allusers = ssc.GetUsers(false);
            ServiceSynchro.Family[] Allfamilies = ssc.GetFamilies(false);
            foreach (ServiceSynchro.Family family in Allfamilies)
            {
                if (family.Id == idFamily)
                {
                    _f = family;
                }
            }

            foreach (ServiceSynchro.User user in Allusers)
            {
                if (user.Id == idCurrentUser)
                {
                    CurrentUser = user;
                }
            }


            IdSynchro = _IdSynchro;

            lbl_titre.Text += " " + _f.Name;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            _f.Name = txtb_name.Text;

            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            //creer la synchro
            if (ssc.SetFamily(_f.Id, _f, IdSynchro) == 1)
            {
                MessageBox.Show("La famille " + _f.Name + " a été mise à jour avec succès.");
            }
            else
                MessageBox.Show("Une erreur est survenue.");
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogR = MessageBox.Show("Êtes-vous sûr de vouloir supprimer " + _f.Name + " ?", "Supprimer Famille", MessageBoxButtons.YesNo);
            if (dialogR == DialogResult.Yes)
            {
                ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
                if (ssc.DelFamily(_f.Id, IdSynchro) == 1)
                {
                    MessageBox.Show("La famille a bien été supprimée");
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
