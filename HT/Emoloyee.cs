using System;
using System.Collections.Generic;

namespace HT
{
    public class Employee : Human
    {
        public readonly List<Task> tasks = new List<Task>();

        public void MakeAReport(string text, Task task)
        {
            Report report = new Report(text, this);
            if (task.init.MarkReport(report))
            {
                task.reports.Add(report);
            }
            else
            {
                Console.WriteLine("Init thinks that you wrong");
            }
        }

        public bool MarkReport(Report report)
        {
            if (report.text.Contains("Amogus"))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gives a task.
        /// </summary>
        /// <param name="employees">Employees.</param>
        /// <param name="tasks">Tasks.</param>
        public void GiveATask(List<Employee> employees, List<Task> tasks)
        {
            foreach(Task t in tasks)
            {
                foreach(Employee e in employees)
                {
                    if (e.GetATask(t)) break;
                }
            }
        }

        /// <summary>
        /// Has s task.
        /// </summary>
        /// <returns><c>true</c>, if AT ask was hased, <c>false</c> otherwise.</returns>
        public virtual bool HasATask()
        {
            return tasks.Count != 0;
        }

        /// <summary>
        /// Completes a task.
        /// </summary>
        /// <param name="task">Task.</param>
        public virtual void CompleteATask(Task task)
        {
            task.status = Task.Status.Done;
        }

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <returns><c>true</c>, if AT ask was gotten, <c>false</c> otherwise.</returns>
        /// <param name="task">Task.</param>
        public bool GetATask(Task task)
        {
            if (tasks.Count == 0)
            {
                tasks.Add(task);
                task.status = Task.Status.Assigned;
                task.executor = this;
                Console.WriteLine($"Человек {name} берет задачу \"{task}\"");
                return true;
            }
            return false; 
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:HT.Employee"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:HT.Employee"/>.</returns>
        public override string ToString()
        {
            return $"Работник {name} - текущая задача: {tasks}";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:HT.Employee"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="subordinates">Subordinates.</param>
        public Employee(string name) : base(name) { }
    }
}
