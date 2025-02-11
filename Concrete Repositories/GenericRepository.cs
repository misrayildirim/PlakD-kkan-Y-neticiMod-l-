using Microsoft.EntityFrameworkCore;
using PlakDükkanıYöneticiModülü.Abstract_Repositories;
using PlakDükkanıYöneticiModülü.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiModülü.Concrete_Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T :class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public void Add(T entity)
        {
           _entities.Add(entity);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            var entity = GetById(id);
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }

        public void Update(int id, T entity)
        {
            var entityToUpdate = GetById(id);
            _entities.Update(entityToUpdate);
            _context.SaveChanges();
        }
    }
}
