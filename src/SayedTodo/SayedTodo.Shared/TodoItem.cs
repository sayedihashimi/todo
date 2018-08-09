using System;
namespace SayedTodo.Shared {
    public class TodoItem {
        public Guid Id {
            get;
            set;
        }

        public int Order {
            get;
            set;
        }

        public bool Completed {
            get;
            set;
        }
        public string Text {
            get;
            set;
        }
    }
}
