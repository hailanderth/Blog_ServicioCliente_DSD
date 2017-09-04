using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioSOA
{
    public class ClienteEntidad
    {
        public int Cod_Cliente { get; set; }
        public string Nom_Cliente { get; set; }
        public string Ape_Cliente { get; set; }
        public string Dir_Cliente { get; set; }
        public string Tel_Cliente { get; set; }
        public string Sexo { get; set; }
        public short Edad { get; set; }
        public string Email { get; set; }

    }
}