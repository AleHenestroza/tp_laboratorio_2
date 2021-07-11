using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades.DAO.Orden;
using Entidades.Orden;

namespace TestUnitarios
{
    [TestClass]
    public class TestConexionDB
    {
        /// <summary>
        /// Selecciono las ordenes de la DB, si hay o no no importa, si se estableció correctamente una conexión
        /// el método SelectOrdenes retorna un ListOrden instanciado (si no, lanza una excepción)
        /// </summary>
        [TestMethod]
        public void TestConexion()
        {
            // ARRANGE
            OrdenDAO ordenDAO = new OrdenDAO();
            ListOrden listado = null;
            // ACT
            try
            {
                listado = ordenDAO.SelectOrdenes();
            }
            catch
            {
                Assert.Fail(); // No hubo una conexión exitosa, falla el test unitario.
            }
            // ASSERT
            Assert.IsNotNull(listado);
        }
    }
}
