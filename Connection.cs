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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.User[] Allusers = ssc.GetUsers(false);

            string inputLogin = login.Text;
            //SOURCE
            string inputPassword = password.Text;
            password.Text = "";
            //HASH
            string inputPasswordMd5 = md5.CalculateMD5Hash(inputPassword).ToLower();
            bool authen_state = false;
            var AllusersLength = Allusers.GetLength(0);
            for (int iRow = 0; iRow < AllusersLength; iRow++ )
            {
                if ((Allusers[iRow].Login == inputLogin) && ((Allusers[iRow].Password == inputPasswordMd5)))
                {
                    if (Allusers[iRow].Admin)
                    {
                        authen_state = true;
                        MenuAdmin fMenuAdmin = new MenuAdmin(Allusers[iRow].Id, ssc.CreateSynchro(Allusers[iRow].Id));
                        fMenuAdmin.Show();
                    }
                    else
                    {
                        authen_state = true;
                        Stock_user fStockUser = new Stock_user(Allusers[iRow].Id);
                        fStockUser.Show();
                    }
                }
            }
            if (!authen_state)
            {
                MessageBox.Show("L'authentification a échouée !");
            }
        }

        private void lbl_espaceConnexion_Click(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

	}
}
