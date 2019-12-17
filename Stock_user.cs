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
    public partial class Stock_user : Form
    {
        bool nonNumber = true;
        //definition des variables globales qui vont contenir la bdd
        ServiceSynchro.Family[] Families = new ServiceSynchro.Family[] { }; //uniquement pour la correspondance nom-id des familles
        ServiceSynchro.Article[] Articles = new ServiceSynchro.Article[] { }; //tous les articles (actifs)
        public Stock_user()
        {
            //téléchargement des données de la bdd au lancement
            Families = Synchro.DownloadFamilies();
            Articles = Synchro.DownloadArticles();

            InitializeComponent();

            //chargement des familles dans la combo
            foreach (ServiceSynchro.Family family in Families)
            {
                input_family.Items.Add(family);
            }
            input_family.DisplayMember = "name";
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void input_family_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceSynchro.Family family = (ServiceSynchro.Family)input_family.SelectedItem;
            //chargement des articles de la familles dans la combo
            input_article.Items.Clear();
            foreach (ServiceSynchro.Article article in Articles)
            {
                if (article.FamilyId == family.Id)
                {
                    input_article.Items.Add(article);
                }
            }
            input_article.DisplayMember = "name";

            //vider l'article visible
            input_article.Text = "";
            //vider la quantité car pas d'article sélectionné
            input_quantity.Text = "";
        }

        private void input_article_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceSynchro.Article article = (ServiceSynchro.Article)input_article.SelectedItem;
            //chargement de la quantité actuelle dans le champs de saisie
            input_quantity.Text = article.Quantity.ToString();
        }

        private void input_quantity_TextChanged(object sender, EventArgs e)
        {
            if (input_article.SelectedItem == null)
            {
                input_quantity.Text = "";
                return;
            }
            int quantity = int.Parse("0" + input_quantity.Text.Replace(" ",string.Empty));
            ServiceSynchro.Article articleencours = (ServiceSynchro.Article)input_article.SelectedItem;

            //met à jour la quantité dans la bdd embarquée (variable)
            foreach (ServiceSynchro.Article article in Articles)
            {
                if (article.Id == articleencours.Id)
                {
                    article.Quantity = quantity;
                }
            }
        }

        private void input_quantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_synchro_Click(object sender, EventArgs e)
        {
            Synchro.Upload(Articles);
            this.Close();
        }
    }
}
