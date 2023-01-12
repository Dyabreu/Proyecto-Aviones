using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionesBiblioteca.Entidades.BASE
{
    public abstract class Avion
    {
        public Avion () { }
        public Avion (string piloto, string copiloto, string azafata) 
            {
            Piloto = piloto; 
            Copiloto = copiloto; 
            Azafata = azafata; 
            }
    
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }

        public virtual string Aterriza() 
        {
            return "Aterriza el "; 
        }
        public virtual string Despega ()
        {
            return "Despega el ";
        }
    }
}
