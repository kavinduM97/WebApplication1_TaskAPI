﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace TaskAPI.Services
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();
    }
}