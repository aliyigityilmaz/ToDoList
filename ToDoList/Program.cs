using System.Security.Cryptography;

Console.WriteLine("Welcome to the ToDoList App!");
List<string> tasks = new List<string>();
string option = "";

while (option != "e")
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("(a)dd a task");
    Console.WriteLine("(s)how tasks");
    Console.WriteLine("(r)emove a task");
    Console.WriteLine("(e)xit");

    option = Console.ReadLine();
    if (option == "a")
    {
        Console.WriteLine("Please enter the name of the task to add to the list.");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Task added!");
    }
    else if (option == "r")
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine(i + " : " + tasks[i]);
        }
        Console.WriteLine("Which task would you like to remove?");
        int taskToRemove = Convert.ToInt32(Console.ReadLine());
        tasks.RemoveAt(taskToRemove);
        Console.WriteLine("Task removed!");
    }
    else if (option == "s")
    {
        Console.WriteLine("Here is a list of your tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine(i + " : " + tasks[i]);
        }
    }
    else if (option == "e")
    {
        Console.WriteLine("Goodbye!");
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
    Console.WriteLine("Thank you for using the ToDoList App!");
}