using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades.Productos.Bicicletas;
using Entidades.Excepciones;
using Entidades.Productos.Componentes;
using Entidades.Productos.Materiales;

namespace TestUnitarios
{
    [TestClass]
    public class TestProductosMountainBike
    {
        [TestMethod]
        public void TestGenericType()
        {
            // ARRANGE
            Rueda r1 = new Rueda(26);
            MountainBike<Acero> b1;
            MountainBike<Titanio> b2;
            // ACT
            b1 = new MountainBike<Acero>(r1, r1, 32, true);
            b2 = new MountainBike<Titanio>(r1, r1, 32, true);
            // ASSERT
            // Al instanciar el objeto, el cuadro toma el material correcto?
            Assert.IsInstanceOfType(b1.Cuadro.Material, typeof(Acero));
            Assert.IsInstanceOfType(b2.Cuadro.Material, typeof(Titanio));
        }

        [TestMethod]
        public void TestConstructorInvalido()
        {
            // ARRANGE
            Rueda r1 = new Rueda(26);
            Rueda r2 = new Rueda(28);
            MountainBike<Aluminio> b1;

            try
            {
                // ACT
                b1 = new MountainBike<Aluminio>(r1, r2, 32, false);
            }
            catch (Exception exc)   // Se captura cualquier excepción, luego se comprueba
                                    // si es del tipo adecuado
            {
                // ASSERT
                // Se lanza correctamente la excepción al pasar los parámetros inválidos?
                Assert.IsInstanceOfType(exc, typeof(RuedaIncompatibleException));
            }
        }

        [TestMethod]
        public void TestRodadoInvalido()
        {
            // ARRANGE
            Rueda r1 = new Rueda(12);
            MountainBike<Titanio> b1;

            try
            {
                // ACT
                b1 = new MountainBike<Titanio>(r1, r1, 30, false);
            }
            catch (Exception exc)
            {
                // ASSERT
                // Se lanza una excepcion al pasar un rodado no incluido en la lista
                // de rodados validos?
                Assert.IsInstanceOfType(exc, typeof(RuedaIncompatibleException));
            }
        }
    }
}
