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
        public bool Done { get; set; }
        public DateTime Deadline { get; set; }

        public override string ToString()
        {
            var stringDone = Done ? "Not done" : "Done" ;
            return $"{Id} - {Description} - {stringDone}" +( Done ? $"- {Deadline:MM/dd/yyyy}" : "" ) ;
        }

        public TodoItem(string description, bool done, DateTime? deadline = null)
        {
            Id = Guid.NewGuid();
            Description = description;
            Done = done;
            if (!deadline.HasValue) return;
            if (done)
                Deadline = deadline.Value;
        }

    }
}
