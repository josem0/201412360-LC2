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
    public class ParabrisasRepository : Repository<Parabrisas>, IParabrisasRepository
    {
        private readonly _2014102360DbContext _Context;

        public ParabrisasRepository(_2014102360DbContext context)
        {
            _Context = context;
        }
        public ParabrisasRepository() : base()
        {

        }
        void IRepository<Parabrisas>.Add(Parabrisas entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.AddRange(IEnumerable<Parabrisas> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Parabrisas> IRepository<Parabrisas>.Find(Expression<Func<Parabrisas, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Parabrisas IRepository<Parabrisas>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Parabrisas> IRepository<Parabrisas>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.Remove(Parabrisas entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.RemoveRange(IEnumerable<Parabrisas> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.Update(Parabrisas entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.UpdateRange(IEnumerable<Parabrisas> entities)
        {
            throw new NotImplementedException();
        }
    }
}
