using System;
using System.Collections.Generic;

namespace lesson14
{
    class Blog
    {
        private List<Post> Posts = new List<Post>();

        public void Add(Post post)
        {
            Posts.Add(post);
        }

        public void delete(int id)
        {
            Posts.RemoveAt(id);
        }

        public void Display()
        {
            foreach (var item in Posts)
            {
                Console.WriteLine($"{item.Id}\t{item.Title}");
            }
        }
        public int GetCountPost()
        {
            return Posts.Count;
        }
    }
}
