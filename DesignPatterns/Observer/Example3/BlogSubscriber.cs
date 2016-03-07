using System;

namespace DesignPatterns.Observer.Example3
{
    public class BlogSubscriber : IBlogSubscriber
    {
        private readonly Blog _blog;

        public BlogSubscriber(Blog blog)
        {
            _blog = blog;
            _blog.Notify += Update;
        }

        public void Update(string state)
        {
            // Consume state
            Console.WriteLine(string.Format("Blog subscriber - New state: {0}", state));
        }
    }
}