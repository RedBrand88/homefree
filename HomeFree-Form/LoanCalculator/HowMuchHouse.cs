using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class HowMuchHouse : IHowMuchHouse
    {
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
            this.rate = 5.0 / 100.0 / 12.0;            
        }

        /// <summary>
        /// set mortgage ratio for interest rate and total months of loan
        /// </summary>
        /// <param name="rate"></param>
        public void setRatio(double rate)
        {
            double firstStep = Math.Pow((rate + 1.0), 360.0);
            this.ratio = rate * firstStep / (firstStep - 1);
        }

        /// <summary>
        /// sets monthly mortgage payment based on 25% of yearly income
        /// </summary>
        /// <param name="income"></param>
        /// <param name="bonuses"></param>
        public void setMonthlyByIncome(double income, double bonuses)
        {
            this.monthly = (income + bonuses) * .25 / 12.0;
        }

        /// <summary>
        /// set monthly mortgage based on budget input
        /// </summary>
        /// <param name="budget"></param>
        public void setMonthlyByBudget(double budget)
        {
            this.monthly = budget;
        }

        /// <summary>
        /// get house price from monthly mortgage payment
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
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
