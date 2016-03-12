using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Framework.Interfaces.Helper;

namespace Repository
{
    public class Repository<T> where T : class 
    {

        IDbSet<T> _dbSet;
        public Repository(IObjectContext dbContext)
        {
            _dbSet = dbContext.CreateObjectSet<T>();
        }


        public IEnumerable<T> GetLocal()
        {
            return _dbSet.Local;
        }
     
        public bool Any(Func<T, bool> predicate)
        {
            return _dbSet.Any(predicate);
        }


        public IEnumerable<T> Find(Func<T, bool> where)
        {
            return _dbSet.AsEnumerable().Where(where);
        }


        public IEnumerable<T> FindNoTracking(Func<T, bool> where)
        {
            return _dbSet.AsNoTracking().AsEnumerable().Where(where);
        }

        public IEnumerable<T> FindNoTracking(Func<T, bool> where, params string[] paths)
        {
            var objectQuery = _dbSet.AsNoTracking();

            if (objectQuery != null)
            {
                objectQuery = paths.Aggregate(objectQuery,
                          (current, include) => current.Include(include));
            }
            

            return objectQuery.AsEnumerable().Where(where);
        }

        public IEnumerable<T> Find(Func<T, bool> where, params string[] paths)
        {
            var objectQuery = _dbSet.AsQueryable();

            if (objectQuery != null)
            {
                objectQuery = paths.Aggregate(objectQuery,
                          (current, include) => current.Include(include));
            }
            return objectQuery.Where(where);
        }

        public T Single(Func<T, bool> where)
        {
            return _dbSet.AsQueryable().Single(where);
        }

        public T SingleOrDefault(Func<T, bool> predicate)
        {
            return _dbSet.AsQueryable().SingleOrDefault(predicate);
        }
        

        public T First(Func<T, bool> where)
        {
            return _dbSet.AsQueryable().First(where);
        }
        
        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return _dbSet.AsQueryable().FirstOrDefault(predicate);
        }


        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public void AddOrUpdate(T entity)
        {
            _dbSet.AddOrUpdate(entity);
        }

        public void Attach(T entity)
        {
            _dbSet.Attach(entity);
        }

        public void Add(IEnumerable<T> entities)
        {
            if (entities == null) return;
            entities.ToList().ForEach(Add);
        }
        public void AddOrUpdate(IEnumerable<T> entities)
        {
            if (entities == null) return;
            entities.ToList().ForEach(AddOrUpdate);
        }

        public void Delete(IEnumerable<T> entities)
        {
            if (entities == null) return;
            entities.ToList().ForEach(Delete);
        }


        public List<T2> MapTable<T2>(Expression<Func<T, bool>> where, List<T2> tablesToMap,
            Func<T2, object> keyLeft, Func<T, object> keyRight, Action<T2, T> result, Func<T2, bool> conditionMap = null, params string[] inCludePath)
        {
            var objectQuery = _dbSet.AsNoTracking().Where(where);

            if (objectQuery != null)
            {
                objectQuery = inCludePath.Aggregate(objectQuery,
                    (current, include) => current.Include(include));
            }

            if (keyLeft == null || keyRight == null || result == null) return tablesToMap;

            if (conditionMap == null)
            {
                conditionMap = arg => true;
            }

            var journalItems = tablesToMap.Where(conditionMap).Join(objectQuery.ToList(), keyLeft, keyRight, (s, d) =>
            {

                result(s, d);
                return s;
            }

                ).ToList();

            return journalItems;




        }

    }
}