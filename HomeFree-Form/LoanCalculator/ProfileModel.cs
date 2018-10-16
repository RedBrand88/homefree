using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    public class ProfileModel
    {
        public double yearlyIncome { get; set; }
        public double yearlyBonus { get; set; }
        public double monthlyBudget { get; set; }
        public double availableDownPayment { get; set; }
        public int creditScore { get; set; }
        public double housePrice { get; set; }
    }
}
