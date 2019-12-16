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
            ServiceSynchro.User[] Allusers = Synchro.Users(true);

            string[,] usersTable = {
                { "1coucou", "1", "0", "totototo", "toto" },
                { "2dede", "0", "1", "cacacaca", "caca" },
                { "3dstst", "1", "1", "root", "toor" },
                { "4gfdg", "0", "0", "pipipipi", "pipi" }
                };

            string inputLogin = login.Text;

            string inputPassword = password.Text;
            bool authen_state = false;
            var AllusersLength = Allusers.GetLength(0);
            for (int iRow = 0; iRow < AllusersLength-1; iRow++ )
            {
                if ((Allusers[iRow].Login.ToString() == inputLogin) && ((Allusers[iRow].Password.ToString() == inputPassword)))
                {
                    if (Allusers[iRow].Admin)
                    {
                        authen_state = true;
                        MenuAdmin fMenuAdmin = new MenuAdmin();
                        fMenuAdmin.Show();
                    }
                    else
                    {
                        authen_state = true;
                        Stock_user fStockUser = new Stock_user();
                        fStockUser.Show();
                    }
                }
            }
            if (!authen_state)
            {
                MessageBox.Show("L'authentification a échouée connard !");
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

		private void button1_Click_1(object sender, EventArgs e)
		{
			UsersManagement fum = new UsersManagement();
			fum.ShowDialog();
		}
	}
}
