using LoanCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HomeFree_Test {
    public class HowMuch_Tests {
        [Fact]
        public void HowMuchHouseTest() {
            HowMuchModel model = new HowMuchModel(1500);
            HowMuch howMuch = new HowMuch(model);
            double target = Math.Round(howMuch.Algorithm(), 2);
            Assert.Equal(279422.43, target);
        }
    }
}
