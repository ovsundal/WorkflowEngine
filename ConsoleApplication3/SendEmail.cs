using System;

namespace ConsoleApplication3
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending email");
        }
    }
}