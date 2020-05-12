using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        [Display(Name = "Codigo Proveedor")]
        public int SupplierCode { get; set; }
        [Display(Name = "Nombre")]
        public string SupplierName { get; set; }
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }
        [Display(Name = "Telefono")]
        public string Phone { get; set; }
        [Display(Name = "Direccion")]
        public string Address { get; set; }
    }
}