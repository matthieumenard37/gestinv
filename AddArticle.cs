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
    public partial class AddArticle : Form
    {
        ServiceSynchro.Article _a = new ServiceSynchro.Article();
        ServiceSynchro.User CurrentUser = null;
        int IdSynchro;
        Stock_admin FStockAdmin = null;
        public AddArticle(int idCurrentUser, int _IdSynchro, Stock_admin _FStockAdmin)
        {
            InitializeComponent();
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.User[] Allusers = ssc.GetUsers(false);
            ServiceSynchro.Family[] Families = ssc.GetFamilies(true);
            foreach (ServiceSynchro.User user in Allusers)
            {
                if (user.Id == idCurrentUser)
                {
                    CurrentUser = user;
                }
            }
            IdSynchro = _IdSynchro;
            FStockAdmin = _FStockAdmin;

            //chargement des familles dans la combo
            foreach (ServiceSynchro.Family family in Families)
            {
                comboBox_family_name.Items.Add(family);
            }
            comboBox_family_name.DisplayMember = "name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_article_Click(object sender, EventArgs e)
        {
            _a.Name = txtBox_article_name.Text;
            _a.State = true;
            _a.FamilyId = ((ServiceSynchro.Family)comboBox_family_name.SelectedItem).Id;
            _a.Quantity = (int)nud_quantity.Value;
            _a.LocationCode = maskedTextB_location_code.Text;

            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            if (ssc.SetArticle(-1, _a, IdSynchro) == 1)
            {
                MessageBox.Show("L'article a bien été créé");

                foreach (ServiceSynchro.Family family in FStockAdmin.combobox_families.Items)
                {
                    if (_a.FamilyId == family.Id)
                        {
                            FStockAdmin.combobox_families.SelectedItem = family;
                        }
                }

                FStockAdmin.dtgv_articles.DataSource = ssc.GetArticles(_a.FamilyId, true);
            }

            txtBox_article_name.Text = string.Empty;
            comboBox_family_name.Text = "";
            nud_quantity.Value = 0;
            maskedTextB_location_code.Text = string.Empty;
        }
    }
}
