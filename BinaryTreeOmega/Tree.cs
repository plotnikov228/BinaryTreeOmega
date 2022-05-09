using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOmega
{
    internal class Tree
    {
        public long? Value { get; private set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }
        public Tree Parent { get; set; }

        public List<long> OrigNumbers = new List<long>();
        public void InsertRand()
        {

            Random rnd = new Random();

            int l = 20;
            for (int i = 0; i <= l; i++) OrigNumbers.Add(1);

            for (int i = 0; i <= l - 1; i++)
            {

                OrigNumbers.Insert(i, rnd.Next(1, 25));
                OrigNumbers.RemoveAt(i+1);
            }

            OrigNumbers.RemoveAt(OrigNumbers.Count - 1);
            OrigNumbers.Distinct().ToList();
        }
        public void Enter() 
        {
            for(int i = 0; i <= OrigNumbers.Count - 1; i++)
            {
                Insert(OrigNumbers[i]);
            }
        }
        public void Find()
        {
            bool Complete = false;
            Console.WriteLine("Введите элемент который хотите найти: ");
            string s = Console.ReadLine();
            int l = int.Parse(s);
            Console.WriteLine(" ");

            for (int i = 0; i <= OrigNumbers.Count - 1; i++)
            {
                if (OrigNumbers[i] == l)
                {

                    Complete = true;
                    break;
                }
            }

            if (Complete == true) Console.WriteLine($"Элемент {l} был найден");

            if (Complete == false) Console.WriteLine($"Элемент {l} не был найден");
        }
        public void Remove()
        {
            bool Complete = false;
            Console.WriteLine("Введите элемент который хотите удалить: ");
            string s = Console.ReadLine();
            int l = int.Parse(s);
            Console.WriteLine(" ");

            for (int i = 0; i <= OrigNumbers.Count - 1; i++)
            {
                if (OrigNumbers[i] == l)
                {
                    OrigNumbers.RemoveAt(i);
                    Complete = true;
                    break;
                }
            }

            if (Complete == true)
            {
                Console.WriteLine($"Элемент {l} был удалён");   
                Console.WriteLine(" ");
            }
            if (Complete == false) Console.WriteLine($"Элемент {l} не был найден");
        }
        public void Insert(long value)
        {
            if (Value == null)
            {
                Value = value;
                return;
            }

            if (Value < value)
            {
                if(Right == null) Right = new Tree();
                Insert(value, Right, this);
            }

            if (Value > value)
            {
                if (Left == null) Left = new Tree();
                Insert(value, Left, this);
            }
        }
        public void Insert(long value, Tree node, Tree parent)
        {
            if (node.Value == null)
            {
                node.Value = value;
                node.Parent = parent;
                return;
            }

            if (node.Value < value)
            {
                if (node.Right == null) node.Right = new Tree();
                Insert(value, node.Right, node);
            }

            if (node.Value > value)
            {
                if (node.Left == null) node.Left = new Tree();
                Insert(value, node.Left, node);
            }
        }
        public void Print(Tree node)
        {
            if (node != null)
            {
                if (node.Parent != null)
                {                    
                    if (node.Parent.Left == node)
                    {
                        Console.WriteLine("Parent = {1}, Left = {0}", node.Value, node.Parent.Value);
                        Console.WriteLine(" ");
                    }

                    if (node.Parent.Right == node)
                    {
                        Console.WriteLine("Parent = {1}, Right = {0}", node.Value, node.Parent.Value);
                        Console.WriteLine(" ");
                    }
                }
                if (node.Left != null)
                {
                    Print(node.Left);
                }
                if (node.Right != null)
                {
                    Print(node.Right);
                }
            }
        }
    }
}
