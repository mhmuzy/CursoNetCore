﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Validations.Commons
{
    public class MaiorDeIdadeValidation
    {
        public static bool IsValid(DateTime dataNascimento)
        {
            var idade = DateTime.Now.Year - dataNascimento.Year;

            //verificar não fez aniversário
            if (DateTime.Now.DayOfWeek < dataNascimento.DayOfWeek)
                idade = idade - 1;

            //testando..
            return idade >= 18;
        }
    }
}
