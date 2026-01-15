using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aldeia.Mercosul.Planilhas.App;

namespace Aldeia.Mercosul.Planilhas.UI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void correççãoToolStripMenuItem_Click(Object sender, EventArgs e)
        {

        }

        private void frmHome_Load(Object sender, EventArgs e)
        {
            GoogleConnect gooConn = new GoogleConnect();
            MessageBox.Show(gooConn.Connect());
        }
    }
}
