﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TodoListItems
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool isCompleted { get; set; } 

        public virtual string ApplicationUserID { get; set; }

    }
}
