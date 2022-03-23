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
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; //color botones, color de margen,color de difumidado al poner el cursor 
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown800,Primary.Brown800,Primary.Brown400, Accent.LightBlue700,TextShade.WHITE);
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            NuevoProducto objproducto = new NuevoProducto();
            this.Hide();
            objproducto.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            NuevoProveedor objnuevoProveedor = new NuevoProveedor();
            this.Hide();
            objnuevoProveedor.Show();
        }
    }
}
