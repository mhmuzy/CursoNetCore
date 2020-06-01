using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FluentValidation;
using Projeto.Domain.Models;

namespace Projeto.Domain.Validations
{
    public class AlunoValidation : AbstractValidator<Aluno>
    {
        //construtor -> ctor + 2x [tab]
        public AlunoValidation()
        {
            RuleFor(a => a.Id)
                .NotEmpty().WithMessage("Id do aluno obrigatório.");

            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("Nome do aluno obrigatório.")
                .Length(6, 150).WithMessage("Nome deve ter de 6 a 150 caracteres.");

            RuleFor(a => a.Matricula)
                .NotEmpty().WithMessage("Matrícula do aluno obrigatório.")
                .Length(6, 20).WithMessage("Nome deve ter de 6 a 20 caracteres.");

            RuleFor(a => a.Cpf)
                .NotEmpty().WithMessage("CPF do aluno obrigatório.")
                .Length(11).WithMessage("CPF deve ter 11 caracteres.");

            RuleFor(a => a.DataNascimento)
                .NotEmpty().WithMessage("Data de Nascimento do aluno obrigatória.");
        }
    }
}
