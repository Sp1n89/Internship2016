namespace DesignPatterns.Visitor.Example1
{
    public interface IVisitor
    {
        void Visit(Element element);

        void Visit(ElementWithLink element);
    }
}