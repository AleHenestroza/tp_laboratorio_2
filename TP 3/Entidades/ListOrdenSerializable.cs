using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class ListOrdenSerializable
    {
        private List<Orden> listadoOrdenes;

        public ListOrdenSerializable()
        {
            this.listadoOrdenes = new List<Orden>();
        }
        public ListOrdenSerializable(List<Orden> listadoOrdenes) : this()
        {
            this.listadoOrdenes = listadoOrdenes;
        }

        public List<Orden> ListadoOrdenes
        {
            get
            {
                return this.listadoOrdenes;
            }
        }

        //public void ImprimirArchivos()
        //{
        //    StreamWriter sw;
        //    for (int i = 0; i < this.listadoOrdenes.Count; i++)
        //    {
        //        // CurrentDirectory retorna la ruta a {proyecto}\bin\debug\ donde {proyecto}
        //        // es el proyecto en el cual se está llamando a esta función (por ejemplo,
        //        // FrmPrincipal).
        //        // De esa forma, debemos retroceder una vez para estar en \bin, otra vez para
        //        // quedar en la ruta del proyecto y una última vez para quedar en la ruta de
        //        // la solución, donde se creo una carpeta Ordenes para ir guardando los archivos.
        //        string path = Environment.CurrentDirectory + "\\..\\..\\..\\Ordenes\\";
        //        sw = new StreamWriter(path + "Orden N" + (i + 1) + ".txt");
        //        sw.Write(listadoOrdenes[i].ToString());
        //        sw.Close();
        //    }
        //}
    }
}
