using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoanCalculator;

namespace HomeFree_Form
{
    public partial class Form1 : Form
    {
        private string yearlySalary;
        private string yearlyBonuses;
        private string monthlyBudet;
        private string plannedDownPayment;
        private string assumedCreditScore;
        private double targetPrice;
        private Calculator myCalculator;

        /// <summary>
        /// form constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            myCalculator = new Calculator();
        }

        /// <summary>
        /// Calls calculator to set monthly payment amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitMonthlyPayment_Click(object sender, EventArgs e)
        {
            double down, princ, rate, insurance;
            int years;

            Double.TryParse(downPayment.Text, out down);
            Double.TryParse(principal.Text, out princ);
            Double.TryParse(interestRate.Text, out rate);
            int.TryParse(yearsToPay.Text, out years);
            Double.TryParse(insuranceUtilities.Text, out insurance);

            myCalculator.SetLoanObject(down, princ, rate, years, insurance);

            monthlyPayment.Text = myCalculator.MonthlyPayment().ToString("0.##");
        }


        /// <summary>
        /// calculates target home price based on income + bonuses or a target monthly budget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitTargetPrice_Click(object sender, EventArgs e)
        {
            //math assumes interest rate of 5% yearly on a 30 year loan
            //this is based on a 25% of your yearly income rule
            yearlySalary = salary.Text;
            yearlyBonuses = bonuses.Text;
            plannedDownPayment = preparedDownPayment.Text;
            monthlyBudet = budget.Text;
            assumedCreditScore = creditScore.Text;

            double _yearlySalary;
            double _yearlyBonuses;
            double _plannedDownPayment;
            double _monthlyBudget;
            int _assumedCreditScore;

            Double.TryParse(yearlySalary, out _yearlySalary);
            Double.TryParse(yearlyBonuses, out _yearlyBonuses);
            Double.TryParse(plannedDownPayment, out _plannedDownPayment);
            Double.TryParse(monthlyBudet, out _monthlyBudget);
            int.TryParse(assumedCreditScore, out _assumedCreditScore);

            //based on the first half of the monthly mortgage equation
            double fivePercentInterestAndThirtyYears = 0.0053682162301213979;

            if (salary.Text != "")
            {
                if (bonuses.Text != "")
                {
                    _yearlySalary += _yearlyBonuses;
                }

                _yearlySalary = _yearlySalary * .25 / 12;

                targetPrice = _yearlySalary / fivePercentInterestAndThirtyYears;
            }
            else
            {
                targetPrice = _monthlyBudget / fivePercentInterestAndThirtyYears;

                if(preparedDownPayment.Text != "")
                {
                    targetPrice += _plannedDownPayment;
                }
            }

            targetHousePrice.Text = targetPrice.ToString("0.##");
            resetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plannedMonthlyPayment = payment.Text;
            string totalPayments = yearsToPayBack.Text;
            string totalPrinciple = loanSize.Text;

            double _totalMoneyPaid;
            double _plannedMonthlyPayment;
            int _totalPayments;
            double _totalInterestPaid;
            double _totalPrinciple;

            Double.TryParse(plannedMonthlyPayment, out _plannedMonthlyPayment);
            int.TryParse(totalPayments, out _totalPayments);
            Double.TryParse(totalPrinciple, out _totalPrinciple);

            if(yearsToPayBack.Text != "")
            {
                //_totalPayments = setMonths(_totalPayments);
            }

            _totalMoneyPaid = _plannedMonthlyPayment * _totalPayments;
            _totalInterestPaid = _totalMoneyPaid - _totalPrinciple;

            totalInterestPaid.Text = _totalInterestPaid.ToString("0.##");
            totalMoneyPaid.Text = _totalMoneyPaid.ToString("0.##");
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {
            budget.Enabled = false;
        }

        private void bonuses_TextChanged(object sender, EventArgs e)
        {
            budget.Enabled = false;
        }

        private void budget_TextChanged(object sender, EventArgs e)
        {
            salary.Enabled = false;
            bonuses.Enabled = false;
        }

        /// <summary>
        /// resets the target house price form when
        /// submited
        /// </summary>
        public void resetForm()
        {
            salary.Text = "";
            bonuses.Text = "";
            budget.Text = "";
            preparedDownPayment.Text = "";
            creditScore.Text = "";
            budget.Enabled = true;
            bonuses.Enabled = true;
            salary.Enabled = true;
        }

    }
}
