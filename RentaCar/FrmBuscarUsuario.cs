using RentaCar.RentaCarDataBaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class FrmBuscarUsuario : Form
    {
        public FrmBuscarUsuario()
        {
            InitializeComponent();
        }

        private void FrmBuscarUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
            txtNombre.Enabled = false;
            txtMaterno.Enabled = false;
            txtPaterno.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter ConsultaUsuarios = new usuariosTableAdapter();
            if (comboopcion.Text == "Usuarios")
            {
               dataUsuarios.DataSource = ConsultaUsuarios.BuscarUsuarioPorUsuario(txtUsuario.Text);
               dataUsuarios[7, 0].Value = "";
               txtUsuario.Enabled = false;
               txtNombre.Enabled = false;
               txtMaterno.Enabled = false;
               txtPaterno.Enabled = false;
               btnBuscar.Enabled = false;
               txtUsuario.Text = "";
               txtNombre.Text = "";
               txtMaterno.Text = "";
               txtPaterno.Text = "";
               comboopcion.Text = ""; 
            }
            else if (comboopcion.Text == "Nombre y Apellidos")
            {
                dataUsuarios.DataSource = ConsultaUsuarios.BuscarUsuarioNombre(txtNombre.Text, txtPaterno.Text, txtMaterno.Text);
                dataUsuarios[7, 0].Value = "";
                txtUsuario.Enabled = false;
                txtNombre.Enabled = false;
                txtMaterno.Enabled = false;
                txtPaterno.Enabled = false;
                btnBuscar.Enabled = false;
                txtUsuario.Text = "";
                txtNombre.Text = "";
                txtMaterno.Text = "";
                txtPaterno.Text = "";
                comboopcion.Text = "";
            }        

        }

        private void comboopcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboopcion.Text == "Usuarios")
            {
                txtUsuario.Enabled = false;
                txtNombre.Enabled = false;
                txtMaterno.Enabled = false;
                txtPaterno.Enabled = false;
                btnBuscar.Enabled = false;
                txtUsuario.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else if (comboopcion.Text == "Nombre y Apellidos")
            {
                txtUsuario.Enabled = false;
                txtNombre.Enabled = false;
                txtMaterno.Enabled = false;
                txtPaterno.Enabled = false;
                btnBuscar.Enabled = false;
                txtNombre.Enabled = true;
                txtMaterno.Enabled = true;
                txtPaterno.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else
            {
                txtUsuario.Enabled = false;
                txtNombre.Enabled = false;
                txtMaterno.Enabled = false;
                txtPaterno.Enabled = false;
                btnBuscar.Enabled = false;
            }
        }
    }
}
