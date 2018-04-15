using System.Collections.Generic;

namespace ConsoleApplication3
{
    public interface IWorkflow
    {
        void AddItem(ITask task);
        void RemoveItem(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}