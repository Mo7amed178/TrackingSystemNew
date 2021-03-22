using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrackingSystemNew.Models;

namespace TrackingSystemNew.DAL
{
    public class TrackContaxt : DbContext
    {
        public TrackContaxt() : base("TrackDB")
        {

            Database.SetInitializer<TrackContaxt>(new DropCreateDatabaseIfModelChanges<TrackContaxt>());
        }
    }
}
