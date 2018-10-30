using System;
using System.Windows.Forms;
using LoanCalculator;

namespace HomeFree_Form
{
    public partial class Form1 : Form
    {
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
            double income, bonus, budget1, down;
            int credit;

            Double.TryParse(salary.Text, out income);
            Double.TryParse(bonuses.Text, out bonus);
            Double.TryParse(budget.Text, out budget1);
            Double.TryParse(preparedDownPayment.Text, out down);
            int.TryParse(creditScore.Text, out credit);

            myCalculator.SetProfileObject(income, bonus, budget1, down, credit);

            targetHousePrice.Text = myCalculator.HowMuchHouseCanIAfford().ToString("0.##");
            resetForm();
        }
        
        /// <summary>
        /// Calculates Total interest paid over the life of the loan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitTotalPayoff_Click(object sender, EventArgs e)
        {
            double princ, rate, extra, monthly;
            int years;

            //make SetLoanObject method that can set monthly payment
            Double.TryParse(loanSize.Text, out princ);
            Double.TryParse(rate1.Text, out rate);
            int.TryParse(yearsToPayBack.Text, out years);
            Double.TryParse(extraPayment.Text, out extra);
            Double.TryParse(payment.Text, out monthly);

            myCalculator.SetLoanObject(princ, rate, years, extra, monthly);

            totalInterestPaid.Text = myCalculator.TotalMoneySpentOnLoan().ToString("0.##");
        }

        /// <summary>
        /// Event that listens to salary field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salary_TextChanged(object sender, EventArgs e)
        {
            budget.Enabled = false;
        }

        /// <summary>
        /// Event listener for the bonuses field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bonuses_TextChanged(object sender, EventArgs e)
        {
            budget.Enabled = false;
        }

        /// <summary>
        /// Event listener for the budget text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
