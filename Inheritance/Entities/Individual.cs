using System;
using Inheritance.Entities;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities
{
    class Individual : TaxPayer
    {
        public double HelthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double helthExpenditures)
            : base(name, anualIncome)
        {
            HelthExpenditures = helthExpenditures;
        }
        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HelthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HelthExpenditures * 0.5;
            }
        }

    }
}
