using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS1_U3_Eventos.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime? Fecha { get; set; }
        public int Quota { get; set; }
        public string Availability { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}