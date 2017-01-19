using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
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
                //if (string.IsNullOrEmpty(input))
                //{
                //    throw new IsNullOrEmptyException("You didn't .");
                //}
                newTodo.Description = input;
                Console.WriteLine("Please enter the due date(yyyymmdd): ");
                input = Console.ReadLine();
                //DateTime.ParseExact(input, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); 
                newTodo.DueDate = new StringDateSwitch().stringToDate(input);
                Console.WriteLine("Please enter the finish date(yyyymmdd): ");
                input = Console.ReadLine();
                //DateTime.ParseExact(input, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                newTodo.DateFinished = new StringDateSwitch().stringToDate(input);                
            }
            catch (FormatException)
            {
                Console.WriteLine("The data you enter is invalid!");
            }
            return newTodo;
        }
        
    }

    //class IsNullOrEmptyException: System.Exception
    //{
    //    public IsNullOrEmptyException()

    //    {

    //    }

    //    public IsNullOrEmptyException(string message) : base(message)

    //    {

    //    }

    //}
}
