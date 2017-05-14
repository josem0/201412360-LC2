using _2014102360.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Persistance.EntitiesConfigurations
{
    public class ParabrisasConfiguration : EntityTypeConfiguration<Parabrisas>
    {
        public ParabrisasConfiguration()
        {
            //Table Configurations
            ToTable("Parabrisas");

            HasKey(a => a.ParabrisasId);

            //Relations Configurations
            //HasRequired(a => a.Carro)
               // .WithOptional(a => a.Parabrisas);

        }
    }
}
