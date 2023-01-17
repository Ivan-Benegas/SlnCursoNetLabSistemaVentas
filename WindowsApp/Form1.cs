using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Producto producto = new Producto(
                "Celular Samsung Z100.",
                "Último modelo sacado por la empresa Samsung.",
                1000,
                0.3,
                0.21,
                "Samsung",
                "Celulares",
                "Smartphones");

            Empresa empresaProveedor = new Empresa(
                "Samsung",
                "1-11111111-11",
                "@SamsungOficial",
                "samsung@gmail.com",
                "111-1111-111111111",
                "Avenida Hola 123");

            ClienteIndividuo clienteIndividuo = new ClienteIndividuo(
                "Pedro",
                "González",
                "2-22222222-22",
                "pedrogonzalez@gmail.com",
                "222-2222-222222222",
                "Avenida Saludo 123");

            Empresa empresaCliente = new Empresa(
                "Pecsi",
                "3-33333333-33",
                "@PecsiOficial",
                "pecsi@gmail.com",
                "333-3333-333333333",
                "Avenida Pecsi 123");

            Vendedor vendedor = new Vendedor(
                "Juan",
                "Pérez",
                "44444444",
                "juanperez@gmail.com",
                "444-4444-444444444",
                "Avenida Chau 123");

            Factura factura = new Factura(
                "A",
                "55555",
                new DateTime(2023, 01, 09),
                "Pecsi",
                "Avenida Hola 123",
                "Si",
                "Si",
                "Compra de un celular Samsung Z100",
                1573);

            Remito remito = new Remito(
                "66666",
                new DateTime(2023, 01, 09),
                "Pecsi",
                "Avenida Hola 123",
                "Si",
                "Si",
                "Compra de un celular Samsung Z100",
                new DateTime(2023, 01, 11),
                1573);

            labelProducto.Text =
                "El nombre del producto es " + producto.Nombre + "\n" +
                "La descripción es " + producto.Descripcion + "\n" +
                "El precio de costo es " + producto.PrecioCosto + "\n" +
                "El margen de ganancia es " + producto.Margen + "\n" +
                "El valor de IVA es " + producto.IVA + "\n" +
                "El precio bruto es " + producto.PrecioBruto + "\n" +
                "El precio de venta es " + producto.PrecioVenta + "\n" +
                "El proveedor es " + producto.Proveedor + "\n" +
                "La categoría a la que pertence el producto es " + producto.Categoria + "\n" +
                "La subcategoría a la que pertenece es " + producto.SubCategoria;

            labelProveedor.Text = 
                "El nombre de la empresa proveedora es " + empresaProveedor.Nombre + "\n" +
                "El CUIT es " + empresaProveedor.CUIT + "\n" +
                "El contacto es " + empresaProveedor.Contacto + "\n" +
                "El email es " + empresaProveedor.Email + "\n" +
                "El teléfono es " + empresaProveedor.Telefono + "\n" +
                "La dirección es " + empresaProveedor.Direccion;

            labelClienteIndividuo.Text =
                "El nombre del cliente es " + clienteIndividuo.Nombre + "\n" +
                "El apellido es " + clienteIndividuo.Apellido + "\n" +
                "El CUIT es " + clienteIndividuo.CUIT + "\n" +
                "El email es " + clienteIndividuo.Email + "\n" +
                "El teléfono es " + clienteIndividuo.Telefono + "\n" +
                "La dirección es " + clienteIndividuo.Direccion;

            labelClienteEmpresa.Text = 
                "El nombre de la empresa cliente es " + empresaCliente.Nombre + "\n" +
                "El CUIT es " + empresaCliente.CUIT + "\n" +
                "El contacto es " + empresaCliente.Contacto + "\n" +
                "El email es " + empresaCliente.Email + "\n" +
                "El teléfono es " + empresaCliente.Telefono + "\n" +
                "La dirección es " + empresaCliente.Direccion;


            labelVendedor.Text = 
                "El nombre del vendedor es " + vendedor.Nombre + "\n" +
                "El apellido es " + vendedor.Apellido + "\n" +
                "El DNI es " + vendedor.DNI + "\n" +
                "El email es " + vendedor.Email + "\n" +
                "El teléfono es " + vendedor.Telefono + "\n" +
                "La dirección es " + vendedor.Direccion;


            labelFactura.Text =
                "El tipo de la factura es " + factura.Tipo + "\n" +
                "El número es " + factura.Numero + "\n" +
                "La fecha es " + factura.Fecha + "\n" +
                "El cliente es " + factura.Cliente + "\n" +
                "La dirección es " + factura.Direccion + "\n" +
                "La condición de IVA es " + factura.CondicionIVA + "\n" +
                "El condición de venta es " + factura.CondicionVenta + "\n" +
                "El detalle es " + factura.Detalle + "\n" +
                "El total es " + factura.Total;


            labelRemito.Text = 
                "El número del remito es " + remito.Numero + "\n" +
                "La fecha es " + remito.Fecha + "\n" +
                "El cliente es " + remito.Cliente + "\n" +
                "La dirección es " + remito.Direccion + "\n" +
                "La condición de IVA es " + remito.CondicionIVA + "\n" +
                "El condición de venta es " + remito.CondicionVenta + "\n" +
                "El detalle es " + remito.Detalle + "\n" +
                "La fecha de entrega es " + remito.FechaEntrega + "\n" +
                "El total es " + remito.Total;

        }
    }
}
