using System;
using System.Collections.Generic;

namespace HT
{
    public class Task
    {
        public string description;
        public DateTime terms;
        public Employee init;
        public Employee executor;
        public Status status;
        public readonly List<Report> reports = new List<Report>();

        public enum Status
        {
            Assigned,
            AtWork,
            AtTests,
            Done
        }

        /// <summary>
        /// Complete this instance.
        /// </summary>
        public void Complete()
        {
            status = Status.Done;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:HT.Task"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:HT.Task"/>.</returns>
        public override string ToString()
        {
            return string.Format("[Task: description={0}]", description);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:HT.Task"/> class.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="terms">Terms.</param>
        /// <param name="init">Init.</param>
        public Task(string description, DateTime terms, Employee init)
        {
            this.description = description;
            this.terms = terms;
            this.init = init;
        }
    }
}
