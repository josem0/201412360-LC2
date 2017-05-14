using _2014102360.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Persistance.EntitiesConfigurations
{
    public class LlantaConfiguration : EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            //Table Configurations
            ToTable("Llanta");

            HasKey(c => new {c.LlantaId, c.CarroId });

            //Relations Configurations
         //   HasRequired(a => a.Carro)
          //      .WithOptional(a => a.Llanta);

        }
    }
}
