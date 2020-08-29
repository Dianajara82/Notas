using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        private object promedio;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Notas_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota_1, nota_2, nota_3, nota_4, nota_5, promedio;
            string condicion;

            nota_1 = double.Parse(txtnota1.Text);
            nota_2 = double.Parse(txtnota2.Text);
            nota_3 = double.Parse(txtnota3.Text);
            nota_4 = double.Parse(txtnota4.Text);
            nota_5 = double.Parse(txtnota5.Text);

            promedio = (nota_1 + nota_2 + nota_3 + nota_4 + nota_5) / 5;

            if (promedio <= 1)
            {
                condicion = "Reprueba la materia sin lograr realizar proceso de recuperación";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion.Text = condicion;

            }
            else if (promedio > 5 & promedio <= 4)
                condicion = "Aprobado";
            string v = promedio.ToString("N2");
            txtpromedio.Text = v;
            



        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();
            txtnota5.Clear();
            txtpromedio.Clear();
            txtcondicion.Clear();
            txtnota1.Focus();
        }
    }
}
