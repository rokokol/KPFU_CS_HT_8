using System;
namespace HT
{
    public class Report
    {
        public string text;
        public DateTime time = DateTime.Now;
        public Employee executor;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:HT.Report"/> class.
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="executor">Executor.</param>
        public Report(string text, Employee executor)
        {
            this.text = text;
            this.executor = executor;
        }
    }
}
