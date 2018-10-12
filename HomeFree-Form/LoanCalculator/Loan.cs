using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class Loan : ILoan
    {
        double payment;

        public double monthlyPayment(double principle, double rate, int months, double downPay, double extra)
        {
            principle -= downPay;
            payment = principle * (rate * Math.Pow((1 + rate), months) / Math.Pow((1 + rate), months) - 1);
            payment += extra;
            return payment;
        }
    }
}
