using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public interface IATMState
    {
        void InsertCard();
        void RejectCard();
        void InsertPinCode(int pinCode);
        void WithdrawCash(int amount);
    }
}
