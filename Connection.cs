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
            string[,] usersTable = {
                { "1coucou", "1", "0", "totototo", "toto" },
                { "2dede", "0", "1", "cacacaca", "caca" },
                { "3dstst", "1", "1", "root", "toor" },
                { "4gfdg", "0", "0", "pipipipi", "pipi" }
                };

            string inputLogin = login.Text;

            string inputPassword = password.Text;
            bool authen_state = false;

            for (int iRow = 0; iRow < usersTable.GetLength(1)-1; iRow++ )
            {
                if ((usersTable[iRow,4].ToString() == inputLogin) && ((usersTable[iRow, 3].ToString() == inputPassword)))
                {
                    if (usersTable[iRow, 2].ToString() == "1")
                    {
                        authen_state = true;
                        MenuAdmin fMenuAdmin = new MenuAdmin();
                        fMenuAdmin.Show();
                    }
                    else if (usersTable[iRow, 2].ToString() == "0")
                    {
                        authen_state = true;
                        Stock_user fStockUser = new Stock_user();
                        fStockUser.Show();
                    }
                    else MessageBox.Show("Une erreur est survenue lors de l'authentification CODE ERREUR 2");
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
