using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOmega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();           
            tree.InsertRand();
            tree.Enter();
            tree.Print(tree);
            tree.Find();
            tree.Remove();

            Tree treeAfterRemove = new Tree();
            treeAfterRemove.OrigNumbers = tree.OrigNumbers;            
            treeAfterRemove.Enter();
            treeAfterRemove.Print(treeAfterRemove);


        }

    }
}