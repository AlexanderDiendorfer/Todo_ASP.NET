using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _02_WebApplication.Pages
{
    public class IndexModel : PageModel
    {

        public TodoListShared.Todo[] Todos { get; set; }

        public void OnGet()
        {
            this.Todos = new TodoListShared.TodoRepositoryFast().Get().ToArray();
        }
    }
}


