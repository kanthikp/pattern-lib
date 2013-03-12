using Factory.FactoryMethod.Trees;
using Factory.FactoryMethod.Factories;
using System.Reflection;

namespace Factory.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ITreeFactory treeFactory = LoadFactory();

            ITree tree = treeFactory.CreateTree();

            tree.Grows();
            tree.Dies();
        }

        static ITreeFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.TreeFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as ITreeFactory;
        }
    }
}
