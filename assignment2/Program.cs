using assignment2;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        Program myProgram = new Program();
        myProgram.Start();
    }

    private void Start()
    {
        ATMMachine machine = new ATMMachine(2000);
        string input = readString("Please enter your command: ");

        while (input != "stop")
        {
            switch (input) {
                case "insert card":
                    machine.InsertCard();
                    break;
                case "reject card":
                    machine.RejectCard();
                    break;
                case "enter pincode":
                    machine.EnterPinCode(readInt("Please enter your pincode: "));
                    break;
                case "withdraw cash":
                    machine.WithdrawCash(readInt("Please enter the amount of cash: "));
                    break;
                    default:
                    Console.WriteLine("entered unknown command");
                    break;
           };
           Console.WriteLine();
           input = readString($"Please enter your command: ");
        }
        Console.Read();
    }

    private string readString(string question)
    {
        Console.Write(question);
        return Console.ReadLine();
    }

    private int readInt(string question)
    {
        Console.Write(question);
        return int.Parse(Console.ReadLine());
    }
}