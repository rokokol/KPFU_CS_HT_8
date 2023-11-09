using System;
using System.Collections.Generic;

namespace HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Айдайте тестить!");
            DateTime deadline = DateTime.Today.AddDays(3);

            Console.WriteLine("Создаем заказчина Васяна и тимлида Тему");
            Human vasuan = new Human("Васян");
            Employee tema = new Employee("Тема");

            Console.WriteLine("Создаем уникальные задачи");
            List<Task> tasks = new List<Task>
            {
                new Task("Пить чай", deadline, tema, Task.Period.Monthly, 0),
                new Task("Красить кнопки", deadline, tema, Task.Period.None, 0),
                new Task("Купить васяну новую машину", DateTime.Now.AddDays(1), tema, Task.Period.None, 0),
                new Task("Еще красить кнопки", deadline, tema, Task.Period.None, 0),
                new Task("Красить больше кнопой", deadline, tema, Task.Period.None, 0),
                new Task("Выкинуть все кофе из квартиры и купить чай", deadline, tema, Task.Period.None, 0),
                new Task("Написать сортировку пузырьком для массива из 1000000000000 элементов", deadline, tema, Task.Period.None, 0),
                new Task("Написать сортировку рандомом для массива из 10^10 элементов", deadline, tema, Task.Period.None, 0),
                new Task("Покрасить еще одну кнопку", deadline, tema, Task.Period.None, 0),
                new Task("Поныть что сложно", deadline, tema, Task.Period.Custom, 6)
            };

            Console.WriteLine("Создаем проект");
            Project project = new Project("Красить кнопки и пить чай", deadline, vasuan, tema, tasks);

            Console.WriteLine("Создаем лучшую комманду на свете");
            List<Employee> bestTeamEver = new List<Employee>
            {
                new Employee("ойтигшнег 1"),
                new Employee("ойтигшнег 2"),
                new Employee("ойтигшнег 3"),
                new Employee("ойтигшнег 4"),
                new Employee("ойтигшнег 5"),
                new Employee("ойтигшнег 6"),
                new Employee("ойтигшнег 7"),
                new Employee("Толик"),
                new Employee("ойтигшнег 8"),
                new Employee("ойтигшнег 9"),
            };

            Console.WriteLine("Назначаем уникальные задачи");
            tema.GiveATask(bestTeamEver, tasks);
            project.EnsureTasks();

            Console.WriteLine("Все делают свои отчеты");
            foreach (Employee e in bestTeamEver)
            {
                e.MakeAReport("brrrr", e.tasks[0]);
            }

            Console.WriteLine("Все выполняют свои задачи");
            foreach(Employee e in bestTeamEver)
            {
                foreach(Task t in e.tasks)
                {
                    e.CompleteATask(t);
                }
            }

            Console.WriteLine("Проект завершен!");
            project.Complete();
        }
    }
}
