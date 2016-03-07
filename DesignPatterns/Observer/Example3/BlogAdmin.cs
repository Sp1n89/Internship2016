using System;

namespace DesignPatterns.Observer.Example3
{
    public class BlogAdmin : IBlogSubscriber
    {
        private readonly Blog _blog;

        public BlogAdmin(Blog blog)
        {
            _blog = blog;
            _blog.Notify += Update;
        }

        public void Update(string state)
        {
            // Consume state
            Console.WriteLine(string.Format("Blog admin - New state: {0}", state));
        }
    }
}