using System;
using System.Collections.Generic;

namespace HT
{
    public class Project
    {
        private Status status = Status.Project;

        public string description;
        public DateTime terms;
        public Human customer;
        public Employee teamlead;
        public readonly List<Task> tasks = new List<Task>();

        /// <summary>
        /// Complete this instance.
        /// </summary>
        /// <returns>The complete.</returns>
        public bool Complete()
        {
            foreach(Task t in tasks)
            {
                if (t.status != Task.Status.Done)
                {
                    Console.WriteLine($"Task {t} is not done yet!");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Asigns the task if status is "Project".
        /// </summary>
        /// <param name="task">Task.</param>
        public void AsignTask(Task task)
        {
            if (status == Status.Project)
            {
                tasks.Add(task);
            }
            else
            {
                Console.WriteLine("Status is not \"Project\"");
            }
        }

        /// <summary>
        /// Ensures the tasks.
        /// </summary>
        public void EnsureTasks()
        {
            status = Status.Execution;
        }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <returns>The status.</returns>
        public Status GetStatus()
        {
            return status;
        }



        /// <summary>
        /// Status of the project.
        /// </summary>
        public enum Status
        {
            Project,
            Execution,
            Closed
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:HT.Project"/> class.
        /// </summary>
        public Project(string description, DateTime terms, Human customer, Employee teamlead, List<Task> tasks)
        {
            this.description = description;
            this.terms = terms;
            this.customer = customer;
            this.teamlead = teamlead;
            this.tasks = tasks;
        }
    }
}
