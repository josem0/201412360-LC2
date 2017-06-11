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
    public class PropietarioConfiguration:EntityTypeConfiguration<Propietario>
    {
        public PropietarioConfiguration()
        {
            ToTable("Propietarios");
            
            HasKey(c => c.PropietarioId);
            //Propiedades
            Property(c => c.PropietarioId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.DNI)
                .IsRequired()
                .HasMaxLength(8);
            Property(c => c.LicenciaConducir)
                .IsRequired()
                .HasMaxLength(9);


        }
    }
}
