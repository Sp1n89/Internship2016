namespace DesignPatterns.Visitor.Example1
{
    public abstract class ElementBase
    {
        public abstract void Accept(IVisitor visitor);
    }
}