using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea1.Entidades;
using tarea1.Negocio;

namespace tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsNotas Dante21 = new ClsNotas();
          
                    
            Convert.ToDouble(txtpar1.Text);

            Dante21.Materia = txtmateria.Text;
            Dante21.Nombre = txtnombre.Text;
            Dante21.Apellido = txtapellido.Text;
            Dante21.Laboratorio_1 = double.Parse(txtlab1.Text);
            Dante21.Laboratorio_2 = double.Parse(txtlab2.Text);
            Dante21.laboratorio_3 = double.Parse(txtlab3.Text);
            Dante21.parcial_1 = double.Parse(txtpar1.Text);
            Dante21.parcial_2 = double.Parse(txtpar2.Text);
            Dante21.parcial_3 = double.Parse(txtpar3.Text);
            NClsNotas logic = new NClsNotas();
            MessageBox.Show("Notas de la Asignatura de: " + Dante21.Materia + logic.CalculoDeNotas(Dante21));











        }
    }
}
