using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito : DocumentoComercial
    {
        public DateTime FechaEntrega { get; set; }

        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, DateTime fechaEntrega, decimal total) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }

        public Remito() : base() { }

    }
}
