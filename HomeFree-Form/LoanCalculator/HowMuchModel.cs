using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator {
    public class HowMuchModel : IHasMortgage, IHasBudget {

        public HowMuchModel(double bud) {
            Budget = bud;
        }

        public double Principle { get; set; }
        public double Rate { get; set; }
        public int Months { get; set; }
        public double DownPayment { get; set; }
        public double Taxes { get; set; }
        public double MonthlyPayment { get; set; }
        public double Budget { get; set; }
        public double AffordablePrice { get; set; }
    }
}
