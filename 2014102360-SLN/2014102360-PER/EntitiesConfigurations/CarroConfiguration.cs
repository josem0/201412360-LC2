﻿using _2014102360_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360_PER.EntitiesConfigurations
{
    public class CarroConfiguration:EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
        {
            ToTable("Carros");

            HasKey(c => c.CarroId);
            //Propiedades
            Property(c => c.NumSerieChasis)
                .IsRequired()
                .IsMaxLength();
            Property(c => c.NumSerieMotor)
               .IsRequired()
               .HasMaxLength(10)
               .IsMaxLength();

            Map<Bus>(m => m.Requires("Discriminator").HasValue("Bus"));
            Map<Automovil>(m => m.Requires("Discriminator").HasValue("Automovil"));

            Property(c => c.CarroId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relaciones
            //HasRequired(c => c.Ensambladora)
            //    .WithMany(c => c.Carro)
            //    .HasForeignKey(c => c.Ensambladora);
        }
    }
}
