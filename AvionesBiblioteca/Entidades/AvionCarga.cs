using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvionesBiblioteca.Entidades.BASE;

namespace AvionesBiblioteca.Entidades
{
    public class AvionCarga : Avion
    {
        public AvionCarga(string piloto, string copiloto, string azafata, int peso, string tipoMercaderia) : base(piloto, copiloto, azafata)
        {
            Peso = peso;
            TipoMercaderia = tipoMercaderia;
        }
        public int Peso { get; set; }
        public string TipoMercaderia { get; set; }

        public override string Aterriza()
        {
            return base.Aterriza() + "Avión de Carga.";
        }
        public override string Despega()
        {
            return base.Despega() + "Avión de Carga.";
        }

        public override string ToString()
        {
            return "El piloto de este vuelo es: " + Piloto + ".\nNuestro copiloto será: " + Copiloto + ".\nLa azafata será: " + Azafata + ".\n Tiene un peso de: " + Peso + "Kg.\nLlevamos mercadería " + TipoMercaderia;
        }
    }
}
