using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class SubSystem
    {
        Logger Logger;

        public SubSystem()
        {
            Logger = Logger.GetInstance();
        }

        public void DoSomeWork()
        {
            Logger.Log("SubSystem", "doing some work");
        }

        public void DoSomeMoreWork()
        {
            Logger.Log("SubSystem", "doing some more work");
        }
    }
}
