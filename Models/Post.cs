﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Guid SubCategoryId { get; set; }
        public Guid User { get; set; }
    }
}
