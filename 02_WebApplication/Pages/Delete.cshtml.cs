using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _02_WebApplication.Pages
{
    public class DeleteModel : PageModel
    {
        public TodoListShared.Todo Todo{get;set;}
        public void OnGet(int id)
        {
            this.Todo = new TodoListShared.TodoRepositoryFast().Get(id);
        }
    }
}