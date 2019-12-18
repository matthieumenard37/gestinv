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
    public partial class UpdateArticle : Form
    {
        ServiceSynchro.Article _a = null;
        ServiceSynchro.User CurrentUser = null;
        int IdSynchro = 0;
        public UpdateArticle(int idArticle, int idCurrentUser, int _IdSynchro, int idFamily)
        {
            InitializeComponent();
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.User[] Allusers = ssc.GetUsers(false);
            ServiceSynchro.Article[] Allarticles = ssc.GetArticles(idFamily, false);
            foreach (ServiceSynchro.Article article in Allarticles)
            {
                if (article.Id == idArticle)
                {
                    _a = article;
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
            lbl_titre.Text += " " + _a.Name;
            txtb_name.Text = _a.Name;
            txtb_location.Text = _a.LocationCode;
            nud_quantity.Value = _a.Quantity;


            ServiceSynchro.Family[] Families = ssc.GetFamilies(true);

            //chargement des familles dans la combo
            int n = 0;
            int indexToSelect = 0;
            foreach (ServiceSynchro.Family family in Families)
            {
                comboBox_family.Items.Add(family);
                if (family.Id == idFamily)
                {
                    indexToSelect = n;
                }
                n = n + 1;
            }
            comboBox_family.DisplayMember = "name";

            comboBox_family.SelectedItem = comboBox_family.Items[indexToSelect];
            
        }

        private void UpdateArticle_Load(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            _a.Name = txtb_name.Text;
            _a.LocationCode = txtb_location.Text;
            _a.FamilyId = ((ServiceSynchro.Family)comboBox_family.SelectedItem).Id;
            _a.Quantity = (int)nud_quantity.Value;
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            //creer la synchro
            if (ssc.SetArticle(_a.Id, _a, IdSynchro) == 1)
            {
                MessageBox.Show("L'article " + _a.Name + " a été mis à jour avec succès.");
            }
            else
                MessageBox.Show("Une erreur est survenue.");
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogR = MessageBox.Show("Êtes-vous sûr de vouloir supprimer " + _a.Name + " ?", "Supprimer Article", MessageBoxButtons.YesNo);
            if (dialogR == DialogResult.Yes)
            {
                ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
                if (ssc.DelArticle(_a.Id, IdSynchro) == 1)
                {
                    MessageBox.Show("L'article a bien été supprimé");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue");
                    this.Close();
                }
            }
        }
    }
}
