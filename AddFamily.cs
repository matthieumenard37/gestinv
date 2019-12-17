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
    public partial class AddFamily : Form
    {
        ServiceSynchro.Family _f = new ServiceSynchro.Family();
        ServiceSynchro.User CurrentUser = null;
        public AddFamily(int idCurrentUser)
        {
            InitializeComponent();
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.User[] Allusers = ssc.GetUsers(false);
            foreach (ServiceSynchro.User user in Allusers)
            {
                if (user.Id == idCurrentUser)
                {
                    CurrentUser = user;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_family_Click(object sender, EventArgs e)
        {
            _f.Name = txtBox_family_name.Text;
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            int SynchroId = ssc.CreateSynchro(CurrentUser.Id);
            ssc.SetFamily(-1, _f, SynchroId);
        }
    }
}
