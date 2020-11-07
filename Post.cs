using System;
using System.ComponentModel;

namespace lesson14
{
    class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
