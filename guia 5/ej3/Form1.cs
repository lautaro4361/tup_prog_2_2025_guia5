using System.Text.RegularExpressions;
using ej3.Models;

namespace ej3
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

        private void button1_Click(object sender, EventArgs e)
        {

            List<Vehiculo> list = new List<Vehiculo>();

            string contenido = tbXMLContenido.Text;

            Regex regex = new Regex(@"<multa>[\s\S]*?</multa>", RegexOptions.IgnoreCase);

            Match math = regex.Match(contenido);

            lsbVer.Items.Clear();
            while (math.Success)
            {
                lsbVer.Items.Add(math.Value);

                Vehiculo nuevo = new Vehiculo();

                if (nuevo.Importar(math.Value))
                {
                    int idx = list.BinarySearch(nuevo);
                    if (idx > -1)
                    {
                        for (int n = 0; n < nuevo.CantidadMultas; n++)
                            list[idx].AgregarMulta(nuevo.VerMulta(n));
                    }
                    else
                        list.Add(nuevo);
                }

                math = math.NextMatch();
            }

            lsbVer.Items.Clear();
            foreach (Vehiculo v in list)
            {
                lsbVer.Items.Add(v.ToString().Trim());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
