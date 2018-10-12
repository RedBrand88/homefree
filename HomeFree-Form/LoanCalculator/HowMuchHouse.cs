using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class HowMuchHouse : IHowMuchHouse
    {
        double housePrice;
        double rate;
        double ratio;
        double monthly;

        /// <summary>
        /// function will be built
        /// sets interest rate based
        /// on credit score value
        /// </summary>
        /// <param name="creditScore"></param>
        public void setRate(int creditScore)
        {
            rate = 5 / 100 / 12;
        }

        public void setRatio(double rate)
        {
            ratio = rate * (Math.Pow((1 + rate), 360) / Math.Pow((1 + rate), 360) - 1);
        }

        public void setMonthlyByIncome(double income, double bonuses)
        {
            monthly = (income + bonuses) * .25;
        }

        public void setMonthlyByBudget(double budget)
        {
            monthly = budget;
        }

        public double findHousePrice(double downPay)
        {
            housePrice = (monthly / ratio) + downPay;
            return housePrice;
        }

    }
}
