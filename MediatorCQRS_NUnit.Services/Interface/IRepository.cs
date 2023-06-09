using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorCQRS_NUnit.Services.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetALL();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Save();
    }
}
