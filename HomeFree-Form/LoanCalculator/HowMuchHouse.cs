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

        public HowMuchHouse()
        {
            this.setRate(0);
        }

        /// <summary>
        /// function will be built
        /// sets interest rate based
        /// on credit score value
        /// </summary>
        /// <param name="creditScore"></param>
        public void setRate(int creditScore)
        {
            rate = 5.0 / 100.0 / 12.0;            
        }

        public void setRatio(double rate)
        {
            double firstStep = Math.Pow((rate + 1.0), 360.0);
            ratio = rate * firstStep / (firstStep - 1);
        }

        public void setMonthlyByIncome(double income, double bonuses)
        {
            monthly = (income + bonuses) * .25 / 12.0;
        }

        public void setMonthlyByBudget(double budget)
        {
            monthly = budget;
        }

        public double findHousePrice(ProfileModel profile)
        {
            setRate(profile.creditScore);
            setRatio(rate);

            if(profile.yearlyIncome == 0)
            {
                setMonthlyByBudget(profile.monthlyBudget);
            }
            else
            {
                setMonthlyByIncome(profile.yearlyIncome, profile.yearlyBonus);
            }

            profile.housePrice = (monthly / ratio) + profile.availableDownPayment;
            return profile.housePrice;
        }

    }
}
