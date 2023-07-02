using assignment2;

public class CardPresentState : IATMState
{
    private ATMMachine machine;

    public CardPresentState(ATMMachine machine)
    {
        this.machine = machine;
    }

    public void InsertCard()
    {
        Console.WriteLine("A card has been inserted already");
    }

    public void RejectCard()
    {
        Console.WriteLine("Your card has been rejected");
        machine.SetMachineState(machine.GetNoCardState());
    }

    public void InsertPinCode(int pinCode)
    {
        Console.WriteLine("You have entered the correct pincode");
        machine.SetMachineState(machine.GetCorrectPinState());
    }

    public void WithdrawCash(int amount)
    {
        if (amount > machine.AmountInMachine)
        {
            Console.WriteLine("Not enough cash available in the machine");
            RejectCard();
            return;
        }
        Console.WriteLine($"{amount} withdrawn from machine");
        machine.AmountInMachine -= amount;
        RejectCard();
    }
}
