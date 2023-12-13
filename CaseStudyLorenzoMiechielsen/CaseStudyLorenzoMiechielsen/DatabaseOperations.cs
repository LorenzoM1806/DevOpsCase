using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CaseStudyLorenzoMiechielsen
{
    public static class DatabaseOperations
    {
        public static List<Tasks> GetAllTasks()
        {
            using(TaskDataContext context = new TaskDataContext())
            {
                return context.AllTask.ToList();
            }
        }

        public static int AddTask(string taskName, DateTime dueDate, string priority)
        {
            try
            {
                using TaskDataContext context = new TaskDataContext();
                Tasks newTask = new Tasks
                {
                    TaskName = taskName,
                    DueTo = dueDate,
                    Priority = priority,
                    TaskStatus = false,
                };
                context.AllTask.Add(newTask);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int DeleteTask(Tasks tasks)
        {
            try
            {
                using TaskDataContext context = new();
                context.Entry(tasks).State = EntityState.Deleted;
                return context.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateTask(Tasks tasks)
        {
            try
            {
                using TaskDataContext context = new();
                context.Entry(tasks).State = EntityState.Modified;
                return context.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }


    }
}
