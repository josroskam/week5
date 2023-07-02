using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class NoCardState : IATMState
    {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void InsertCard()
        {
            if (machine.AmountInMachine <= 0)
            {
                Console.WriteLine("Not enough cash in machine");
                RejectCard();
                return;
            }
            Console.WriteLine("Card has been inserted");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void InsertPinCode(int pinCode)
        {
            Console.WriteLine("No card inserted");
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("No card inserted");
        }
    }
}
