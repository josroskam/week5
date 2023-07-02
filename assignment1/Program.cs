using assignment1;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        Program myProgram = new Program();
        myProgram.Start();
    }
    
    public void Start()
    {
        try
        {
            Logger logger = Logger.GetInstance();
            MainSystem mainSystem = new MainSystem();

            logger.Log("Program", "starting");

            mainSystem.DoSomeMainWork();
            mainSystem.SubSystem.DoSomeWork();
            mainSystem.SubSystem.DoSomeMoreWork();

            logger.Log("Program", "finishing");

            Console.ReadKey();
        }
        catch (Exception exp)
        {
            Console.WriteLine($"Exception occured: {exp.Message}");
        }
    }
}