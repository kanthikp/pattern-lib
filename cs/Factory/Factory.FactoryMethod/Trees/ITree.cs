namespace Factory.FactoryMethod.Trees
{
    public interface ITree
    {
        string Name { get; }
        void Grows();
        void Dies();
        void SetName(string name);
    }
}
