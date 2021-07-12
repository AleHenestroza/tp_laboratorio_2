using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Esta interfaz sirve para obtener las propiedades de la bicicleta sin especificar su material
    /// </summary>
    public interface IBicicleta : IFabricable
    {
        /// <summary>
        /// Devuelve la cantidad de material necesario para fabricar una bicicleta (tamaño del cuadro)
        /// </summary>
        /// <returns></returns>
        double CantMaterialNecesario();
        /// <summary>
        /// Devuelve el nombre del material necesario para fabricar una bicicleta
        /// </summary>
        /// <returns></returns>
        string MaterialNecesario();
        /// <summary>
        /// Devuelve el rodado de la bicicleta
        /// </summary>
        /// <returns></returns>
        double GetRodado();
        /// <summary>
        /// Idem que CantMaterialNecesario, método duplicado que existe porque me olvidé que ya había otro método
        /// </summary>
        /// <returns></returns>
        double GetTamanioCuadro();
        /// <summary>
        /// Devuelve la característica de la bicicleta (tieneCambios o tieneFrenos)
        /// </summary>
        /// <returns></returns>
        bool GetCaraceristica();
    }
}
