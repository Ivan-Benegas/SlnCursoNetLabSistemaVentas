using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public string CUIT { get; set; }

        public ClienteIndividuo(string nombre, string apellido, string cuit, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            CUIT = cuit;
        }

        public ClienteIndividuo() : base() { }

    }
}
