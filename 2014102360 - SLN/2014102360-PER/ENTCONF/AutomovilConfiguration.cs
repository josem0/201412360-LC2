using _2014102360.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Persistance.EntitiesConfigurations
{
    public class AutomovilConfiguration : EntityTypeConfiguration<Automovil>
    {
        public AutomovilConfiguration()
        {
            //Table Configurations
            ToTable("Automovil");

            HasKey(c => c.CarroId);

         }
    }
}
