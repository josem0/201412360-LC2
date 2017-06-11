using _2014102360_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360_PER.EntitiesConfigurations
{
    public class VolanteConfiguration:EntityTypeConfiguration<Volante>
    {
        public VolanteConfiguration()
        {
            ToTable("Volantes");
            //Propiedades
            Property(c => c.NumSerie)
                .IsRequired()
                .HasMaxLength(10);
            Property(c => c.VolanteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Relaciones
            HasKey(c => c.VolanteId);
        }
    }
}
