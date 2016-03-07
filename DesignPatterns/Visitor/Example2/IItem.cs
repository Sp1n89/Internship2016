namespace DesignPatterns.Visitor.Example2
{
    public interface IItem
    {
        void Accept(IVisitor visitor);
    }
}