using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? FechaCanje { get; set; }
        public int? IdArticulo { get; set; }

        public Articulo Articulo { get; set; }
        public Cliente Cliente { get; set; }
    }
}