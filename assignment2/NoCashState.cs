using assignment2;

public class NoCashState : IATMState
{
    private ATMMachine machine;

    public NoCashState(ATMMachine machine)
    {
        this.machine = machine;
    }

    public void InsertCard()
    {
        Console.WriteLine("Not enough cash available in the machine");
        RejectCard();
    }

    public void RejectCard()
    {
        Console.WriteLine("Your card has been rejected");
        machine.SetMachineState(machine.GetNoCardState());
    }

    public void InsertPinCode(int pinCode)
    {
        Console.WriteLine("No cash available");
        machine.SetMachineState(machine.GetNoCashState());
    }

    public void WithdrawCash(int amount)
    {
        Console.WriteLine("No cash available");
        machine.SetMachineState(machine.GetNoCashState());
    }
}
