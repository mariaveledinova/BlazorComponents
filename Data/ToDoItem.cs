using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.Data
{
    public class ToDoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public DateTime ToDoDate { get; set; }
    }
}
