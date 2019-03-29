using LoanCalculator;
using System;
using Xunit;

namespace HomeFree_Test {
    public class TotalInterest_Tests {
        [Fact]
        public void TotalMoneyPaidTest() {
            PayoffModel model = new PayoffModel(259000, 4, 30, 0, 1236.51);
            TotalInterest save = new TotalInterest(model);
            double total = save.Algorithm();
            Assert.Equal(445143.60, total);
        }

        [Fact]
        public void TotalMoneySavedTest() {
            PayoffModel model = new PayoffModel(259000, 4, 30, 25, 1236.51);
            TotalInterest save = new TotalInterest(model);
            double total = save.Algorithm();
            Assert.Equal(16074.63, model.TotalMoneySaved);
        }
    }
}
