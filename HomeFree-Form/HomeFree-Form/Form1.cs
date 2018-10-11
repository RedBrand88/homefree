using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFree_Form
{
    public partial class Form1 : Form
    {
        private string yearsInMonths;
        private string monthlyInterestRate;
        private string initialLoan;
        private string moneyDown;
        private string insuranceUtiliesExtra;
        private double mortgagePayment;

        private string yearlySalary;
        private string yearlyBonuses;
        private string monthlyBudet;
        private string plannedDownPayment;
        private string assumedCreditScore;
        private double targetPrice;

        /// <summary>
        /// form constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// converts years into months
        /// </summary>
        /// <param name="years"></param>
        /// <returns>int</returns>
        public int setMonths(int years)
        {
            const int MONTHSINAYEAR = 12;
            return years * MONTHSINAYEAR;
        }

        /// <summary>
        /// converts yearly percent to a monthly percent
        /// </summary>
        /// <param name="interestRate"></param>
        /// <returns>double</returns>
        public double setMonthlyInterest(double interestRate)
        {
            const int MONTHSINAYEAR = 12;
            const int PERCENT = 100;
            return (interestRate / PERCENT) / MONTHSINAYEAR;
        }

        /// <summary>
        /// calculates a monthly payment for a given loan amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitMonthlyPayment_Click(object sender, EventArgs e)
        {
            monthlyInterestRate = interestRate.Text;
            yearsInMonths = yearsToPay.Text;
            moneyDown = downPayment.Text;
            insuranceUtiliesExtra = insuranceUtilities.Text;
            initialLoan = principal.Text;

            double _monthlyInterestRate = Double.Parse(monthlyInterestRate);
            int _yearsInMonths = int.Parse(yearsInMonths);
            double _initialLoan = Double.Parse(initialLoan);
            double placeholder;
            double interestPlusOne;

            _monthlyInterestRate = setMonthlyInterest(_monthlyInterestRate);
            _yearsInMonths = setMonths(_yearsInMonths);

            interestPlusOne = 1 + _monthlyInterestRate;
            interestPlusOne = Math.Pow(interestPlusOne, _yearsInMonths);
            placeholder = interestPlusOne * _monthlyInterestRate;
            placeholder = placeholder / (interestPlusOne - 1);

            if (downPayment.Text != "")
            {
                _initialLoan -= Double.Parse(downPayment.Text);
            }

            mortgagePayment = _initialLoan * placeholder;

            if (insuranceUtilities.Text != "")
            {
                mortgagePayment += Double.Parse(insuranceUtilities.Text);
            }

            monthlyPayment.Text = mortgagePayment.ToString("0.##");
        }

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
            }

            targetHousePrice.Text = targetPrice.ToString("0.##");
            resetForm();
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
    }
}
