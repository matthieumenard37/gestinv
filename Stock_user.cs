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
    public partial class Stock_user : Form
    {
        public Stock_user()
        {
            InitializeComponent();
            ServiceSynchro.CompositeType ct = new ServiceSynchro.CompositeType();
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ct.BoolValue = true;
            ct.StringValue = "Essai de string";

            ServiceSynchro.CompositeType resultat = ssc.GetDataUsingDataContract(ct);
            MessageBox.Show(resultat.StringValue);
        }
    }
}
