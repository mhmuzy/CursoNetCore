using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Interfaces.Repositories;
using System.Linq;

namespace Projeto.Domain.Services
{
    public abstract class BaseDomainService<TEntity>
                    : IBaseDomainService<TEntity>
        where TEntity : class
    {
        //atributo-> DIP (Principio de Inversão de Dependência)
        private readonly IBaseRepository<TEntity> repository;

        //construtor para injeção de dependência
        protected BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public List<TEntity> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return repository.GetById(id);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
