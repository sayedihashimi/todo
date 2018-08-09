using System;
using System.Collections.Generic;
using SayedTodo.Shared;

namespace SayedTodo.Services {
    public interface ITodoSetData {
        TodoSet GetTodoSet(string username, string setname);
        List<TodoSet> GetAll(string username);
        void AddOrUpdateSet(string username, TodoSet set);
    }
}
