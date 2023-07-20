using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class AdministradorArchivos
    {
        public void LeerArchivo()
        {
            string filePath = ConfigurationManager.AppSettings["PathArbol"];

            try
            {
                using (FileStream archivoArbol = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(archivoArbol))
                    {
                        Console.WriteLine("La información que hay en arbol.txt es: " + sr.ReadToEnd() + "\n\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void EscribirArchivo()
        {
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

            try
            {
                string filePath = ConfigurationManager.AppSettings["PathAmplitud"];

                using (FileStream archivoAmplitud = new FileStream(filePath, FileMode.Append))
                {
                    using (StreamWriter escritura = new StreamWriter(archivoAmplitud))
                    {
                        string texto = arbol.RecorrerAmplitud();

                        escritura.WriteLine(texto);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
