using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListShared
{
    public interface ITodoRepository
    {
        void Add(Todo item);
        Todo Get(int id);
        void Update(Todo item);
        void Delete(int id);
        IEnumerable<Todo> Get();
    }
}
