﻿using _2014102360_ENT;
using _2014102360_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2014102360_PER.Repositories
{
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {
        public CarroRepository(EnsambladoraDbContext context) : base(context)
        {
        }
    }
}
