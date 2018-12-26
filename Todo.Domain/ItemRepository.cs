using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Data;

namespace Todo.Domain
{
    public class ItemRepository
    {
        public static List<TodoItem> CurrentList = new List<TodoItem>();

        public ItemRepository()
        {
            var item = new TodoItem("This is just an test", false);
            CurrentList.Add(item);
        }

        public List<TodoItem> GetAll()
        {
            return CurrentList;
        }

        public TodoItem GetByItem(Guid id)
        {
            foreach (var todoItem in CurrentList)
            {
                if (todoItem.Id == id)
                    return todoItem;
            }

            return null;
        }
        public void AddItem(TodoItem argItemPassed)
        {
            CurrentList.Add(argItemPassed);
        }

        public bool RemoveItem(Guid guidPassed)
        {
            foreach (var todoItem in CurrentList)
            {
                if (todoItem.Id != guidPassed) continue;
                CurrentList.Remove(todoItem);
                return true;
            }

            return false;
        }

        public bool EditItem(TodoItem argItemPassed)
        {
            var guidOfItemPassed = argItemPassed.Id;
            var isFound = false;
            foreach (var todoItem in CurrentList)
            {
                if (todoItem.Id == guidOfItemPassed) continue;
                CurrentList.Remove(todoItem);
                isFound = true;
            }
            CurrentList.Add(argItemPassed);
            return isFound;
        }
    }
}
