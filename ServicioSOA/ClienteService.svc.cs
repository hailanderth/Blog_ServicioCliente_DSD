﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioSOA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClienteService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClienteService.svc o ClienteService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClienteService : IClienteService
    {
        public List<ClienteEntidad> Buscar(ClienteEntidad entidad)
        {
            ClienteRepositorio oClienteRepositorio = new ClienteRepositorio();
            return oClienteRepositorio.Buscar(entidad);
        }

        public void DoWork()
        {
        }

        public bool Eliminar(ClienteEntidad entidad)
        {
            ClienteRepositorio oClienteRepositorio = new ClienteRepositorio();
            return oClienteRepositorio.Eliminar(entidad.Cod_Cliente);
        }

        public bool Modificar(ClienteEntidad entidad)
        {
            ClienteRepositorio oClienteRepositorio = new ClienteRepositorio();
            return oClienteRepositorio.Modificar(entidad);
        }

        public bool Registrar(ClienteEntidad entidad)
        {
            ClienteRepositorio oClienteRepositorio = new ClienteRepositorio();
            return oClienteRepositorio.Registrar(entidad);
        }
    }
}
