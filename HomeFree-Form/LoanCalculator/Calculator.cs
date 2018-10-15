using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    public class Calculator : ICalculator
    {
        const int MONTHS_IN_YEAR = 12;
        const int CONVERT_PERCENT = 100;
        int months;
        double rate;
        ILoan loan;
        IHowMuchHouse howMuchHouse;
        ILoanPayOff loanPayOff;
        LoanObjectModel loanObj;

        public Calculator()
        {
            loan = new Loan();
            howMuchHouse = new HowMuchHouse();
            loanPayOff = new LoanPayOff();
            loanObj = new LoanObjectModel();
        }

        public int SetMonths(int years)
        {
            return years * MONTHS_IN_YEAR;
        }

        public double SetMonthlyInterest(double rate)
        {
            //test for order of operations
            return rate / 100 / MONTHS_IN_YEAR;
        }

        public double MonthlyPayment()
        {
            return loan.MonthlyPayment(loanObj);
        }

        public double HowMuchHouseCanIAfford()
        {
            return howMuchHouse.findHousePrice(profile);
        }

        public void SetLoanObject(double down, double principal, double yearlyRate, int years, double utilities)
        {
            loanObj.downPayment = down;
            loanObj.principal = principal;
            loanObj.rate = yearlyRate;
            loanObj.years = years;
            loanObj.interest_Utilities = utilities;
        }
    }
}
