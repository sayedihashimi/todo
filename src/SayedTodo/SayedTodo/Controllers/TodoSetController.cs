using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SayedTodo.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SayedTodo.Controllers {
    [Route("sets")]
    public class TodoSetController : BaseController {
        private ITodoSetData TodoSetData { get; set; }

        public TodoSetController(ITodoSetData todoSetData){
            TodoSetData = todoSetData;
        }

        [Route("")]
        public IActionResult Index() {
            var temp = TodoSetData.GetTodoSet("user-7296", "todo01.json");

            return View();
        }

        [Route("json")]
        public IActionResult GetSetAsJson(string username, string setname){
            throw new NotImplementedException();
        }
    }
}
