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
            tabControlAutomoviles.Enabled = false;
            tabControlUsuarios.Enabled = false;
            tabControlReservas.Enabled = false;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter ConsultaUsuarios = new usuariosTableAdapter();
            Boolean shot = true;

            if (txtAgregarUsuarioContrasena.Text == txtAgregarUsuarioContrasenaV.Text && txtAgregarUsuarioUsuario.Text != "" && txtAgregarUsuarioNombre.Text != "" && txtAgregarUsuarioPaterno.Text != "" && txtAgregarUsuarioMaterno.Text != "" && txtAgregarUsuarionivel.Text != "" && txtAgregarUsuarioTelefono.Text != "" && txtAgregarUsuarioDireccion.Text != "" && txtAgregarUsuarioContrasena.Text != "")
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
                    ConsultaUsuarios.Insert(txtAgregarUsuarioUsuario.Text, txtAgregarUsuarioNombre.Text, txtAgregarUsuarioPaterno.Text, txtAgregarUsuarioMaterno.Text, txtAgregarUsuarionivel.Text, txtAgregarUsuarioTelefono.Text, txtAgregarUsuarioDireccion.Text, txtAgregarUsuarioContrasena.Text);
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

        private void tabAgregarReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuariosBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario buscar = new FrmBuscarUsuario();
            buscar.Show();
        }

        private void btnUsuariosBorrarUsuario_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter ConsultaUsuarios = new usuariosTableAdapter();
            ConsultaUsuarios.BorrarUsuario(txtUsuariosBorraUsuario.Text);
            MessageBox.Show("Se ha borrado con exito");
            txtUsuariosBorraUsuario.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario buscar = new FrmBuscarUsuario();
            buscar.Show();
        }

        private void btnEdeitarUsuario_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter ConsultaUsuarios = new usuariosTableAdapter();
            dataModificaUsuario.DataSource = ConsultaUsuarios.BuscarUsuarioPorUsuario(txtModificarUsuario.Text);
            txtModificarUsuario.Enabled = false;
        }

        private void btnmodificarGuardar_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter ConsultaUsuarios = new usuariosTableAdapter();
            ConsultaUsuarios.ModificarUsuario(txtModificarUsuario.Text, dataModificaUsuario[1, 0].Value.ToString(), dataModificaUsuario[2, 0].Value.ToString(), dataModificaUsuario[3, 0].Value.ToString(), dataModificaUsuario[4, 0].Value.ToString(), dataModificaUsuario[7, 0].Value.ToString(), dataModificaUsuario[6, 0].Value.ToString(), dataModificaUsuario[7, 0].Value.ToString(), txtModificarUsuario.Text);
            MessageBox.Show("Se modifico con exito el  usuario " + txtModificarUsuario.Text);
            txtModificarUsuario.Enabled = true;
            txtModificarUsuario.Text = "";
        }

        private void btnBuscarMatriculaeliminar_Click(object sender, EventArgs e)
        {
            FrmBuscarMatricula buscarmatricula = new FrmBuscarMatricula();
            buscarmatricula.Show();
        }

        private void btnBorrarMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                veiculosTableAdapter ConsultaUsuarios = new veiculosTableAdapter();
                ConsultaUsuarios.Borrarmatricula(txtEliminarMatricula.Text);
                MessageBox.Show("Se elimino con exito");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscarMatricula buscarmatricula = new FrmBuscarMatricula();
            buscarmatricula.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            veiculosTableAdapter ConsultaVel = new veiculosTableAdapter();
            dataEditarAuto.DataSource = ConsultaVel.Buscarmatriculamatricula(txtModificarMatricula.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                veiculosTableAdapter ConsultaVel = new veiculosTableAdapter();
                ConsultaVel.ModificarVel(txtModificarMatricula.Text, dataEditarAuto[1, 0].Value.ToString(), dataEditarAuto[2, 0].Value.ToString(), dataEditarAuto[3, 0].Value.ToString(), dataEditarAuto[4, 0].Value.ToString(), dataEditarAuto[5, 0].Value.ToString(), comboModificarEstado.Text, textmodificarPrecio.Text, txtModificarMatricula.Text);
                dataEditarAuto.DataSource = ConsultaVel.Buscarmatriculamatricula(txtModificarMatricula.Text);
                MessageBox.Show("Se modifico con exito la matricula " + txtModificarMatricula.Text);
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void btnReservabuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarMatricula buscarmatricula = new FrmBuscarMatricula();
            buscarmatricula.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "existente":
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox7.Enabled = false;

                    textBox2.Enabled = true;

                    break;
                case "nuevo":
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    textBox6.Enabled = true;
                    textBox7.Enabled = true;

                    textBox2.Enabled = false;
                    break;


            }
        }

        private void btnAgregarUsuarioreserva_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter ConsultaUsuarios = new usuariosTableAdapter();
            ConsultaUsuarios.Insert(textBox7.Text + textBox4.Text, textBox7.Text, textBox6.Text, textBox5.Text, "cliente", textBox4.Text, textBox3.Text, "NULL");

            MessageBox.Show("Se agrego con exito alv compa");
            textBox2.Text = textBox7.Text + textBox4.Text;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            veiculosTableAdapter Consultacar = new veiculosTableAdapter();
            int dias = (dateentrega.Value - daterecogida.Value).Days;
            int no = (dateentrega.Value - DateTime.Now).Days;
            MessageBox.Show(no + "---" + dias);
            if (dias >= 2 && no >= 0)
            {
                foreach (DataRow row in Consultacar.BuscarVeiculos().Rows)
                {
                    if (row[0].ToString() == textBox1.Text)
                    {
                        textBox8.Text = row[7].ToString();
                        textBox9.Text = dias.ToString();
                        textBox10.Text = (Convert.ToUInt16(row[7].ToString()) * dias).ToString();

                    }

                }

            }
            else
            {
                MessageBox.Show("La cantidad minima de renta son 2 dias");
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            reservasTableAdapter reserva = new reservasTableAdapter();
            veiculosTableAdapter ConsultaVeiculos = new veiculosTableAdapter();
            reserva.Insert(textBox7.Text + textBox4.Text, textBox1.Text, daterecogida.Value, dateentrega.Value, textBox8.Text, textBox9.Text, textBox10.Text);

            foreach (DataRow row in ConsultaVeiculos.BuscarVeiculo().Rows)
            {
                if (row[0].ToString() == textBox1.Text)
                {
                   ConsultaVeiculos.Hola("En uso", textBox1.Text);
                }

            }
            MessageBox.Show("Reserva exitosa");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmBuscarUsuario buscar = new FrmBuscarUsuario();
            buscar.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter ConsultaUsuarios = new usuariosTableAdapter();
            foreach (DataRow row in ConsultaUsuarios.BuscarUsuarioPorUsuario(txtLoginUsuario.Text).Rows)
            {
                if (row[0].ToString() == txtLoginUsuario.Text && row[7].ToString() == txtLoginContrasena.Text)
                {
                    
                    MessageBox.Show("usuario " + row[0].ToString() + " tipo "+ row[4].ToString());
                    if (row[4].ToString() == "administrador")
                    {
                        tabControlAutomoviles.Enabled = true;
                        tabControlUsuarios.Enabled = true;
                        tabControlReservas.Enabled = false;
                    }else if (row[4].ToString() == "vendedor")
                    {
                        tabControlAutomoviles.Enabled = false;
                        tabControlUsuarios.Enabled = false;
                        tabControlReservas.Enabled = true;

                    }else if (row[4].ToString() == "root")
                    {
                        tabControlAutomoviles.Enabled = true;
                        tabControlUsuarios.Enabled = true;
                        tabControlReservas.Enabled = true;

                    }
                    txtLoginContrasena.Enabled = false;
                    txtLoginUsuario.Enabled = false;
                }

            }


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            txtLoginContrasena.Enabled = true;
            txtLoginUsuario.Enabled = true;
            txtLoginContrasena.Clear();
            txtLoginUsuario.Clear();
            tabControlAutomoviles.Enabled = false;
            tabControlUsuarios.Enabled = false;
            tabControlReservas.Enabled = false;
        }

        private void txtAgregarUsuarioUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
