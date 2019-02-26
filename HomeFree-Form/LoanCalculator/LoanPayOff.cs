using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator {
    class LoanPayOff : ILoanPayOff {
        double moneySaved = 0.00;
        int monthsSaved = 0;

        /// <summary>
        /// convert yearly interest to monthly interest
        /// </summary>
        /// <param name="loan"></param>
        /// <returns></returns>
        public double calcInterest(LoanObjectModel loan) {
            double interest = 0;
            int months = loan.years;
            double principal = loan.principal;
            double monthRate = loan.rate;
            double payment = loan.monthlyPayment;
            double principalPayment = 0;
            double interestPayment = 0;
            double extra = loan.extraPayment;

            if (loan.extraPayment > 0) {

                for (int i = 0; i < months; i++) {
                    interestPayment = principal * monthRate;
                    principalPayment = payment - interestPayment;
                    principalPayment += extra;
                    principal -= principalPayment;
                    interest += interestPayment;

                    if (principal < payment) {
                        interest += principal * monthRate;
                        break;
                    }
                }
            }
            else {

                interest = loan.monthlyPayment * loan.years - loan.principal;
            }

            return interest;
        }

        public int CalcMonthsSaved(LoanObjectModel loan) {
            int monthsRemaining = loan.years;
            int months = loan.years;
            double principal = loan.principal;
            double monthRate = loan.rate;
            double payment = loan.monthlyPayment;
            double principalPayment = 0;
            double interestPayment = 0;
            double extra = loan.extraPayment;

            for (int i = 0; i < months; i++) {
                interestPayment = principal * monthRate;
                principalPayment = payment - interestPayment;
                principalPayment += extra;
                principal -= principalPayment;
                monthsRemaining--;

                if (principal < 0) {
                    break;
                }
            }
            monthsSaved = monthsRemaining;

            return monthsRemaining;
        }

        public double TotalAmountToBePaid(LoanObjectModel loan) {

            moneySaved = monthsSaved * loan.monthlyPayment;
            return moneySaved;
        }
    }
}
