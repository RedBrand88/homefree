using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    interface ILoanPayOff
    {
        double calcInterest(LoanObjectModel loan);
        int CalcMonthsSaved(LoanObjectModel loan);
        double TotalAmountToBePaid(LoanObjectModel loan);
    }
}
