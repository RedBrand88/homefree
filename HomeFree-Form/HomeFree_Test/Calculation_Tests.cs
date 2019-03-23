using LoanCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HomeFree_Test {
    public class Calculation_Tests {
        [Fact]
        public void MortgagePaymentWithNoDownPaymentAndNoTaxesTest() {
            MortgageModel model = new MortgageModel(259000,
                                                    4,
                                                    30,
                                                    0,
                                                    0);
            MortgagePayment payment = new MortgagePayment(model);
            double mp = payment.Algorithm();
            Assert.Equal(1236.51, mp);
        }

        [Fact]
        public void MortgagePaymentWithNoDownPaymentAndTaxesTest() {
            MortgageModel model = new MortgageModel(259000,
                                                    4,
                                                    30,
                                                    0,
                                                    300);
            MortgagePayment payment = new MortgagePayment(model);
            double mp = payment.Algorithm();
            Assert.Equal(1536.51, mp);
        }

        [Fact]
        public void MortgagePaymentWithDownPaymentAndNoTaxesTest() {
            MortgageModel model = new MortgageModel(259000,
                                                    4,
                                                    30,
                                                    2000,
                                                    0);
            MortgagePayment payment = new MortgagePayment(model);
            double mp = payment.Algorithm();
            Assert.Equal(1226.96, mp);
        }

        [Fact]
        public void MortgagePaymentWithDownPaymentAndTaxesTest() {
            MortgageModel model = new MortgageModel(259000,
                                                    4,
                                                    30,
                                                    2000,
                                                    300);
            MortgagePayment payment = new MortgagePayment(model);
            double mp = payment.Algorithm();
            Assert.Equal(1526.96, mp);
        }
    }
}
