﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Projeto.Domain.Models;
using System.Data;  

namespace Projeto.Domain.Validations
{
    public class ProfessorValidation : AbstractValidator<Professor>
    {
        //construtor -> ctor + 2x[tab]
        public ProfessorValidation()
        {
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("Id do Professor obrigatório.");

            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Nome do Professor obrigatório.")
                .Length(6, 150).WithMessage("Nome deve ter de 6 a 150 caracteres.");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Email do Professor obrigatório.")
                .EmailAddress().WithMessage("Endereço de email inválido.");
        }
    }
}
