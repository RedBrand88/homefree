using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class Calculator : ICalculator
    {
        const int MONTHS = 12;
        const int CONVERT_PERCENT = 100;
        int months;
        double rate;
        ILoan loan;
        IHowMuchHouse howMuchHouse;
        ILoanPayOff loanPayOff;
        //field that holds form here

        Calculator()
        {
            loan = new Loan();
            howMuchHouse = new HowMuchHouse();
            loanPayOff = new LoanPayOff();
        }

        public int setMonths(int years)
        {
            months = years * MONTHS;
            return months;
        }

        public double setMonthlyInterest(double percent)
        {
            rate = percent / CONVERT_PERCENT;
            rate /= MONTHS;
            return rate;
        }

        public void resetForm()
        {
            //refrence form and reset here
        }

        public void setVariables()
        {
            //set variables with user input
        }
    }
}
