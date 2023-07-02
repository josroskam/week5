using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Logger
    {
        int numberOfLines = 0;
        private static Logger uniqueInstance;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Logger();
            return uniqueInstance;
        }

        public void Log(string system, string logLine)
        {
            numberOfLines++;
            Console.WriteLine(String.Format($"{numberOfLines} - [{system}] {logLine}"));
        }
    }
}
