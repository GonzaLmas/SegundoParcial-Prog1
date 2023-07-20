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
                        Console.WriteLine("La información que hay en el archivo arbol.txt es: " + sr.ReadToEnd() + "\n\n");
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

            try
            {
                string filePath = ConfigurationManager.AppSettings["PathAmplitud"];

                using (FileStream archivo = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    using (StreamWriter escritura = new StreamWriter(archivo))
                    {
                        List<string> recorridoAmplitud = new List<string>();

                        //   recorridoAmplitud = arbol.RecorrerAmplitud();

                        escritura.Write(recorridoAmplitud);

                        Console.WriteLine(recorridoAmplitud);
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
