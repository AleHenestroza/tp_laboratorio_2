using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos;
using Entidades.Interfaces;
using Entidades.Excepciones;
using Entidades.Productos.Componentes;
using Entidades.Productos.Materiales;
using Entidades.Productos.Accesorios;

namespace Entidades
{
    /// <summary>
    /// La clase Orden representa un pedido que se le hará a la fabrica.
    /// Contiene una lista de bicicletas que se deben producir, la
    /// fecha de creación y la fecha estimada de finalización.
    /// </summary>
    [Serializable]
    public class Orden
    {
        private List<IFabricable> bicicletas;
        private List<Accesorio> accesorios;
        private double costo;
        private DateTime fechaCreacion;
        private DateTime fechaProduccion;

        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Orden()
        {
            this.bicicletas = new List<IFabricable>();
            this.accesorios = new List<Accesorio>();
            this.fechaCreacion = DateTime.Now;
            this.costo = 0;
        }
        /// <summary>
        /// Constructor de la Orden.
        /// Recibe la fecha estimada de producción. En caso de ser igual o
        /// anterior a la fecha en que se creó, lanza una excepción.
        /// </summary>
        /// <param name="fechaProduccion"></param>
        public Orden(DateTime fechaProduccion)
        {
            if (!(DateTime.Compare(fechaProduccion, DateTime.Now) > 0))
            {
                throw new FechaInvalidaException("La fecha estimada de producción debe ser posterior" +
                                                 "a la fecha de creación de la Orden.");
            } 
            else
            {
                this.bicicletas = new List<IFabricable>();
                this.accesorios = new List<Accesorio>();
                this.fechaCreacion = DateTime.Now;
                this.fechaProduccion = fechaProduccion;
                this.costo = 0;
            }
        }

        public void OrdenarBicicletas<T>(
            int cantidad,
            Rueda r1,
            Rueda r2,
            double tamanioCuadro,
            bool caracteristicaBicicleta,
            bool esMountainBike)
            where T : Material, new()
        {
            if (esMountainBike)
            {
                this.OrdenarBicicletasMountainBike<T>(cantidad, r1, r2, tamanioCuadro, caracteristicaBicicleta);
            }
            else
            {
                this.OrdenarBicicletasPlayeras<T>(cantidad, r1, r2, tamanioCuadro, caracteristicaBicicleta);
            }
        }

        /// <summary>
        /// Agrega a la lista multiples bicicletas playeras
        /// </summary>
        /// <typeparam name="T">Material del cuadro</typeparam>
        /// <param name="cantidad">int Cantidad de bicicletas a producir</param>
        /// <param name="r1">Ruedas delanteras</param>
        /// <param name="r2">Ruedas traseras</param>
        /// <param name="tamanioCuadro">double tamaño de los cuadros</param>
        /// <param name="frenoContraPedal">bool tienen frenos</param>
        public void OrdenarBicicletasPlayeras<T>(int cantidad,
                                        Rueda r1,
                                        Rueda r2,
                                        double tamanioCuadro,
                                        bool frenoContraPedal)
            where T: Material, new()
        {
            for (int i = 0; i < cantidad; i++)
            {
                this.OrdenarPlayera<T>(r1, r2, tamanioCuadro, frenoContraPedal);
            }
        }

        /// <summary>
        /// Agrega a la lista multiples bicicletas Mountain Bike
        /// </summary>
        /// <typeparam name="T">Material del cuadro</typeparam>
        /// <param name="cantidad">int Cantidad de bicicletas a producir</param>
        /// <param name="r1">Ruedas delanteras</param>
        /// <param name="r2">Ruedas traseras</param>
        /// <param name="tamanioCuadro">double tamaño de los cuadros</param>
        /// <param name="tieneCambios">bool tienen cambios</param>
        public void OrdenarBicicletasMountainBike<T>(int cantidad,
                                                Rueda r1,
                                                Rueda r2,
                                                double tamanioCuadro,
                                                bool tieneCambios)
            where T : Material, new()
        {
            for (int i = 0; i < cantidad; i++)
            {
                this.OrdenarMountainBike<T>(r1, r2, tamanioCuadro, tieneCambios);
            }
        }

