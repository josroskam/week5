using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    // state pattern
    public class ATMMachine
    {
        private int amountInMachine;
        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCard;
        private IATMState noCash;

        public IATMState ATMState;
        public int AmountInMachine { get; set; }

        public ATMMachine(int amount)
        {
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);

            noCard = new NoCardState(this);
            noCash = new NoCashState(this);

            this.amountInMachine = amount;
            SetAmountInMachine();

            this.ATMState = noCard;
        }


        public void InsertCard()
        {
            ATMState.InsertCard();
        }

        public void RejectCard()
        {
            cardPresent.RejectCard();
        }

        public void EnterPinCode(int pin)
        {
            cardPresent.InsertPinCode(pin);
        }

        public void WithdrawCash(int amount)
        {
            cardPresent.WithdrawCash(amount);
        }

        public void SetMachineState(IATMState state)
        {
            ATMState = state;
        }

        public void SetAmountInMachine()
        {
            AmountInMachine = amountInMachine;
        }

        public IATMState GetCorrectPinState()
        {
            return correctPinCode;
        }

        public IATMState GetNoCardState()
        {
            return noCard;
        }

        public IATMState GetCardPresentState()
        {
            return cardPresent;
        }

        public IATMState GetNoCashState()
        {
            return noCash;
        }
    }
}