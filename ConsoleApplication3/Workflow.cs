using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;

namespace ConsoleApplication3
{
    public class Workflow : IWorkflow
    {
        private readonly List<ITask> _tasks ;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void AddItem(ITask task)
        {
            if (task == null)
                throw new InvalidDataException();
            
            _tasks.Add(task);
        }

        public void RemoveItem(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
        
    }

    public class WorkflowEngine
    {
        private readonly IWorkflow _workflow;

        public WorkflowEngine(IWorkflow workflow)
        {
            _workflow = workflow;
        }
        
        public void Run()
        {
            foreach (var task in _workflow.GetTasks())
            {
                task.Execute();
            }
        }
    }
}