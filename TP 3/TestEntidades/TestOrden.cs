using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Entidades.Productos;
using Entidades.Productos.Materiales;
using Entidades.Productos.Componentes;
using Entidades.Productos.Accesorios;
using Entidades.Excepciones;

namespace TestEntidades
{
    [TestClass]
    public class TestOrden
    {
        [TestMethod]
        public void TestConstructorFechaInvalida()
        {
            // ARRANGE
            Orden o1;
            int anio = 2005;
            int mes = 11;
            int dia = 26;
            DateTime fecha = new DateTime(anio, mes, dia);
            try
            {
                // ACT
                o1 = new Orden(fecha);
            }
            catch (Exception exc)
            {
                // ASSERT
                // Lanza la excepcion adecuada?
                Assert.IsInstanceOfType(exc, typeof(FechaInvalidaException));
            }
        }

        /*
         * Se comenta dado que al método que se testea se le modificó la visibilidad
         * de public a private, por lo tanto, ya no es accesible.
        [TestMethod]
        public void TestAgregarProducto()
        {
            // ARRANGE
            Orden o1 = new Orden(new DateTime(2025, 12, 12));
            Rueda r1 = new Rueda(26);

            // ACT
            o1.OrdenarMountainBike<Acero>(r1, r1, 40, false);

            // ASSERT
            // Se agregó la bicicleta correctamente? Es del tipo correcto?
            Assert.IsTrue(o1.ListadoBicicletas.Count > 0);
            Assert.IsInstanceOfType(o1.ListadoBicicletas[0], typeof(MountainBike<Acero>));
        }
        */

        [TestMethod]
        public void TestAgregarMultiplesProductos()
        {
            // ARRANGE
            Orden o1 = new Orden(new DateTime(2025, 12, 12));
            Rueda r1 = new Rueda(26);
            int cant = 10;

            // ACT
            o1.OrdenarBicicletasPlayeras<Acero>(cant, r1, r1, 40, false);

            // ASSERT
            // Se agregaron todas las bicicletas solicitadas?
            Assert.IsTrue(o1.ListadoBicicletas.Count == cant);
            for (int i = 0; i < cant; i++)
            {
                // Las bicicletas agregadas son del tipo correcto?
                Assert.IsInstanceOfType(o1.ListadoBicicletas[i], typeof(Playera<Acero>));
            }
        }

        [TestMethod]
        public void TestAgregarMultiplesAccesorios()
        {
            // ARRANGE
            Orden o1 = new Orden(new DateTime(2025, 12, 12));
            int cantCasco = 12;
            int cantLuz = 8;
            int contadorCasco = 0;
            int contadorLuz = 0;

            // ACT
            o1.OrdenarAccesorios(cantCasco, cantLuz, 12, "blanca");

            // ASSERT
            // Se agrego la cantidad correcta de cascos y de luces?
            for (int i = 0; i < cantCasco + cantLuz; i++)
            {
                if(o1.ListadoAccesorios[i].GetType() == typeof(Casco))
                {
                    contadorCasco++;
                }
                if(o1.ListadoAccesorios[i].GetType() == typeof(Luz))
                {
                    contadorLuz++;
                }
            }
            Assert.IsTrue(contadorCasco == cantCasco);
            Assert.IsTrue(contadorLuz == cantLuz);
        }
    }
}
