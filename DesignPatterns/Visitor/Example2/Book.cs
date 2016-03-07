using DesignPatterns.Visitor.Example1;

namespace DesignPatterns.Visitor.Example2
{
    public class Book : IItem
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Book(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}