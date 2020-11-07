using System;
using System.Collections.Generic;


namespace lesson14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var blog = new Blog();
            blog.Add(new Post { Id = 1, Title = "post 1", Details = "some text" });
            blog.Add(new Post { Id = 2, Title = "post 2", Details = "some text" });
            blog.Add(new Post { Id = 3, Title = "post 3", Details = "some text" });
            blog.Add(new Post { Id = 4, Title = "post 4", Details = "some text" });
            blog.Add(new Post { Id = 5, Title = "post 5", Details = "some text" });
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("before effect delete");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"count of posts: {blog.GetCountPost()}");
            blog.Display();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("affter effect delete");
            Console.ForegroundColor = ConsoleColor.White;
            blog.delete(3);
            Console.WriteLine($"count of posts: {blog.GetCountPost()}");
            blog.Display();
            Console.ReadKey();
        }
    }
}
