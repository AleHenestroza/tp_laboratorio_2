using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.Orden
{
    /// <summary>
    /// La clase ListOrden es simplemente una clase contenedora. Representa un objeto de tipo List<Orden>,
    /// al cual se le agrega la funcionalidad de ser exportado a archivos de texto.
    /// </summary>
    [Serializable]
    public class ListOrden
    {
        private List<Orden> listadoOrdenes;

        public ListOrden()
        {
            this.listadoOrdenes = new List<Orden>();
        }
        public ListOrden(List<Orden> listadoOrdenes)
        {
            this.listadoOrdenes = listadoOrdenes;
        }

        public List<Orden> ListadoOrdenes
        {
            get
            {
                return this.listadoOrdenes;
            }
            set
            {
                this.listadoOrdenes = value;
            }
        }

        public void AgregarOrden(Orden orden)
        {
            this.listadoOrdenes.Add(orden);
        }

        public void ImprimirArchivos()
        {
            StreamWriter sw;
            for (int i = 0; i < this.listadoOrdenes.Count; i++)
            {
                // CurrentDirectory retorna la ruta a {proyecto}\bin\debug\ donde {proyecto}
                // es el proyecto en el cual se está llamando a esta función (por ejemplo,
                // FrmPrincipal).
                // De esa forma, debemos retroceder una vez para estar en \bin, otra vez para
                // quedar en la ruta del proyecto y una última vez para quedar en la ruta de
                // la solución, donde se creo una carpeta Ordenes para ir guardando los archivos.
                string path = Environment.CurrentDirectory + "\\..\\..\\..\\Ordenes\\";
                sw = new StreamWriter(path + "Orden N" + (i + 1) + ".txt");
                sw.Write(listadoOrdenes[i].MostrarOrden());
                sw.Close();
            }
        }
        public void ImprimirArchivos(string path)
        {
            StreamWriter sw;
            for (int i = 0; i < this.listadoOrdenes.Count; i++)
            {
                // CurrentDirectory retorna la ruta a {proyecto}\bin\debug\ donde {proyecto}
                // es el proyecto en el cual se está llamando a esta función (por ejemplo,
                // FrmPrincipal).
                // De esa forma, debemos retroceder una vez para estar en \bin, otra vez para
                // quedar en la ruta del proyecto y una última vez para quedar en la ruta de
                // la solución, donde se creo una carpeta Ordenes para ir guardando los archivos.
                sw = new StreamWriter(path + "/Orden N" + (i + 1) + ".txt");
                sw.Write(listadoOrdenes[i].MostrarOrden());
                sw.Close();
            }
        }
    }
}
