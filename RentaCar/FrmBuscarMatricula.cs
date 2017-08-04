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
    public partial class FrmBuscarMatricula : Form
    {
        public FrmBuscarMatricula()
        {
            InitializeComponent();
        }

        private void FrmBuscarMatricula_Load(object sender, EventArgs e)
        {
            veiculosTableAdapter ConsultaVaiculo = new veiculosTableAdapter();
            dataBuscarMatricula.DataSource = ConsultaVaiculo.BuscarVeiculos();
        }

        private void comboBuscarMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboopcion.Items.Clear();


            switch (comboBuscarMatricula.Text)
            {
                case "marca":
                    comboopcion.Items.Insert(0,"");
                    comboopcion.Items.Insert(1, "TOYOTA");
                    comboopcion.Items.Insert(2, "Hyundai");
                    comboopcion.Items.Insert(3, "Kia");
                    comboopcion.Items.Insert(4, "Nissan");
                    comboopcion.Items.Insert(5, "Chrysler");
                    comboopcion.Items.Insert(6, "FORD");
                    comboopcion.Items.Insert(7, "HONDA");
                    comboopcion.Items.Insert(8, "Mitsubishi");
                    comboopcion.Items.Insert(9, "Mazda");
                    comboopcion.Items.Insert(10, "SCION");
                    comboopcion.Items.Insert(0, "Otros...");

                    break;
                case "motor":
                    comboopcion.Items.Insert(0, "");
                    comboopcion.Items.Insert(1, "Diesel");
                    comboopcion.Items.Insert(2, "Gasolina");
                    comboopcion.Items.Insert(3, "Hibrido");
                    comboopcion.Items.Insert(4, "Electrico");
              
                    break;
                case "tipo":
                    comboopcion.Items.Insert(0, "");
                    comboopcion.Items.Insert(1, "Sedan");
                    comboopcion.Items.Insert(2, "SUV");
                    comboopcion.Items.Insert(3, "PICKUP");
                    comboopcion.Items.Insert(4, "VAN");
                    comboopcion.Items.Insert(5, "Comercial");
                    comboopcion.Items.Insert(6, "Deportivo");


                    break;
                case "transmicion":
                    comboopcion.Items.Insert(0, "");
                    comboopcion.Items.Insert(1, "Automatica");
                    comboopcion.Items.Insert(2, "Manual");

                    break;
                case "estado":
                    comboopcion.Items.Insert(0, "");
                    comboopcion.Items.Insert(1, "Libre");
                    comboopcion.Items.Insert(2, "En uso");
                    comboopcion.Items.Insert(3, "En taller");

                    break;                    
            }
        }

        private void comboopcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            veiculosTableAdapter ConsultaVaiculo = new veiculosTableAdapter();
    
            switch (comboBuscarMatricula.Text)
            {
                case "marca":
                    dataBuscarMatricula.DataSource = ConsultaVaiculo.BuscarMatriculaMarca(comboopcion.Text);
                    break;
                case "motor":
                     dataBuscarMatricula.DataSource = ConsultaVaiculo.BuscarMatriculaMotor(comboopcion.Text);
                    break;
                case "tipo":
                     dataBuscarMatricula.DataSource = ConsultaVaiculo.BuscarMatriculaTipo(comboopcion.Text);
                    break;
                case "transmicion":
                     dataBuscarMatricula.DataSource = ConsultaVaiculo.BuscarMatriculaTransmicion(comboopcion.Text);
                    break;
                case "estado":
                     dataBuscarMatricula.DataSource = ConsultaVaiculo.BuscaMatriculaEstado(comboopcion.Text);
                    break;
            }

        }
    }
}
