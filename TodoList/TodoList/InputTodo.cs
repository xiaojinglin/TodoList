using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    //A class that store a todo item from the entry
    class InputTodo
    {
        public TodoItem getTodo()
        {
            TodoItem newTodo = new TodoItem();
            try
            {
                string input = "";
                Console.WriteLine("Please enter the description: ");
                input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                {
                    throw new IsNullOrEmptyException("You can't leave your description empty.");
                }
                newTodo.Description = input;
                Console.WriteLine("Please enter the due date(yyyymmdd): ");
                input = Console.ReadLine();
                newTodo.DueDate = new StringDateSwitch().stringToDate(input);
                Console.WriteLine("Please enter the finish date(yyyymmdd): ");
                input = Console.ReadLine();
                newTodo.DateFinished = new StringDateSwitch().stringToDate(input);                
            }
            catch(IsNullOrEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("The data you enter is invalid!");
            }
            return newTodo;
        }       
    }

    class IsNullOrEmptyException : System.Exception
    {
        public IsNullOrEmptyException()
        {
        }
        public IsNullOrEmptyException(string message) : base(message)
        {
        }
    }
}
