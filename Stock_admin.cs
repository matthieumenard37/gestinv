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
    public partial class Stock_admin : Form
    {
        ServiceSynchro.User CurrentUser = new ServiceSynchro.User();
        int IdSynchro;
        public Stock_admin(int idCurrentUser, int _IdSynchro)
        {
            InitializeComponent();
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.User[] allUser = ssc.GetUsers(false);
            foreach (ServiceSynchro.User user in allUser)
            {
                if (user.Id == idCurrentUser)
                {
                    CurrentUser = user;
                }
            }
            IdSynchro = _IdSynchro;
            ServiceSynchro.Family[] Families = ssc.GetFamilies(true);

            //chargement des familles dans la combo
            foreach (ServiceSynchro.Family family in Families)
            {
                combobox_families.Items.Add(family);
            }
            combobox_families.DisplayMember = "name";
        }

        private void add_family_Click(object sender, EventArgs e)
        {
        }

        private void add_family_Click_1(object sender, EventArgs e)
        {
            AddFamily addfamily = new AddFamily(CurrentUser.Id, IdSynchro);
            addfamily.Show();
        }

        private void combobox_families_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceSynchro.Family selectedFamily = (ServiceSynchro.Family)combobox_families.SelectedItem; 
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.Article[] articles = ssc.GetArticles(selectedFamily.Id, true);
            dtgv_articles.DataSource = articles;
            dtgv_articles.Columns[0].Visible = false;
            dtgv_articles.Columns[1].Visible = false;
            dtgv_articles.Columns[5].Visible = false;
            // WARNING les index partent de la dernière de la colonne de la BDD !
        }

        private void modify_family_Click(object sender, EventArgs e)
        {
            if (combobox_families.SelectedItem != null)
            {
                UpdateFamily FUpdateFamily = new UpdateFamily(((ServiceSynchro.Family)combobox_families.SelectedItem).Id, CurrentUser.Id, IdSynchro);
                FUpdateFamily.Show();
            }
        }

        private void dtgv_articles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                UpdateArticle FUpdateArticle = new UpdateArticle((int)dtgv_articles["Id", e.RowIndex].Value, CurrentUser.Id, IdSynchro, (int)dtgv_articles[0, e.RowIndex].Value);
                FUpdateArticle.Show();
            }
        }
    }
}
