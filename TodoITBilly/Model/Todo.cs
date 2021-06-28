using System;
using System.Collections.Generic;
using System.Text;

namespace TodoITBilly.Model
{
    public class Todo
    {
        //Private Fields
        private readonly int todoId;// Can only be set once, then the object will not be able to change its unique todoId;
        private string description;
        private bool done;
        //Person assignee;

        //Public Properties
        public int ToDoId { get { return todoId; } }
        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Description cannot be empty.");
                }
                else
                {
                    description = value;
                }

            }
        }
        public Todo(string description, int todoId)
        {
            this.description = description;
            this.todoId = todoId;
        }
    }
}
