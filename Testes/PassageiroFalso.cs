using Bogus;
using PROVA_DE_SUFICIENCIA.Entities;
using System;

namespace Testes
{
    public class PassageiroFalso : Faker<Passageiro>
    {
        /// <summary>
        /// Kauê Felipe Salvio
        /// </summary>
        public PassageiroFalso()
        {
            RuleFor(p => p.Nome, f => f.Person.FullName);
            RuleFor(p => p.Telefone, f => f.Person.Phone);
            RuleFor(p => p.Idade, new Random().Next(1, 100));
            RuleFor(p => p.TarifaInteira, 6);
        }
    }
}
