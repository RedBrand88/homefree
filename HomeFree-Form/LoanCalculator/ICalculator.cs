using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    interface ICalculator
    {
        int setMonths(int years);
        double setMonthlyInterest(double interestRate);
        void resetForm();
        void setVariables();
    }
}
