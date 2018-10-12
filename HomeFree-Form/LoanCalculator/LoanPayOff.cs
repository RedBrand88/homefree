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

        public double calcInterest(double payment, int months, double principle)
        {
            interest = payment * months - principle;
            return interest;
        }
    }
}
