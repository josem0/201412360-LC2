using _2014102360.Entities;
using _2014102360.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Persistence.Repositories
{
    public class AutomovilRepository : Repository<Automovil>, IAutomovilRepository
    {
        private readonly _2014102360DbContext _Context;

        public AutomovilRepository(_2014102360DbContext context)
        {
            _Context = context;
        }
        public AutomovilRepository() : base()
        {

        }
        void IRepository<Automovil>.Add(Automovil entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.AddRange(IEnumerable<Automovil> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Automovil> IRepository<Automovil>.Find(Expression<Func<Automovil, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Automovil IRepository<Automovil>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Automovil> IRepository<Automovil>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.Remove(Automovil entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.RemoveRange(IEnumerable<Automovil> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.Update(Automovil entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.UpdateRange(IEnumerable<Automovil> entities)
        {
            throw new NotImplementedException();
        }
    }
}
