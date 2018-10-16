using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    public class LoanObjectModel
    {
        public double downPayment { get; set; }
        public double principal { get; set; }
        public double rate { get; set; }
        public int years { get; set; }
        public double interest_Utilities { get; set; }
        public double monthlyPayment { get; set; }
        public double extraPayment { get; set; }
    }
}
