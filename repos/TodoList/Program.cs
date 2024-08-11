using System.ComponentModel;
namespace TodoList
{
    public struct Task
    {
        public string TaskGet;
    }
    class TodoList
    {
        static Task[] Todo = new Task[5];
        static int Count = 0;
       
        static void Main(string[] args)
        {
            Console.WriteLine("............................................................................................");
            Console.WriteLine("Welcome to the to do list program..............");

            string check;
            do
            {
                Console.WriteLine("******************************************************");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. View List");
                Console.WriteLine("4. Exit");
                Console.WriteLine("******************************************************");

                string? select = Console.ReadLine();
                switch (select)
                {
                    case "1" :

                        Add();
                        break;
                    case "2":
                        Remove();
                        break;
                    case "3":
                        List();
                        break;
                    case "4":
                        Exit();
                        break;
                }

                Console.WriteLine("Do you want continue (y/Y) ");
                check = Console.ReadLine();

            } while (check == "y" || check == "Y");
        }
        static void Add()
        {
            Console.WriteLine("How many Task you want to add ?");
            int Count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************************************************************");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Enter your Tasks....");
                Todo[i].TaskGet = Console.ReadLine();
            }
            Console.WriteLine("**********************************************************************");
        }
        static void Remove()
        {
            Console.WriteLine("Enter the number of the task to remove: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < Count)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    Todo[i] = Todo[i + 1];
                }
                Count--;
                Console.WriteLine("Task removed successfully.");
            }
            //else
            //{
            //    Console.WriteLine("Invalid index.");
            //}
        }
        static void List()
        {
            Console.WriteLine("----Todays Task----");
            for(int j = 0; j < Todo.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {Todo[j].TaskGet}");
            }
        }
        static void Exit()
        {
            Console.WriteLine("Press any button to exit.....");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
