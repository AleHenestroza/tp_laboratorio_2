using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Interfaces;
using Entidades.Excepciones;
using Entidades.Productos.Componentes;
using Entidades.Productos.Materiales;
using Entidades.Productos.Accesorios;
using Entidades.Productos.Bicicletas;
using Entidades.DAO.Orden;
using Entidades.DAO.Accesorios;

namespace Entidades.Orden
{
    /// <summary>
    /// Al guardar una orden en la BD, se deben guardar sus componentes (bicicletas y accesorios) en sus respectivas tablas.
    /// En el formulario se subscriben los métodos manejadores para cada componente, en caso de que la orden los incluya.
    /// </summary>
    /// <param name="orden"></param>
    public delegate void DelGuardarOrden(Orden orden);
    [Serializable]
    public class Orden
    {
        #region ATRIBUTOS
        private IBicicleta bicicletaMB;
        private int cantBicicletaMB;
        private IBicicleta bicicletaP;
        private int cantBicicletaP;
        private IFabricable casco;
        private int cantCasco;
        private IFabricable luz;
        private int cantLuz;
        private double costo;
        private int id;
        public event DelGuardarOrden OrdenCreada; // Al crear una orden, se debe insertar todos sus componentes en las tablas respectivas de la BD
        #endregion
        #region CONSTRUCTORES
        public Orden()
        {
        }
        public Orden(int id, IBicicleta bicicletaMB, int cantBicicletaMB, IBicicleta bicicletaP, int cantBicicletaP, IFabricable casco, int cantCasco, IFabricable luz, int cantLuz)
        {
            this.id = id;
            this.bicicletaMB = bicicletaMB;
            this.cantBicicletaMB = cantBicicletaMB;
            this.bicicletaP = bicicletaP;
            this.cantBicicletaP = cantBicicletaP;
            this.casco = casco;
            this.cantCasco = cantCasco;
            this.luz = luz;
            this.cantLuz = cantLuz;
            this.costo = this.CalcularCosto();
        }
        #endregion
        #region PROPIEDADES
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public IBicicleta BicicletaMB
        {
            get { return this.bicicletaMB; }
            set { this.bicicletaMB = value; }
        }
        public IBicicleta BicicletaP
        {
            get { return this.bicicletaP; }
            set { this.bicicletaP = value; }
        }
        public IFabricable Casco
        {
            get { return this.casco; }
            set { this.casco = value; }
        }
        public int CantidadCascos
        {
            get { return this.cantCasco; }
            set { this.cantCasco = value; }
        }
        public IFabricable Luz
        {
            get { return this.luz; }
            set { this.luz = value; }
        }
        public int CantidadLuces
        {
            get { return this.cantLuz; }
            set { this.cantLuz = value; }
        }
        public int CantidadMB
        {
            get { return this.cantBicicletaMB; }
            set { this.cantBicicletaMB = value; }
        }
        public int CantidadP
        {
            get { return this.cantBicicletaP; }
            set { this.cantBicicletaP = value; }
        }
        public string Bicicletas
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < this.cantBicicletaMB; i++)
                {
                    sb.AppendLine(this.bicicletaMB.ToString());
                }
                for (int i = 0; i < this.cantBicicletaP; i++)
                {
                    sb.AppendLine(this.bicicletaP.ToString());
                }
                return sb.ToString();
            }
        }
        public string Accesorios
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < this.cantCasco; i++)
                {
                    sb.AppendLine(this.casco.ToString());
                }
                for (int i = 0; i < this.cantLuz; i++)
                {
                    sb.AppendLine(this.luz.ToString());
                }
                return sb.ToString();
            }
        }
        public double Costo
        {
            get { return this.costo; }
        }
        #endregion
        #region METODOS
        private double CalcularCosto()
        {
            double costo = 0;
            if (!(this.bicicletaMB is null))
            {
                costo += this.bicicletaMB.CalcularCosto() * this.cantBicicletaMB;
            }
            if (!(this.bicicletaP is null))
            {
                costo += this.bicicletaP.CalcularCosto() * this.cantBicicletaP;
            }
            if (!(this.casco is null))
            {
                costo += this.casco.CalcularCosto() * this.cantCasco;
            }
            if (!(this.luz is null))
            {
                costo += this.luz.CalcularCosto() * this.cantLuz;
            }
            return costo;
        }
        public void RecalcularCosto()
        {
            this.costo = this.CalcularCosto();
        }
        public string MostrarOrden()
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
        public override string ToString()
        {
            return "Orden";
        }
        public static int GetLastOrdenId()
        {
            OrdenDAO ordenDAO = new OrdenDAO();
            return ordenDAO.GetLastOrdenId();
        }
        public void InsertOrden()
        {
            Thread hiloInsertar = new Thread(InsertarOrden);
            hiloInsertar.Start();
        }
        private void InsertarOrden()
        {
            OrdenDAO ordenDAO = new OrdenDAO();
            double costo = this.Costo;
            bool tieneMB = this.BicicletaMB != null;
            bool tieneP = this.BicicletaP != null;
            bool tieneCasco = this.casco != null;
            bool tieneLuz = this.luz != null;
            ordenDAO.InsertOrden(costo, tieneMB, tieneP, tieneCasco, tieneLuz);
            this.Id = ordenDAO.GetLastOrdenId(); // Tras insertar la orden, recupero el Id ingresado (autogenerado por la DB)
            this.OrdenCreada(this);
        }
        #endregion
    }
}
