using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoListShared;

namespace _02_WebApplication.Pages
{
    public class EditModel : PageModel
    {
        public void OnGet(int? id)
        {
            if (id.HasValue)
            {
                this.Todo = new TodoRepositoryFast().Get(id.Value);
            }
            else
            {
                this.Todo = new Todo();
            }
        }

        [BindProperty]
        public Todo Todo { get; set; }

        public IActionResult OnPost()
        {
            if (this.Todo.Id == 0)
            {
                new TodoRepositoryFast().Add(this.Todo);
            }
            else
            {
                new TodoRepositoryFast().Update(this.Todo);
            }

            return Redirect("/");
        }
    }
}