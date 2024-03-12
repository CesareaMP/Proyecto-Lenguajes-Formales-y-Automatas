using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class DFA
    {
        private List<Node> Lnodes;
        private string Sinitial_node;

        public DFA() { }

        public List<Node> MergeSort(List<Node> nodes)
        {
            if (nodes.Count==1)
            {
                return nodes;
            }
            int half = (int)Math.Round(nodes.Count/2.0);
            List<Node> Lsplited_list1 = nodes.GetRange(0, half);
            List<Node> Lsplited_list2 = nodes.GetRange(half, (nodes.Count - half));

            Lsplited_list1 = MergeSort(Lsplited_list1);
            Lsplited_list2 = MergeSort(Lsplited_list2);

            return Merge(Lsplited_list1,Lsplited_list2);
        }

        private List<Node> Merge(List<Node> Lsplited_list1, List<Node> Lsplited_list2)
        {
            List<Node> MergedList = new List<Node>();

            while (Lsplited_list1.Count != 0 && Lsplited_list2.Count != 0){
                if (Higher(Lsplited_list1[0].GetSname(), Lsplited_list2[0].GetSname()))
                {                    
                    MergedList.Add(Lsplited_list2[0]);
                    Lsplited_list2.RemoveAt(0);
                }
                else
                {
                    MergedList.Add(Lsplited_list1[0]);
                    Lsplited_list1.RemoveAt(0);
                }
            }

            while (Lsplited_list1.Count != 0)
            {
                MergedList.Add(Lsplited_list1[0]);
                Lsplited_list1.RemoveAt(0);
            }
            
            while (Lsplited_list2.Count != 0)
            {
                MergedList.Add(Lsplited_list2[0]);
                Lsplited_list2.RemoveAt(0);
            }

            return MergedList;
        }

        private bool Higher(string key1, string key2)
        {
            return key1.CompareTo(key2) > 0;
        }


    }
}
