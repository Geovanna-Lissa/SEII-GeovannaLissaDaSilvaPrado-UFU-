using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana3Tarefa4.BinarySearchTree;

namespace Semana3Tarefa4.BinarySearchTree
{
    public class TreeNode
    {
        public int Key {get; set; }

        public string Value {get; set; }

        public TreeNode Sol {get; set; }

        public TreeNode Lua {get; set; }

        public TreeNode(int key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Binary Search Tree

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3Tarefa4.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root {get; set; } = null;

        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }
        public TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);

            if(node == null)//Criando o ROOT
            {
              node = newNode;
              return node;
            }
            if (key < node.Key)
            {
                node.Lua = InsertItem(node.Lua, key, value);
            }
            else
            {
                node.Sol = InsertItem(node.Sol, key, value);
            }
            return node;
        }
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Binary Trees

using Semana3Tarefa4.BinarySearchTree

binarySearchTree bst = new BinarySearchTree();

bst.Insert(111, "Flores");
bst.Insert(222, "Cachorros");
bst.Insert(333, "Borboleta");
bst.Insert(444, "Estrela");
bst.Insert(555, "Gatos");

int value = 0;
