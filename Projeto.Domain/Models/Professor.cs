using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Models
{
    public class Professor
    {
        //prop + 2x[tab]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        //ctor + 2x[tab]
        public Professor()
        {

        }

        public Professor(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        #region Turmas

        public List<Turma> Turmas { get; set; }

        #endregion
    }
}
