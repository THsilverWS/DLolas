using System;
using System.Collections.Generic;

namespace Finalv67
{
    public class PedidoFirebase
    {
        public string Cliente { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string TipoEntrega { get; set; }
        public string MetodoPago { get; set; }
        public double Total { get; set; }
        public string EstadoPedido { get; set; }
        public string Fecha { get; set; }

        public string FechaEntrega { get; set; }

        public Dictionary<string, DetalleItemCarrito> productos { get; set; }

        public string NotaExtra { get; set; }
    }

    public class DetalleItemCarrito
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
    }
}