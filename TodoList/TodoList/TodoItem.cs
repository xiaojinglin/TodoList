using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class TodoItem
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateFinished { get; set; }

        //Show todo information
        public void showItem()
        {
            Console.WriteLine(this.Description +
                              ", Due date: " + this.DueDate.ToString("yyyy-MM-dd") +
                              ", Finished date: " + this.DateFinished.ToString("yyyy-MM-dd") + "\n");
        }

        public bool isDue(DateTime d)
        {
            return this.DueDate == d;
        }

        public bool isFinished(DateTime d)
        {
            return this.DateFinished == d;
        }
    }
}
