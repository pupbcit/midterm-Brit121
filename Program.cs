using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOCommon;

namespace UILayer
{
    
    public class UI_Layer
    {
        private List<TODOCommon.Task> tasks = new List<TODOCommon.Task>();

        public void CreateDummyTasks()
        {
            int taskIdCounter = 0;

            taskIdCounter++;
            tasks.Add(new TODOCommon.Task
            {
                TaskId = taskIdCounter,
                Description = "Review in OOP",
                CreationDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = "Not Started"
            });

            taskIdCounter++;
            tasks.Add(new TODOCommon.Task
            {
                TaskId = taskIdCounter,
                Description = "Create Report in English",
                CreationDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = "In Progress"
            });

            taskIdCounter++;
            tasks.Add(new TODOCommon.Task
            {
                TaskId = taskIdCounter,
                Description = "Do project in Database",
                CreationDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = "Not Started"
            });

            taskIdCounter++;
            tasks.Add(new TODOCommon.Task
            {
                TaskId = taskIdCounter,
                Description = "Review in Math",
                CreationDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = "Done"
            });
        }

        public void UpdateTask(int id, string description, string status)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskId == id)
                {
                    tasks[i].Status = status;
                    tasks[i].Description = description;
                }
            }
        }
        public void DeleteTask(int id)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskId == id)
                {
                    tasks.Remove(tasks[i]);
                }
            }
        }


    }
}
