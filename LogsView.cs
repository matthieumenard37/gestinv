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
    public partial class LogsView : Form
    {
        public LogsView()
        {
            InitializeComponent();
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.Synchronization[] synchros = ssc.GetSynchronizations(20);
            int n = 0;
            foreach(ServiceSynchro.Synchronization synchro in synchros)
            {
                treeView1.Nodes.Add(synchro.Date.ToString() + " (" + synchro.UserLogin + ")");
                foreach(ServiceSynchro.Modification modif in synchro.Modifications)
                {
                    string chainedesc = "";
                    string detail = "";


                    if (modif.Family != null)
                    {
                        chainedesc = "Family's ID: " + modif.Family.Id.ToString();
                        if (modif.OldValue != "0" && modif.NewValue != "0")
                        {
                            if (modif.OldValue != modif.NewValue)
                            {
                                detail = "Modification : " + modif.OldValue + " --> " + modif.NewValue;
                                if (modif.Family.Name != modif.NewValue)
                                {
                                    detail = detail + "     (Nom actuel de la famille concernée : " + modif.Family.Name + ")";
                                }
                            } else
                            {
                                detail = "Modification sur : " + modif.Family.Name;
                            }
                        }
                        if (modif.OldValue == "0" && modif.NewValue != "0") { detail = "Ajout : " + modif.NewValue; }
                        if (modif.OldValue == "0" && modif.NewValue == "0") { detail = "Suppresion de : " + modif.Family.Name; }
                    }
                    if (modif.User != null)
                    {
                        chainedesc = "User's ID: " + modif.User.Id.ToString();
                        if (modif.OldValue != "0" && modif.NewValue != "0")
                        {
                            if (modif.OldValue != modif.NewValue)
                            {
                                detail = "Modification : " + modif.OldValue + " --> " + modif.NewValue;
                                if (modif.User.Login != modif.NewValue)
                                {
                                    detail = detail + "     (Login actuel de l'utilisateur concerné : " + modif.User.Login + ")";
                                }
                            }
                            else
                            {
                                detail = "Modification sur : " + modif.User.Login;
                            }
                        }
                        if (modif.OldValue == "0" && modif.NewValue != "0") { detail = "Ajout : " + modif.NewValue; }
                        if (modif.OldValue == "0" && modif.NewValue == "0") { detail = "Suppresion de : " + modif.User.Login; }
                    }
                    if (modif.Article != null)
                    {
                        chainedesc = "Article's ID: " + modif.Article.Id.ToString();
                        if (modif.OldValue != "0" && modif.NewValue != "0")
                        {
                            if (modif.OldValue != modif.NewValue)
                            {
                                detail = "Modification : " + modif.OldValue + " --> " + modif.NewValue;
                                if (modif.Article.Name != modif.NewValue)
                                {
                                    detail = detail + "     (Nom actuel de l'article concerné : " + modif.Article.Name + ")";
                                }
                            }
                            else
                            {
                                detail = "Modification sur : " + modif.Article.Name;
                            }
                        }
                        if (modif.OldValue == "0" && modif.NewValue != "0") { detail = "Ajout : " + modif.NewValue; }
                        if (modif.OldValue == "0" && modif.NewValue == "0") { detail = "Suppresion de : " + modif.Article.Name; }
                    }
                   treeView1.Nodes[n].Nodes.Add(modif.ModificationType + "     " + chainedesc + "     " + detail);
                }
                n = n + 1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
