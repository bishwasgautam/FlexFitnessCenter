using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FlexFitnessCenter.Entities.Abstract;

namespace FlexFitnessCenter.DataAccess
{
    public class GenericRepository<T>:IRepository<T> where T: Identifiable, new() 
    {
        private readonly IDataAccess _ds;


        public GenericRepository(IDataAccess ds)
        {
            _ds = ds;
        }

        public IEnumerable<T> GetAll()
        {
           return  _ds.Select<T>();
        }

        //TODO : View How to lazy loading
        public IEnumerable<T> GetByIdWith(int id, Expression<Func<T, bool>> query)
        {
            throw new NotImplementedException("OOps");
        }

        public T GetById(int id)
        {
            return this.GetAll().FirstOrDefault(x=> x.Id == id);
        }

    }
}
