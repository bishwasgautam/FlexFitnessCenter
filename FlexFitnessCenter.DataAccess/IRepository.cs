using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FlexFitnessCenter.DataAccess
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByIdWith(int id, Expression<Func<T, bool>> query);
        T GetById(int id);


    }
}