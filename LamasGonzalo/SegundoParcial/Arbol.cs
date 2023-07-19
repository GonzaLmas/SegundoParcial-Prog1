using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class Arbol
    {
        public Nodo Raiz { get; set; }

        public void RecorrerInOrden()
        {
            RecursivoInOrden(this.Raiz, "-");
        }
        private void RecursivoInOrden(Nodo nodo, string nivel)
        {
            if (nodo != null)
            {
                this.RecursivoInOrden(nodo.Izquierda, "-");
                Console.WriteLine(nivel + nodo.Letra);
                this.RecursivoInOrden(nodo.Derecha, "-");
            }
        }

        public void RecorrerPreOrden()
        {
            RecursivoPreOrden(this.Raiz, "-");
        }
        private void RecursivoPreOrden(Nodo nodo, string nivel)
        {
            if (nodo != null)
            {
                Console.WriteLine(nivel + nodo.Letra);

                this.RecursivoPreOrden(nodo.Izquierda, nivel);
                this.RecursivoPreOrden(nodo.Derecha, nivel);
            }
        }

        public void RecorrerPostOrden()
        {
            RecursivoPostOrden(this.Raiz, "-");
        }
        private void RecursivoPostOrden(Nodo nodo, string nivel)
        {
            if (nodo != null)
            {
                this.RecursivoPostOrden(nodo.Izquierda, "-");
                this.RecursivoPostOrden(nodo.Derecha, "-");
                Console.WriteLine(nivel + nodo.Letra);
            }
        }

        public void RecorrerAmplitud()
        {
            RecursivoAmplitud(new List<Nodo>() { Raiz }, 1);
        }
        private void RecursivoAmplitud(List<Nodo> listaNodos, int nivel)
        {

            if (listaNodos.Count > 0)
            {
                List<Nodo> siguienteNivel = new List<Nodo>();

                Console.WriteLine("Nivel: " + nivel);

                foreach (var nodo in listaNodos)
                {
                    Console.WriteLine(nodo.Letra);

                    if (nodo.Izquierda != null)
                        siguienteNivel.Add(nodo.Izquierda);

                    if (nodo.Derecha != null)
                        siguienteNivel.Add(nodo.Derecha);
                }

                nivel++;
                RecursivoAmplitud(siguienteNivel, nivel);
            }
        }

        public void Insertar(Nodo n)
        {
            if (n != null)
            {
                if (Raiz == null)
                    Raiz = n;
                else
                {
                    Nodo recorrido = Raiz;
                    Nodo anterior = Raiz;
                    bool derecha = false;

                    while (recorrido != null)
                    {
                        anterior = recorrido;

                        if (n.Id < recorrido.Id)
                        {
                            recorrido = recorrido.Izquierda;
                            derecha = false;
                        }
                        else
                        {
                            recorrido = recorrido.Derecha;
                            derecha = true;
                        }
                    }

                    if (derecha)
                        anterior.Derecha = n;
                    else
                        anterior.Izquierda = n;
                }
            }
        }
    }
}
