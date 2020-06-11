using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Domain.Models;


namespace Projeto.Domain.Services
{
    public class AlunoDomainService
        : BaseDomainService<Aluno>, IAlunoDomainService
    {
        //atributo -> DIP (Principio de inversão de dependência)
        //private readonly IUnitOfWork unitOfWork;
        public AlunoDomainService(IBaseRepository<Aluno> repository) 
            : base(repository)
        {

        }

        public Aluno GetByCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Aluno GetByMatricula(string matricula)
        {
            throw new NotImplementedException();
        }
    }
}
