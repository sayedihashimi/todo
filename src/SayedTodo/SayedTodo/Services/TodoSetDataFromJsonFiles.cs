using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using SayedTodo.Shared;

namespace SayedTodo.Services {
    public class TodoSetDataFromJsonFiles : ITodoSetData {

        private IHostingEnvironment Environment { get; set; }
        public TodoSetDataFromJsonFiles(IHostingEnvironment env){
            Environment = env;
        }

        public void AddOrUpdateSet(string username, TodoSet set) {
            throw new NotImplementedException();
        }

        public List<TodoSet> GetAll(string username) {
            throw new NotImplementedException();
        }

        public TodoSet GetTodoSet(string username, string setname) {
            string filepath = Path.Combine(Environment.WebRootPath, $"todosets/{username}/{setname}");
            return TodoSet.BuildFromJson(System.IO.File.ReadAllText(filepath));
        }
    }
}
