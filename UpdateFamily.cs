﻿using System;
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
        Stock_admin FStockAdmin;
        public UpdateFamily(int idFamily, int idCurrentUser, int _IdSynchro, Stock_admin _FStockAdmin)
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

            FStockAdmin = _FStockAdmin;

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
                FStockAdmin.combobox_families.Items.Clear();
                ServiceSynchro.Family[] AllFamilies = ssc.GetFamilies(true);
                foreach (ServiceSynchro.Family family in AllFamilies)
                {
                    FStockAdmin.combobox_families.Items.Add(family);
                }
                
                foreach (ServiceSynchro.Family family in FStockAdmin.combobox_families.Items)
                {
                    if (family.Id == _f.Id)
                    {
                        FStockAdmin.combobox_families.SelectedItem = family;
                    }
                }
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
                    FStockAdmin.combobox_families.Items.Clear();
                    ServiceSynchro.Family[] AllFamilies = ssc.GetFamilies(true);
                    foreach (ServiceSynchro.Family family in AllFamilies)
                    {
                        FStockAdmin.combobox_families.Items.Add(family);
                    }
                    FStockAdmin.dtgv_articles.DataSource = null;
                    FStockAdmin.combobox_families.Text = "";
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

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }
    }
}
