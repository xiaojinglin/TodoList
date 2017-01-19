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

        //Show the todo list
        public void showList()
        {
            for(int index = 0; index< MyTodoList.Count; index++)
            {
                    Console.Write(index+1 + ". ");
                    MyTodoList[index].showItem();
            }
        }

        //Add a new todo item
        public void addTodo(TodoItem todo)
        {
            //Check whether the todo we want to add to the list is a duplicated one
            TodoItem resultTodo = MyTodoList.Find(
                  delegate (TodoItem t)
                  {
                      return t.Description.Replace(" ", "").ToLower() == todo.Description.Replace(" ", "").ToLower() &&
                             t.DueDate == todo.DueDate &&
                             t.DateFinished == todo.DateFinished;
                  });
            if (resultTodo == null)
            {
                MyTodoList.Add(todo);
                Console.WriteLine("You just successfully added a new todo.");
            }
            else
            {
                Console.WriteLine("You have this todo in the list already.");
            }
        }

        //Delete a todo item
        public void deleteTodo(int index)
        {
            if (this.MyTodoList.Count > index -1)
            {
                MyTodoList.RemoveAt(index-1);
                Console.WriteLine("You just successfully deleted a new todo!");
            }
            else
            {
                Console.WriteLine("Can't find the todo item!");
            }
        }   

        //Search todo items
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
