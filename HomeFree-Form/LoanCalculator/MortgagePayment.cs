using System;

namespace LoanCalculator {
    public class MortgagePayment : ICalculation {
        
        MortgageModel Model { get; set; }

        public MortgagePayment(MortgageModel model) {
            Model = model;
        }

        public double Algorithm() {
            Helper();
            double baseRatio = Math.Pow((1 + Model.Rate), Model.Months);
            double baseRatioMinusOne = baseRatio - 1;
            baseRatio *= Model.Rate;
            double payment = Model.Principle * (baseRatio / baseRatioMinusOne);
            Model.MonthlyPayment = Math.Round(payment + Model.Taxes, 2);

            return Model.MonthlyPayment;
        }

        public void Helper() {
            Model.Rate = (Model.Rate / 100) / 12;
            Model.Months *= 12;
            Model.Principle -= Model.DownPayment;
        }

    }
}
