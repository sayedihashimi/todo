using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SayedTodo.Shared {
    public class TodoSet {
        public string SetName {
            get; set;
        }

        public List<TodoItem> Items {
            get; set;
        } = new List<TodoItem>();

        public static TodoSet BuildFromJson(string json) {
            var result = JsonConvert.DeserializeObject<TodoSet>(json);
            return result;
        }
    }
}
