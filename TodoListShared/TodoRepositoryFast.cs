using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListShared
{
    public class TodoRepositoryFast : ITodoRepository
    {
        static IDictionary<int, Todo> dummyRep = new Dictionary<int, Todo>();
        static int counter = 0;



        public void Add(Todo item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(dummyRep));
            }
            lock (dummyRep)
            {
                counter++;
                item.Id = counter;
                dummyRep.Add(counter, item);
            }
        }

        public void Delete(int id)
        {

        }

        public Todo Get(int id)
        {
            lock (dummyRep)
            {
                if (dummyRep.ContainsKey(id))
                {
                    return dummyRep[id];
                }
            }
            return null;
        }

        public IEnumerable<Todo> Get()
        {
            return dummyRep.Values;
        }

        public void Update(Todo item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            lock (dummyRep)
            {
                if (dummyRep.ContainsKey(item.Id))
                {
                    dummyRep[item.Id] = item;
                }
                else
                {
                    throw new KeyNotFoundException($"Todo with id {item.Id} notfound in dictionary");
                }
            }
        }


    }
}
