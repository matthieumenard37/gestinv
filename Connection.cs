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

        public void button1_Click(object sender, EventArgs e)
        {
            //MenuAdmin fMenuAdmin = new MenuAdmin();
            //fMenuAdmin.Show();
            //this.Visible = false;
            //Stock_user fStockUser= new Stock_user();
            //fStockUser.Show();
            MenuAdmin form2 = new MenuAdmin();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void lbl_espaceConnexion_Click(object sender, EventArgs e)
        {

        }
    }
}
