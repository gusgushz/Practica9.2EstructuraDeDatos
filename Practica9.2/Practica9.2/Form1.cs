using Practica9._2.Entities;

namespace Practica9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Reemplazador gus = new();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int cantidad = int.Parse(textBox1.Text);
            gus.AgregarNumeros(cantidad);
            foreach (int item in gus.numeros)
            {
                listBox1.Items.Add($"{item}");
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            int viejo = int.Parse(textBox2.Text);
            int nuevo = int.Parse(textBox3.Text);
            gus.Reemplazar(viejo, nuevo);
            foreach (int item in gus.numeros)
            {
                listBox2.Items.Add($"{item}");
            }

            textBox2.Clear();
            textBox3.Clear();
        }
    }
}