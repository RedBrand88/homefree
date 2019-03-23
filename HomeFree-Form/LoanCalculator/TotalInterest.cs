namespace LoanCalculator {
    public class TotalInterest : ICalculation {
        MortgageModel Model { get; set; }

        public TotalInterest(MortgageModel model) {
            Model = model;
        }

        public double Algorithm() {
            return 0;
        }
    }
}
