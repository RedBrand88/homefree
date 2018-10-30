using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class Loan : ILoan
    {
        const int MONTHS_IN_YEAR = 12;
        const int HUNDRED = 100;
        int months;
        double monthlyRate;

        /// <summary>
        /// converts years to months
        /// </summary>
        /// <param name="years"></param>
        /// <returns></returns>
        public int SetMonths(int years)
        {
            return years * MONTHS_IN_YEAR;
        }

        /// <summary>
        /// convert yearly interest to monthly interest
        /// </summary>
        /// <param name="rate"></param>
        /// <returns></returns>
        public double SetMonthlyInterest(double rate)
        {
            return rate / HUNDRED / MONTHS_IN_YEAR;
        }

        /// <summary>
        /// get mortgage payment
        /// </summary>
        /// <param name="loan"></param>
        /// <returns></returns>
        public double MonthlyPayment(LoanObjectModel loan)
        {
            double intermediate;

            months = SetMonths(loan.years);
            monthlyRate = SetMonthlyInterest(loan.rate);
            loan.principal -= loan.downPayment;
            monthlyRate += 1;
            intermediate = Math.Pow(monthlyRate, months);
            monthlyRate -= 1;
            loan.monthlyPayment = monthlyRate * intermediate;
            intermediate -= 1;
            loan.monthlyPayment /= intermediate;
            loan.monthlyPayment *= loan.principal;
            loan.monthlyPayment += loan.interest_Utilities;
            return loan.monthlyPayment;
        }
    }
}
