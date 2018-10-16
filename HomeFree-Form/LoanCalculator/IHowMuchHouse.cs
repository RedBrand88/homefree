using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    interface IHowMuchHouse
    {
        double findHousePrice(ProfileModel profile);
        void setRate(int cs);
    }
}
