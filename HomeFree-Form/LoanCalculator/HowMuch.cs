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
            Model.AffordablePrice = Model.Budget / baseRatio;
            return Model.AffordablePrice;
        }

        //assumes a 5% rate 30 year loan
        public void Helper() {
            Model.Rate = 5.0 / 100 / 12;
            Model.Months = 30 * 12;
        }
    }
}
