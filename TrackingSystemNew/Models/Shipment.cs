using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackingSystemNew.Models
{
    public class Shipment
    {
        [Key]
        public int ShipmentNo { get; set; }
        public string ShipmentStatus { get; set; }
    }
}