using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Models;

namespace Projeto.Domain.Interfaces.Repositories
{
    public interface IAlunoRepository
    {
        Aluno GetByMatricula(string matricula);
        Aluno GetByCpf(string cpf);
    }
}
