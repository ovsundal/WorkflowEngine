using System.Data.Common;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddItem(new SendEmail());
            workflow.AddItem(new UploadVideo());
            workflow.AddItem(new ChangeVideoRecordStatus());
            workflow.AddItem(new CallWebService());
            
            var workflowEngine = new WorkflowEngine(workflow);
            workflowEngine.Run();
        }
    }
}