        /// <summary>
        /// Agrega a la orden una bicicleta playera
        /// </summary>
        /// <typeparam name="T">Material del cuadro</typeparam>
        /// <param name="r1">Rueda delantera</param>
        /// <param name="r2">Rueda trasera</param>
        /// <param name="tamanioCuadro">double tamaño del cuadro</param>
        /// <param name="frenoContraPedal">bool tiene freno</param>
        private void OrdenarPlayera<T>(Rueda r1, Rueda r2, double tamanioCuadro, bool frenoContraPedal)
            where T: Material, new()
        {
            Bicicleta<T> nuevaBicicleta = new Playera<T>(r1, r2, tamanioCuadro, frenoContraPedal);
            this.costo += nuevaBicicleta.CalcularCosto();
            this.bicicletas.Add(nuevaBicicleta);

        }
        /// <summary>
        /// Agrega a la orden una bicicleta mountain bike
        /// No fue posible aplicar sobrecarga en este caso, dado que ambas
        /// bicicletas requieren la misma cantidad y los mismos tipos de parametros
        /// </summary>
        /// <typeparam name="T">Material del cuadro</typeparam>
        /// <param name="r1">Rueda delantera</param>
        /// <param name="r2">Rueda trasera</param>
        /// <param name="tamanioCuadro">double tamaño del cuadro</param>
        /// <param name="tieneCambios">bool tiene cambios</param>
        private void OrdenarMountainBike<T>(Rueda r1, Rueda r2, double tamanioCuadro, bool tieneCambios)
            where T : Material, new()
        {
            Bicicleta<T> nuevaBicicleta = new MountainBike<T>(r1, r2, tamanioCuadro, tieneCambios);
            this.costo += nuevaBicicleta.CalcularCosto();
            this.bicicletas.Add(nuevaBicicleta);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidadCasco"></param>
        /// <param name="cantidadLuz"></param>
        /// <param name="diametro"></param>
        /// <param name="color"></param>
        public void OrdenarAccesorios(int cantidadCasco, int cantidadLuz, double diametro, string color)
        {
            if (cantidadCasco > 0 && diametro != 0)
            {
                for (int i = 0; i < cantidadCasco; i++)
                {
                    this.OrdenarAccesorio(diametro);
                }
            }
            if (cantidadLuz > 0 && color != "")
            {
                for (int i = 0; i < cantidadLuz; i++)
                {
                    this.OrdenarAccesorio(color);
                }
            }
        }

        /// <summary>
        /// Agrega un accesorio a la lista de accesorios
        /// </summary>
        /// <param name="diametro">Double diametro de un casco</param>
        private void OrdenarAccesorio(double diametro)
        {
            Casco nuevoCasco = new Casco(diametro);
            this.costo += nuevoCasco.Costo;
            this.accesorios.Add(nuevoCasco);
        }
        /// <summary>
        /// Agrega un accesorio a la lista de accesorios
        /// </summary>
        /// <param name="color">String color de la luz</param>
        private void OrdenarAccesorio(string color)
        {
            Luz nuevaLuz = new Luz(color);
            this.costo += nuevaLuz.Costo;
            this.accesorios.Add(nuevaLuz);
        }

        /// <summary>
        /// Getter, retorna lista de bicicletas
        /// </summary>
        public List<IFabricable> ListadoBicicletas
        {
            get
            {
                return this.bicicletas;
            }
        }

        /// <summary>
        /// Getter, retorna lista de accesorios
        /// </summary>
        public List<Accesorio> ListadoAccesorios
        {
            get
            {
                return this.accesorios;
            }
        }

        /// <summary>
        /// Retorna string con el listado completo de bicicletas
        /// </summary>
        public string Bicicletas
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach(IFabricable i in bicicletas)
                {
                    sb.Append(i.ToString());
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Retorna string con el listado completo de accesorios
        /// </summary>
        public string Accesorios
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Accesorio acc in accesorios)
                {
                    sb.Append(acc.ToString());
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Retorna el costo total de la orden
        /// </summary>
        public double Costo
        {
            get
            {
                return this.costo;
            }
        }

        public string FechaCrecion
        {
            get
            {
                return this.fechaCreacion.ToString("dddd, dd/MM/yyyy HH:mm:ss");
            }
        }

        public string FechaProduccion
        {
            get
            {
                return this.fechaProduccion.ToString("dddd, dd/MM/yyyy HH:mm:ss");
            }
            set
            {
                try
                {
                    DateTime nuevaFecha = DateTime.Parse(value);
                    this.fechaProduccion = nuevaFecha;
                }
                catch
                {
                    throw new FechaInvalidaException("La fecha introducida es inválida.");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("               BICICLETAS");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(this.Bicicletas);
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("               ACCESORIOS");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(this.Accesorios);
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("                 COSTO");
            sb.AppendLine("----------------------------------------");
            sb.AppendFormat("${0}\n\n", this.Costo);
            return sb.ToString();
        }
    }
}
