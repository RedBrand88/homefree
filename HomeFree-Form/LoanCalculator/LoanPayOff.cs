using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class LoanPayOff : ILoanPayOff
    {
        double interest;

        public double calcInterest(LoanObjectModel loan)
        {
            interest = loan.monthlyPayment * loan.years - loan.principal;
            return interest;
        }
    }
}
