using System.Collections.Generic;

namespace FlexFitnessCenter.DataAccess
{
    public interface IDataAccess
    {
        IEnumerable<T> Select<T>();
    }
}