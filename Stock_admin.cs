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
        public Stock_admin(int idCurrentUser)
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
        }

        private void add_family_Click(object sender, EventArgs e)
        {
            AddFamily addfamily = new AddFamily(CurrentUser.Id);
        }
    }
}
