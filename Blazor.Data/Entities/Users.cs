﻿
using System.Collections.Generic;

namespace Blazor.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public List<Question> Questions { get; set; }
    }
}
