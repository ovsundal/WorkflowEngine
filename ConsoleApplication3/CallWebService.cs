using System;

namespace ConsoleApplication3
{
    public class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling webservice");
        }
    }
}