using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Projeto.Domain.Models;

namespace Projeto.Domain.Models
{
    public class TurmaValidation : AbstractValidator<Turma>   
    {
        public TurmaValidation()
        {

        }
    }
}
