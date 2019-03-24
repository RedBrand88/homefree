using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator {
    public class MortgageModel : IHasMortgage {

        public MortgageModel(double prin, double rat, int mon, double down, double tax) {
            Principle = prin;
            Rate = rat;
            Months = mon;
            DownPayment = down;
            Taxes = tax;
        }

        public double Principle { get; set; }
        public double Rate { get; set; }
        public int Months { get; set; }
        public double DownPayment { get; set; }
        public double Taxes { get; set; }
        public double MonthlyPayment { get; set; }
    }
}
