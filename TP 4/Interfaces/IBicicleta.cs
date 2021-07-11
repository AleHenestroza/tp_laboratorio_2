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
        double CantMaterialNecesario();
        string MaterialNecesario();
        double GetRodado();
        double GetTamanioCuadro();
        bool GetCaraceristica();
    }
}
