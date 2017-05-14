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
    public class AsientoRepository : Repository<Asiento>, IAsientoRepository
    {
        private readonly _2014102360DbContext _Context;

        public AsientoRepository(_2014102360DbContext context)
        {
            _Context = context;
        }
        public AsientoRepository() : base()
        {

        }
        void IRepository<Asiento>.Add(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.AddRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Asiento> IRepository<Asiento>.Find(Expression<Func<Asiento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Asiento IRepository<Asiento>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Asiento> IRepository<Asiento>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.Remove(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.RemoveRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.Update(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.UpdateRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }
    }
}
