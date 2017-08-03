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
    public partial class RentaCar : Form
    {
        
        public RentaCar()
        {
            InitializeComponent();
        }

        private void RentaCar_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter ConsultaUsuarios = new usuariosTableAdapter();
            Boolean shot = true;

            if (txtAgregarUsuarioContrasena.Text == txtAgregarUsuarioContrasenaV.Text && txtAgregarUsuarioUsuario.Text != "" && txtAgregarUsuarioNombre.Text != "" && txtAgregarUsuarioPaterno.Text != "" && txtAgregarUsuarioMaterno.Text != "" && txtAgregarUsuarionivel.Text != "" && txtAgregarUsuarioTelefono.Text != "" && txtAgregarUsuarioDireccion.Text != "" && txtAgregarUsuarioContrasena.Text != "" )
            {           
                foreach (DataRow row in ConsultaUsuarios.BuscarUsuarioLogin().Rows)
                {
                    if (row[0].ToString() == txtAgregarUsuarioUsuario.Text)
                    {
                        MessageBox.Show(row[0].ToString() + " ya existe");
                        shot = false;
                    }
                
                }

                if (shot == true)
                {
                    ConsultaUsuarios.Insert(txtAgregarUsuarioUsuario.Text,txtAgregarUsuarioNombre.Text,txtAgregarUsuarioPaterno.Text,txtAgregarUsuarioMaterno.Text,txtAgregarUsuarionivel.Text,txtAgregarUsuarioTelefono.Text,txtAgregarUsuarioDireccion.Text,txtAgregarUsuarioContrasena.Text);
                    MessageBox.Show(txtAgregarUsuarioUsuario.Text + "Agregado");
                    txtAgregarUsuarioUsuario.Text = "";
                    txtAgregarUsuarioNombre.Text = "";
                    txtAgregarUsuarioPaterno.Text = "";
                    txtAgregarUsuarioMaterno.Text = "";
                    txtAgregarUsuarionivel.Text = "";
                    txtAgregarUsuarioTelefono.Text = "";
                    txtAgregarUsuarioDireccion.Text = "";
                    txtAgregarUsuarioContrasena.Text = "";
                    txtAgregarUsuarioContrasenaV.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Las Contraseñas no coinciden y/o los datos no estan completados");
            }
        }

        private void btnAgregarAutomovil_Click(object sender, EventArgs e)
        {
            veiculosTableAdapter ConsultaVeiculos = new veiculosTableAdapter();
            Boolean shot = true;

            if (txtAgregarAutomovilMatricula.Text != "" && txtAgregarAutomovilMarca.Text != "" && txtAgregarAutomovilModelo.Text != "" && txtAgregarAutomovilMotor.Text != "" && txtAgregarAutomovilTipo.Text != "" && txtAgregarAutomovilTransmision.Text != "" && txtAgregarAutomovilEstado.Text != "" && txtAgregarAutomovilPrecio.Text != "")
            {
                foreach (DataRow row in ConsultaVeiculos.BuscarVeiculo().Rows)
                {
                    if (row[0].ToString() == txtAgregarAutomovilMatricula.Text)
                    {
                        MessageBox.Show("La matricula: " + row[0].ToString() + " ya existe");
                        shot = false;
                    }

                }

                if (shot == true)
                {
                    ConsultaVeiculos.Insert(txtAgregarAutomovilMatricula.Text, txtAgregarAutomovilMarca.Text, txtAgregarAutomovilModelo.Text, txtAgregarAutomovilMotor.Text, txtAgregarAutomovilTipo.Text, txtAgregarAutomovilTransmision.Text, txtAgregarAutomovilEstado.Text, txtAgregarAutomovilPrecio.Text);
                    MessageBox.Show(txtAgregarAutomovilMatricula.Text + "Agregado");
                    txtAgregarAutomovilMatricula.Text = "";
                    txtAgregarAutomovilMarca.Text = "";
                    txtAgregarAutomovilModelo.Text = "";
                    txtAgregarAutomovilMotor.Text = "";
                    txtAgregarAutomovilTipo.Text = "";
                    txtAgregarAutomovilTransmision.Text = "";
                    txtAgregarAutomovilEstado.Text = "";
                    txtAgregarAutomovilPrecio.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Los datos no estan completados");
            }
        }
    }
}
