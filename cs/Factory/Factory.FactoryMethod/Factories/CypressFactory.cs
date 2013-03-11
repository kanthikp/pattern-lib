using Factory.FactoryMethod.Trees;
namespace Factory.FactoryMethod.Factories
{
    class CypressFactory : ITreeFactory
    {
        Trees.ITree ITreeFactory.CreateTree()
        {
            var cypress = new Cypress("Austrocedrus chilensis");
            return cypress;
        }
    }
}
