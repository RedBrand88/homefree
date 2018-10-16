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
        ProfileModel profile;
        //loan object factory? Maybe an array that can contain
        //all of the loan objects created so user can have a 
        //back function?
        LoanObjectModel loanObj;
        LoanObjectModel loanObj1;

        public Calculator()
        {
            loan = new Loan();
            howMuchHouse = new HowMuchHouse();
            loanPayOff = new LoanPayOff();
            loanObj = new LoanObjectModel();
            loanObj1 = new LoanObjectModel();
            profile = new ProfileModel();
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

        public double TotalMoneySpentOnLoan()
        {
            loanObj.years = SetMonths(loanObj.years);
            loanObj.rate = SetMonthlyInterest(loanObj.rate);
            return loanPayOff.calcInterest(loanObj);
        }

        public void SetLoanObject(double down, double principal, double yearlyRate, int years, double utilities)
        {
            loanObj.downPayment = down;
            loanObj.principal = principal;
            loanObj.rate = yearlyRate;
            loanObj.years = years;
            loanObj.interest_Utilities = utilities;
        }

        public void SetLoanObject(double principal, double yearlyRate, int years, double extra, double monthly)
        {
            loanObj.principal = principal;
            loanObj.rate = yearlyRate;
            loanObj.years = years;
            loanObj.extraPayment = extra;
            loanObj.monthlyPayment = monthly;
        }

        public void SetProfileObject(double income, double bonus, double budget, double down, int credit)
        {
            profile.yearlyIncome = income;
            profile.yearlyBonus = bonus;
            profile.monthlyBudget = budget;
            profile.availableDownPayment = down;
            profile.creditScore = credit;
        }
    }
}
