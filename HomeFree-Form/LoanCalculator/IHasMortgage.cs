using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator {
    public interface IHasMortgage {
        double Principle { get; set; }
        double Rate { get; set; }
        int Months { get; set; }
        double DownPayment { get; set; }
        double Taxes { get; set; }
        double MonthlyPayment { get; set; }
    }
}
