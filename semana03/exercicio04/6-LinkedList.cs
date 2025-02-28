///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Node

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana3Tarefa4.LinkedList;

namespace Semana3Tarefa4.LinkedList
{
    public class Node
    {
        public int Data {get; set; }

        public Node? Next {get; set; }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Linked-List

using Semana3Tarefa4.LinkedList;

Node nodeA = new Node();
nodeA.Data = 111;

Node nodeB = new Node();
nodeB.Data = 222;

Node nodeC = new Node();
nodeC.Data = 333;

Node nodeD = new Node();
nodeD.Data = 444;

nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Creando o node

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana3Tarefa4.LinkedList;

namespace Semana3Tarefa4.LinkedList
{
    public class Node
    {
        public int First {get; set; }

        public void InsertFirst(int data)
        {
            //Criando o node 
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = First;
            First = newNode;
        }
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Deletando 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana3Tarefa4.LinkedList;

namespace Semana3Tarefa4.LinkedList
{
    public class Node
    {
        public int First {get; set; }

        public void InsertFirst(int data)
        {
            //Criando o node 
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = First;
            First = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }
        
    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Iterate

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana3Tarefa4.LinkedList;

namespace Semana3Tarefa4.LinkedList
{
    public class Node
    {
        public int First {get; set; }

        public void InsertFirst(int data)
        {
            //Criando o node 
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = First;
            First = newNode;
        }
        public void DisplayList()
        {
            Console.WriteLine("Iterando a lista");
            Node current = First;
            while(current != null);
            {
                current.DisplayNode();
                current = current.Next;
            }
        }    
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Criando uma Linked-List para deletar

using Semana3Tarefa4.LinkedList;

LinkedList linkedList = new LinkedList();
linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);

linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertLast(444);
linkedList.InsertLast(333);

linkedList.DisplayList();

