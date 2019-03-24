namespace LoanCalculator {
    public interface IHasEarlyPayoff {
        double TotalMoneySaved { get; set; }
        double TotalMoneyPaid { get; set; }
        int TotalMonthsSaved { get; set; }
        double TheoreticalTotal { get; set; }
        double ExtraPayment { get; set; }
    }
}
