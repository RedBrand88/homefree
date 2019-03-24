namespace LoanCalculator {
    public class TotalInterest : ICalculation {
        PayoffModel Model { get; set; }

        public TotalInterest(PayoffModel model) {
            Model = model;
        }

        public double Algorithm() {
            //calc theoretical total
            //calc months saved
            Helper();
            //calc money saved
            if (Model.TotalMonthsSaved == 0) {
                Model.TotalMoneySaved = 0;
            }
            else {
                Model.TotalMoneySaved= Model.TotalMonthsSaved * Model.MonthlyPayment;
            }
            //calc money paid
            Model.TotalMoneyPaid = Model.TheoreticalTotal - Model.TotalMoneySaved;

            return Model.TotalMoneyPaid;
        }

        public void Helper() {
            double interestPayment;
            double principlePayment;
            int monthsRemaining = Model.Months * 12;
            double principle = Model.Principle;
            Model.Months *= 12;
            Model.Rate = (Model.Rate / 100) / 12;
            Model.TheoreticalTotal = Model.MonthlyPayment * Model.Months;

            if (Model.ExtraPayment > 0) {

                for (int i = 0; i < Model.Months; i++) {
                    interestPayment = principle * Model.Rate;
                    principlePayment = Model.MonthlyPayment - interestPayment;
                    principlePayment += Model.ExtraPayment;
                    principle -= principlePayment;
                    monthsRemaining--;

                    if(principle < 0) {
                        break;
                    }
                }
            }
            else {
                monthsRemaining = 0;
            }

            Model.TotalMonthsSaved = monthsRemaining;
        }
    }
}
