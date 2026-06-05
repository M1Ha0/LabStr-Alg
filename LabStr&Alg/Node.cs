using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProject
{
    public class Node<T>
    {
        public int Index {  get; set; }
        public T? Data { get; set; }
        public List<Node<T>> Neightbors {  get; set; }=new List<Node<T>>();
        public List<int> Weights {  get; set; } = new List<int>();

        public int PreTime { get; set;  }
        public int PostTime { get; set; }

        public override string? ToString()
        {
            //Задание 1
            //return $"Узел с индексом {Index}:{Data}, соседей {Neightbors.Count} Pre:{PreTime} | Post:{PostTime} ";
            //Задание 2
            return $"Узел с индексом {Index}:{Data}, соседей {Neightbors.Count}";
        }
    }
}
