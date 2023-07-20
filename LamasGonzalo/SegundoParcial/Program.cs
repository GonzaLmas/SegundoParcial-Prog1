using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SegundoParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdministradorArchivos arcLectura = new AdministradorArchivos();
            arcLectura.LeerArchivo();

            Arbol arbol = new Arbol();

            Nodo raiz = new Nodo();
            raiz.Letra = "A";
            raiz.Id = 4;
            arbol.Insertar(raiz);

            Nodo nodoB = new Nodo();
            nodoB.Letra = "B";
            nodoB.Id = 2;
            arbol.Insertar(nodoB);

            Nodo nodoC = new Nodo();
            nodoC.Letra = "C";
            nodoC.Id = 1;
            arbol.Insertar(nodoC);

            Nodo nodoD = new Nodo();
            nodoD.Letra = "D";
            nodoD.Id = 3;
            arbol.Insertar(nodoD);

            Nodo nodoE = new Nodo();
            nodoE.Letra = "E";
            nodoE.Id = 6;
            arbol.Insertar(nodoE);

            Nodo nodoF = new Nodo();
            nodoF.Letra = "F";
            nodoF.Id = 5;
            arbol.Insertar(nodoF);

            Nodo nodoG = new Nodo();
            nodoG.Letra = "G";
            nodoG.Id = 7;
            arbol.Insertar(nodoG);

            Console.WriteLine("Recorrido pre orden: ");
            arbol.RecorrerPreOrden();

            Console.WriteLine("\nRecorrido in orden: ");
            arbol.RecorrerInOrden();

            Console.WriteLine("\nRecorrido post orden: ");
            arbol.RecorrerPostOrden();

            Console.WriteLine("\nRecorrido en amplitud del árbol es: ");
            AdministradorArchivos arcEscritura = new AdministradorArchivos();
            arcEscritura.EscribirArchivo();


            Console.ReadKey();
        }

    }
}
