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
        public bool NotDone { get; set; }
        public DateTime Deadline { get; set; }

        public override string ToString()
        {
            var stringDone = NotDone ? "Not Done" : "Done" ;
            return $"{Id} - {Description} - {stringDone}" +( NotDone ? $"- {Deadline:MM/dd/yyyy}" : "" ) ;
        }

        public TodoItem(string description, bool notDone, DateTime? deadline = null)
        {
            Id = Guid.NewGuid();
            Description = description;
            NotDone = notDone;
            if (!deadline.HasValue) return;
            if (notDone)
                Deadline = deadline.Value;
        }

    }
}
