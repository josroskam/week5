using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class MainSystem
    {
        Logger logger;
        public SubSystem SubSystem;
        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
        }
        public MainSystem() 
        {
            SubSystem = new SubSystem();
            logger = Logger.GetInstance();
        }
    }
}
