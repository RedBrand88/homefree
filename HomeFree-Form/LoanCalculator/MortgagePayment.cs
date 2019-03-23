using System;

namespace LoanCalculator {
    public class MortgagePayment : ICalculation {
        
        MortgageModel Model { get; set; }

        public MortgagePayment(MortgageModel model) {
            Model = model;
        }

        public double Algorithm() {
            double rate = (Model.Rate / 100) / 12;
            int mon = Model.Months * 12;
            double prin = Model.Principle - Model.DownPayment;
            double baseRatio = Math.Pow((1 + rate), mon);
            double baseRatioMinusOne = baseRatio - 1;
            baseRatio *= rate;
            double payment = prin * (baseRatio / baseRatioMinusOne);

            return Math.Round(payment + Model.Taxes, 2);
        }

    }
}
