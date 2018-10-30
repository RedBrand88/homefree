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

        /// <summary>
        /// convert yearly interest to monthly interest
        /// </summary>
        /// <param name="loan"></param>
        /// <returns></returns>
        public double calcInterest(LoanObjectModel loan)
        {
            interest = loan.monthlyPayment * loan.years - loan.principal;
            return interest;
        }
    }
}
