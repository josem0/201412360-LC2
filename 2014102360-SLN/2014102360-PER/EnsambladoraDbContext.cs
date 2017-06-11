﻿using _2014102360_ENT;
using _2014102360_PER.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360_PER
{
    public class EnsambladoraDbContext:DbContext
    {
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cinturon> Cinturones { get; set; }
        public DbSet<Ensambladora> Ensambladoras { get; set; }
        public DbSet<Llanta> Llantas { get; set; }
        public DbSet<Parabrisas> Parabrisas { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Volante> Volantes { get; set; }
        public System.Data.Entity.DbSet<_2014102360_ENT.Bus> Carroes { get; set; }
        public System.Data.Entity.DbSet<_2014102360_ENT.Automovil> _Carroes { get; set; }

        public EnsambladoraDbContext() : base("Ensambladora")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EnsambladoraConfiguration());
            modelBuilder.Configurations.Add(new AsientoConfiguration());
            modelBuilder.Configurations.Add(new CinturonConfiguration());
            modelBuilder.Configurations.Add(new LlantaConfiguration());
            modelBuilder.Configurations.Add(new ParabrisasConfiguration());
            modelBuilder.Configurations.Add(new PropietarioConfiguration());
            modelBuilder.Configurations.Add(new VolanteConfiguration());
            modelBuilder.Configurations.Add(new CarroConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        
    }
}
