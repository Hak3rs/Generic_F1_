using Generic_F1.Team;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_F1.Repository
{
    public class SqlRepo<TSqlRepo> : IRepo<TSqlRepo> where TSqlRepo : class, IPerson, new()
    {
        private readonly DbSet<TSqlRepo> dbSet;
        private readonly DbContext dbContext;

        public SqlRepo(DbContext dbContext)
        {
            this.dbSet = dbContext.Set<TSqlRepo>();
            this.dbContext = dbContext;
        }

        public void Add(TSqlRepo recer)
        {
            dbSet.Add(recer);
        }

        public IEnumerable<TSqlRepo> GetAll()
        {
            return dbSet.OrderBy(recer => recer.Id).ToList();
        }

        public TSqlRepo GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Remove(TSqlRepo recer)
        {
            dbSet.Remove(recer);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
