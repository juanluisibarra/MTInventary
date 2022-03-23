using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace MTInventary
{
    public partial class NuevoProveedor : FormPadre
    {
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home objinicio = new Home();
            this.Hide();
           
            objinicio.Show();
        }
    }
}
