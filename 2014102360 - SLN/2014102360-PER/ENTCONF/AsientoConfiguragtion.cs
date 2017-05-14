using _2014102360.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Persistance.EntitiesConfigurations
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {
        public AsientoConfiguration()
        {
            //Table Configurations
            ToTable("Asiento");

            HasKey(c => new {c.AsientoId, c.CarroId });

            //Relations Configurations
          //  HasRequired(a => a.Carro)
           //     .WithOptional(a => a.Asiento);

        }
    }
}