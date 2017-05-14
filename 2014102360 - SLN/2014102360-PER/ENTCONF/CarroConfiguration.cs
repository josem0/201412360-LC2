using _2014102360.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Persistance.EntitiesConfigurations
{
    public class CarroConfiguration : EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
        {
            //Table Configurations
            ToTable("Carro");

            HasKey(c => new {c.CarroId, c.EnsambladoraId });

            //Relations Configurations
            HasRequired(a => a.Ensambladora)
                .WithOptional(a => a.Carro);

        }
    }
}
