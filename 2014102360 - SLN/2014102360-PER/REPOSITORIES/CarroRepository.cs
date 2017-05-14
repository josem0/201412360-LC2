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
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {
        private readonly _2014102360DbContext _Context;

        public CarroRepository(_2014102360DbContext context)
        {
            _Context = context;
        }
        public CarroRepository() : base()
        {

        }
        void IRepository<Carro>.Add(Carro entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.AddRange(IEnumerable<Carro> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Carro> IRepository<Carro>.Find(Expression<Func<Carro, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Carro IRepository<Carro>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Carro> IRepository<Carro>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.Remove(Carro entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.RemoveRange(IEnumerable<Carro> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.Update(Carro entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.UpdateRange(IEnumerable<Carro> entities)
        {
            throw new NotImplementedException();
        }
    }
}
