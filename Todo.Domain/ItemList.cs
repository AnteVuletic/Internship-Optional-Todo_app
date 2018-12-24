using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Data;

namespace Todo.Domain
{
    public class ItemList
    {
        public static List<TodoItem> CurrentList = new List<TodoItem>();

        public ItemList()
        {
            var item = new TodoItem("This is just an test", false);
            CurrentList.Add(item);
        }

        public List<TodoItem> GetAll()
        {
            return CurrentList;
        }

        public TodoItem GetItem(Guid guidPassed)
        {
            foreach (var todoItem in CurrentList)
            {
                if (todoItem.Id == guidPassed)
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
            var ifFound = false;
            foreach (var todoItem in CurrentList)
            {
                if (todoItem.Id == guidOfItemPassed) continue;
                CurrentList.Remove(todoItem);
                ifFound = true;
            }
            CurrentList.Add(argItemPassed);
            return ifFound;
        }
    }
}
