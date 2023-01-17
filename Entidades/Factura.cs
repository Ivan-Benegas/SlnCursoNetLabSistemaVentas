using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        public string Tipo { get; set; }

        public Factura(string tipo, string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }

        public Factura() : base() { }

    }
}
