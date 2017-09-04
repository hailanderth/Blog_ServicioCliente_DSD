using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOATest
{
    [TestClass]
    public class ClienteTest
    {


        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestRegistrar()
        {
            //Declaramos el Proxy
            ProxyCliente.ClienteServiceClient proxy = new ProxyCliente.ClienteServiceClient();

            //Declaramos la entidad con los datos a registrar
            ProxyCliente.ClienteEntidad oClienteEntidad = new ProxyCliente.ClienteEntidad();
            oClienteEntidad.Nom_Cliente = "Williams";
            oClienteEntidad.Ape_Cliente = "Morales Caballero";
            oClienteEntidad.Dir_Cliente = "Av. Sol 785";
            oClienteEntidad.Tel_Cliente = "9517532";
            oClienteEntidad.Sexo = "M";
            oClienteEntidad.Edad = 32;
            oClienteEntidad.Email = "williams.morales@gmail.com";

            //Recibir resultado
            var resultado = proxy.Registrar(oClienteEntidad);

            //Comparar valor de resultado con valor esperado
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestModificar()
        {
            //Declaramos el Proxy
            ProxyCliente.ClienteServiceClient proxy = new ProxyCliente.ClienteServiceClient();

            //Declaramos la entidad con los datos a registrar
            ProxyCliente.ClienteEntidad oClienteEntidad = new ProxyCliente.ClienteEntidad();
            oClienteEntidad.Cod_Cliente = 1;
            oClienteEntidad.Nom_Cliente = "Marciano";
            oClienteEntidad.Ape_Cliente = "Morales Vidal";
            oClienteEntidad.Dir_Cliente = "Av. Sol 785";
            oClienteEntidad.Tel_Cliente = "9517532";
            oClienteEntidad.Sexo = "M";
            oClienteEntidad.Edad = 62;
            oClienteEntidad.Email = "marciano.morales@gmail.com";

            //Recibir resultado
            var resultado = proxy.Modificar(oClienteEntidad);

            //Comparar valor de resultado con valor esperado
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestEliminar()
        {
            //Declaramos el Proxy
            ProxyCliente.ClienteServiceClient proxy = new ProxyCliente.ClienteServiceClient();

            //Declaramos la entidad con los datos a registrar
            ProxyCliente.ClienteEntidad oClienteEntidad = new ProxyCliente.ClienteEntidad();
            oClienteEntidad.Cod_Cliente = 1;

            //Recibir resultado
            var resultado = proxy.Eliminar(oClienteEntidad);

            //Comparar valor de resultado con valor esperado
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestBuscar()
        {
            //Declaramos el Proxy
            ProxyCliente.ClienteServiceClient proxy = new ProxyCliente.ClienteServiceClient();

            //Declaramos la entidad con los datos a registrar
            ProxyCliente.ClienteEntidad oClienteEntidad = new ProxyCliente.ClienteEntidad();
            oClienteEntidad.Nom_Cliente = "Marciano";
            oClienteEntidad.Ape_Cliente = "Morales Vidal";

            //Recibir resultado
            var resultado = proxy.Buscar(oClienteEntidad);

            //Comparar valor de resultado con valor esperado
            Assert.AreEqual(1, resultado.Length);
        }



    }
}
