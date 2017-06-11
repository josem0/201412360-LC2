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
    class EnsambladoraConfiguration:EntityTypeConfiguration<Ensambladora>
    {
        public EnsambladoraConfiguration()
        {
            ToTable("Ensambladora");

            HasKey(c => c.EnsambladoraId);
            Property(c => c.EnsambladoraId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
