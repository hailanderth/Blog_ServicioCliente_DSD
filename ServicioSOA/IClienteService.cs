using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioSOA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClienteService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        bool Registrar(ClienteEntidad entidad);

        [OperationContract]
        bool Modificar(ClienteEntidad entidad);

        [OperationContract]
        bool Eliminar(ClienteEntidad entidad);

        [OperationContract]
        List<ClienteEntidad> Buscar(ClienteEntidad entidad);


    }
}
