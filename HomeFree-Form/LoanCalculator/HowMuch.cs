using System;

namespace LoanCalculator {
    public class HowMuch : ICalculation {
        HowMuchModel Model { get; set; }

        public HowMuch(HowMuchModel model) {
            Model = model;
        }

        public double Algorithm() {
            Helper();
            double baseRatio = Math.Pow((1 + Model.Rate), Model.Months);
            double baseRatioMinusOne = baseRatio - 1;
            baseRatio *= Model.Rate;
            baseRatio /= baseRatioMinusOne;
            Model.Budget = Model.MonthlyPayment / baseRatio;
            return Model.Budget;
        }

        public void Helper() {
            Model.Rate = (5 / 100) / 12;
            Model.Months = 30 * 12;
        }
    }
}
