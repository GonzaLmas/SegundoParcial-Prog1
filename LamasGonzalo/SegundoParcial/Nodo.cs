using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class Nodo
    {
        public int Id { get; set; }
        public string Letra { get; set; }
        public Nodo(string nombre = "")
        {
            Letra = nombre;
        }
        public Nodo Derecha { get; set; }
        public Nodo Izquierda { get; set; }
    }
}
