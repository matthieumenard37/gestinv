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
            ServiceSynchro.Synchronization[] synchros = ssc.GetSynchronizations(5);
            int n = 0;
            foreach(ServiceSynchro.Synchronization synchro in synchros)
            {
                treeView1.Nodes.Add(synchro.Date.ToString() + " (" + synchro.UserLogin + ")");
                foreach(ServiceSynchro.Modification modif in synchro.Modifications)
                {
                    string chainedesc = "";
                    if (modif.Family != null) { chainedesc = "Family's ID: " + modif.Family.Id.ToString(); }
                    if (modif.User != null) { chainedesc = "User's ID: " + modif.User.Id.ToString(); }
                    if (modif.Article != null) { chainedesc = "Article's ID: " + modif.Article.Id.ToString(); }
                    treeView1.Nodes[n].Nodes.Add(modif.ModificationType + "     " + chainedesc + "     " + modif.OldValue +" --> " + modif.NewValue);
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
