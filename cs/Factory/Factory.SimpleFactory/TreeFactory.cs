using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace Factory.SimpleFactory
{
    class TreeFactory
    {
        Dictionary<string, Type> trees;

        public TreeFactory() {
            LoadTypesICanReturn();
        }
        public ITree CreateInstance(string treeName){
            Type t = GetTypeToCreate(treeName);

            if (t == null) return new NullTree();

            return Activator.CreateInstance(t) as ITree;

        }
        Type GetTypeToCreate(string treeName){
            foreach( var tree in trees){
                if (tree.Key.Contains(treeName))
                    return trees[tree.Key];
            }
            return null;
        }
        void LoadTypesICanReturn() {

            trees = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type t in typesInThisAssembly) {

                if (t.GetInterface(typeof(ITree).ToString()) != null) 
                    trees.Add(t.Name.ToLower(), t);
            }
        }
    }
}
