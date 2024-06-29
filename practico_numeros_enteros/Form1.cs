using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico_numeros_enteros
{
    public partial class Form1 : Form
    {
        Nenter n1,n2,n3,n4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n1 = new Nenter();
            n2 = new Nenter();
            n3 = new Nenter();
            n4 = new Nenter();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Cargar(int.Parse(textBox1.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Concat(n1.Descargar());
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.Facto());
        }

        private void esFibToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.EsFibo());
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n2.Cargar(int.Parse(textBox1.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat(n2.Descargar());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void verifMultiploDeOtroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.EsMult(n2));
        }

        private void verifSubmultiploDeOtroNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.EsSubMult(n2));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            n1.Unir2NAs(n2,n3);
        }

        private void descargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n4.Descargar());
        }

        private void unirTresNuemrosEnterosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Unir3N(n2, n3, n4);
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(n3.Descargar());
        }

        private void mayorDeTresNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.MayorNUm(n2,n3,n4);
        }

        private void verifNumerosIgualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.VerifToNum());
        }

        private void verifTodoParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.VerifTodoPar()); // true => "true"
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void descargarEjercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(n3.Descargar());
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            n3.Cargar(int.Parse(textBox1.Text));
        }

        private void esExponencial2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.EsExpone());
        }


    }
}
