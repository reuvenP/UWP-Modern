﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User : IEntity
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Book> BookList { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
