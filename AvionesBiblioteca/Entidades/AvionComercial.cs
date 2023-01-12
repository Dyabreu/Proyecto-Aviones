using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvionesBiblioteca.Entidades.BASE;

namespace AvionesBiblioteca.Entidades
{
    public class AvionComercial : Avion
    {
        public AvionComercial(string piloto, string copiloto, string azafata, int capacidad, int lineaAerea) : base(piloto, copiloto, azafata)
        { Capacidad = capacidad;
          LineaAerea = lineaAerea;
        }
        public int Capacidad { get; set; }
        public int LineaAerea { get; set; }

        public override string Aterriza()
        {
            return base.Aterriza() + "Avión Comercial.";
        }
        public override string Despega()
        {
            return base.Despega() + "Avión Comercial.";
        }
        public override string ToString()
        {
            return "El piloto de este vuelo es: " + Piloto + ".\nNuestro copiloto será: " + Copiloto + ".\nLa azafata será: " + Azafata + ".\n La capacidad del avión es de " + Capacidad + "pasajeros.\n Nuestra línea aérea es la número " + LineaAerea;
        }

    }
}
