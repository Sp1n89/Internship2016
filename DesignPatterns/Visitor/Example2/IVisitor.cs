namespace DesignPatterns.Visitor.Example2
{
    public interface IVisitor
    {
        void Visit(Book book);

        void Visit(Fruit fruit);
    }
}