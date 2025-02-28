using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3Tarefa4.Tasks;
{
    public class Stack
    {
        public int MaxSize {get; set; }
        
        public string[] tackArray {get; set; }

        public int Top {get; set; }

        public Stack(int size)
        {
            this.MaxSize = size;
            this.StackArray = new string[MaxSize];
            this.Top = -1;
        }
        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;
        }
        public string Pop()
        {
            int old_top = Top;
            Top--;
            return StackArray[old_top];
        }
        public string Peek()
        {
            return StackArray[Top];
        }
        public bool isEmpty()
        {
            return Top == 0;
        }
        public bool isFull()
        {
            return MaxSize (-1 == Top);
        }
    }
}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Stack 

using Semana3Tarefa4.Stack;

Stack stack = new Stack(10);

for(int i = 0; i < 3; i++)
{
    stack.Push("Flores");
    stack.Push("Cachorros");
    stack.Push("Borboletas");
}

stack.Pop();
stack.Peek();

while(!stack.isEmpty())
{
    var var = stack.Pop();
    Console.WriteLine(var);
}