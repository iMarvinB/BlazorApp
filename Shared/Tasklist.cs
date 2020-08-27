using System.Collections.Generic;

namespace Shared
{
    public class Tasklist
    {
        List<Task> tasklist = new List<Task>();

        public void addTask(List<Task> list, Task task){
            tasklist.Add(task);
        }
    }
}