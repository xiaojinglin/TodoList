using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Todos
    {
        public List<TodoItem> MyTodoList { get; set; }

        public void showList()
        {
            for(int index = 0; index< MyTodoList.Count; index++)
            {
                    Console.Write(index+1 + ". ");
                    MyTodoList[index].showItem();
            }
        }

        public void addTodo(TodoItem todo)
        {
            if(this.findOne(todo) == null)
            {
                MyTodoList.Add(todo);
            }
            else
            {
                Console.WriteLine("You have this todo in the list already.");
            }
        }

        public void deleteTodo(int index)
        {
            if (this.MyTodoList.Count > index)
            {
                MyTodoList.RemoveAt(index-1);
                Console.WriteLine("Delete sucessfully!");
            }
            else
            {
                Console.WriteLine("Can't find the todo item!");
            }
        }

        public TodoItem findOne (TodoItem todo)
        {
            TodoItem resultTodo = MyTodoList.Find(
               delegate (TodoItem t)
               {
                   return t.Description == todo.Description &&
                          t.DueDate == todo.DueDate &&
                          t.DateFinished == todo.DateFinished;
               });
            return resultTodo;
        }

        public void searchTodo(DateTime date)
        {
            int count = 0;
            foreach (TodoItem t in MyTodoList)
            {
                if(t.isDue(date) || t.isFinished(date))
                {
                    t.showItem();
                    count++;
                }
            }
            Console.WriteLine("Find " + count + " todos");
        }

        
    }
}
