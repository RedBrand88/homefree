namespace LoanCalculator {
    public class HowMuch : ICalculation {
        MortgageModel Model { get; set; }

        public HowMuch(MortgageModel model) {
            Model = model;
        }

        public double Algorithm() {
            return 0;
        }

        public void Helper() {

        }
    }
}
