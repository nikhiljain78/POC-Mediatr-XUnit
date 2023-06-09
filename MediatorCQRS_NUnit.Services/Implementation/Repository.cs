using MediatorCQRS_NUnit.Data;
using MediatorCQRS_NUnit.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorCQRS_NUnit.Services.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        private DbSet<T> entities;
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            entities.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetALL()
        {
            return entities.ToList();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
