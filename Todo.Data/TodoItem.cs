using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Data
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime Deadline { get; set; }

        public override string ToString()
        {
            var stringDone = IsDone ? "Done" : "Not Done" ;
            return $"{Id} - {Description} - {stringDone}" +( IsDone ?  "": $"- {Deadline:MM/dd/yyyy}") ;
        }

        public TodoItem(string description, bool isDone, DateTime? deadline = null)
        {
            Id = Guid.NewGuid();
            Description = description;
            IsDone = isDone;
            if (!deadline.HasValue && !IsDone)
                Deadline = deadline.Value;
        }

    }
}
