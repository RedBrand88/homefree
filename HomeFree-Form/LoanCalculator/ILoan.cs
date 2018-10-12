using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    interface ILoan
    {
        double monthlyPayment(double p, double r, int m, double dp, double ex);
    }
}
