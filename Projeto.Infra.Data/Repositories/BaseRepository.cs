﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Infra.Data.Context;
using System.Linq;

namespace Projeto.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        //DIP -> Principio de inversão de dependência
        protected readonly SqlContext context;
        protected readonly DbSet<TEntity> dbSet;

        //Injeção de dependência
        public BaseRepository(SqlContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            dbSet.Add(obj);
            context.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            dbSet.Update(obj);
            context.SaveChanges();
        }

        public virtual void Remove(TEntity obj)
        {
            dbSet.Remove(obj);
            context.SaveChanges();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }

        public virtual TEntity GetById(Guid id)
        {
            return dbSet.Find(id);
        }

        public virtual void Dispose()
        {
            context.Dispose();
        }
    }
}
