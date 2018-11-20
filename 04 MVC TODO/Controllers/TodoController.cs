using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListShared;

namespace _04_MVC_TODO.Controllers
{
    public class TodoController : Controller
    {
        private ITodoRepository repository;

        public TodoController(ITodoRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Get());
        }

        [HttpGet]
        public ViewResult Edit(int? id)
        {
            if (id.HasValue)
            {
                return View(repository.Get(id.Value));
            }
            else
            {
                return View(new Todo());
            }
        }

        [HttpPost]
        public IActionResult Edit(Todo todo)
        {
            if (todo.Id == 0)
            {
                repository.Add(todo);
                return RedirectToAction("Edit");
            }
            else
            {
                repository.Update(todo);
                return RedirectToAction("Index");
            }
            
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            return View(repository.Get(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            repository.Delete(id);
            return Index();
        }
        
}
}
