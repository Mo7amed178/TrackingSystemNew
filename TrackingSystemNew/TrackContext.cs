using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrackingSystemNew
{
    public class TrackContext :DbContext
    {
        public TrackContext() : base()
{
            Database.SetInitializer<TrackContext>(new DropCreateDatabaseAlways<TrackContext>());
        }

        public System.Data.Entity.DbSet<TrackingSystemNew.Models.Track> Tracks { get; set; }
        public System.Data.Entity.DbSet<TrackingSystemNew.Models.Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<TrackingSystemNew.Models.Shipment> Shipments { get; set; }
    }
}