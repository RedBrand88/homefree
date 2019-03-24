namespace LoanCalculator {
    public class PayoffModel : IHasMortgage, IHasEarlyPayoff {

        public PayoffModel(double prin, double rat, int mon, double extra, double payment) {
            Principle = prin;
            Rate = rat;
            Months = mon;
            ExtraPayment = extra;
            MonthlyPayment = payment;
        }

        public double Principle { get; set; }
        public double Rate { get; set; }
        public int Months { get; set; }
        public double DownPayment { get; set; }
        public double Taxes { get; set; }
        public double MonthlyPayment { get; set; }
        public double TotalMoneySaved { get; set; }
        public double TotalMoneyPaid { get; set; }
        public int TotalMonthsSaved { get; set; }
        public double TheoreticalTotal { get; set; }
        public double ExtraPayment { get; set; }
    }
}
