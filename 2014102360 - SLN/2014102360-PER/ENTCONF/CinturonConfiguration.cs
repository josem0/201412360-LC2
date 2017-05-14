using _2014102360.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Persistance.EntitiesConfigurations
{
    public class CinturonConfiguration : EntityTypeConfiguration<Cinturon>
    {
        public CinturonConfiguration()
        {
            //Table Configurations
            ToTable("Cinturon");

            HasKey(c => new {c.CinturonId });

            //Relations Configurations
           // HasRequired(a => a.Asiento)
              //  .WithOptional(a => a.Cinturon);

        }
    }
}
