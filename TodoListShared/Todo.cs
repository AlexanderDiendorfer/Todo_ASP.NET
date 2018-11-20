using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListShared
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now;
    }
}
