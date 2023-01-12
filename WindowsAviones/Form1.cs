using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvionesBiblioteca.Entidades;

namespace WindowsAviones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_avion_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial1 = new AvionComercial ("Juan Pérez", "Ana Sanchez", "Daniela Bravo", 500, 25);
            MessageBox.Show(avionComercial1.ToString() + ".\n !" + avionComercial1.Despega() + "\n !" + avionComercial1.Aterriza());

        }

        private void btn_Av_Carga_Click(object sender, EventArgs e)
        {
            AvionCarga avionCarga1 = new AvionCarga("Ramiro Lolo", "Luisa Verona", "Sara Fernandez", 2000, "Tecnología");
            MessageBox.Show(avionCarga1.ToString() + ".\n !" + avionCarga1.Despega() + "\n !" + avionCarga1.Aterriza());

        }
    }
}
