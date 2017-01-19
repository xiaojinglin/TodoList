using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creat a todo list and initializate it 
            Todos todos = new Todos();
            todos.MyTodoList = new List<TodoItem>
            {
                new TodoItem() { Description = "Shopping" , DueDate = new DateTime(2017,01,12), DateFinished = new DateTime(2017,01,11)},
                new TodoItem() { Description = "Clean the house" , DueDate = new DateTime(2017,01,14), DateFinished = new DateTime(2017,01,14)},
                new TodoItem() { Description = "Fix the door" , DueDate = new DateTime(2017,01,15), DateFinished = new DateTime(2017,01,14)},
                new TodoItem() { Description = "Change the table" , DueDate = new DateTime(2017,01,12), DateFinished = new DateTime(2017,01,15)}
            };

            string entry = "";
            while (true)
            {
                Console.WriteLine("Todo List");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1) View list");
                Console.WriteLine("2) Add Todo");
                Console.WriteLine("3) Search Todo");
                Console.WriteLine("4) Delete Todo");
                Console.WriteLine("5) Quit");

                Console.WriteLine("Please select an option (1-5):");

                entry = Console.ReadLine();
                TodoItem newTodo = new TodoItem();
                string input = "";

                switch (entry)
                {
                    //Show list
                    case "1":
                        todos.showList();
                        break;

                   //Add todo to the list
                    case "2":
                        newTodo = new InputTodo().getTodo();
                        if (newTodo != null)
                        {
                            todos.addTodo(newTodo);
                        }
                        break;

                    //Search todos
                    case "3":
                        try
                        {
                            Console.WriteLine("Please enter the date(yyyymmdd): ");
                            input = Console.ReadLine();
                            todos.searchTodo(new StringDateSwitch().stringToDate(input));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("The data you enter is invalid!");
                        }
                        break;

                    //Delete todo item
                    case "4":
                        Console.WriteLine("Please enter the item number you want to delete:");
                        input = Console.ReadLine();
                        if (newTodo != null)
                        {
                            try
                            {
                                todos.deleteTodo(int.Parse(input));
                            }
                            catch(FormatException)
                            {
                                Console.WriteLine("Invalid entry, please enter a number");
                            }
                        }
                        break;

                    //Quit the system
                    case "5":
                        Console.WriteLine("GoodBye");
                        break;
                    default:
                        Console.WriteLine("Invalid entry!");
                        break;
                }
                if(entry == "5")
                {
                    break;
                }
            }

        }
    }
}
