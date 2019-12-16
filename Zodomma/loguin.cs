using Controlador.Logueo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zodomma
{
    public partial class loguin : Form
    {
        logueo acceder = null;
        loguinLogica loguinlogica = null;
        public loguin()
        {
            InitializeComponent();
        }

        private void loguin_Load(object sender, EventArgs e)
        {

        }

        private void txtusu_Enter(object sender, EventArgs e)
        {
            if (txtusu.Text == "USUARIO") {
                txtusu.Text = "";
                txtusu.ForeColor = Color.LightGray;
            }
        }

        private void txtusu_Leave(object sender, EventArgs e)
        {
            if (txtusu.Text=="") {
                txtusu.Text = "USUARIO";
                txtusu.ForeColor = Color.DimGray;
            }
        }

        private void txtcontra_Enter(object sender, EventArgs e)
        {
            if (txtcontra.Text == "CONTRASEÑA")
            {
                txtcontra.Text = "";
                txtcontra.ForeColor = Color.LightGray;
                txtcontra.UseSystemPasswordChar = true;

            }
        }

        private void txtcontra_Leave(object sender, EventArgs e)
        {
            if (txtcontra.Text == "")
            {
                txtcontra.Text = "CONTRASEÑA";
                txtcontra.ForeColor = Color.DimGray;
                txtcontra.UseSystemPasswordChar = false;
            }
        }

        private void btnloguin_Click(object sender, EventArgs e)
        {
            acceder = new logueo();
            acceder.SetUsuario(txtusu.Text);
            acceder.setPassword(txtcontra.Text);

            loguinlogica = new loguinLogica(acceder);
            loguinlogica.ValidarUsuario();

        }
    }
}
