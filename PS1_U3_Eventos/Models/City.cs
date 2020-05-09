using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS1_U3_Eventos.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityDescription { get; set; }
        public int Population { get; set; }
        public int Lada { get; set; }
    }
}