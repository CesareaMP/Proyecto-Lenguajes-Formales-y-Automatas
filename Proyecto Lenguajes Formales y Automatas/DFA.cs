using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            if (nodes.Count == 1)
            {
                return nodes;
            }
            int half = (int)Math.Round(nodes.Count / 2.0);
            List<Node> Lsplited_list1 = nodes.GetRange(0, half);
            List<Node> Lsplited_list2 = nodes.GetRange(half, (nodes.Count - half));

            Lsplited_list1 = MergeSort(Lsplited_list1);
            Lsplited_list2 = MergeSort(Lsplited_list2);

            return Merge(Lsplited_list1, Lsplited_list2);
        }

        private List<Node> Merge(List<Node> Lsplited_list1, List<Node> Lsplited_list2)
        {
            List<Node> MergedList = new List<Node>();

            while (Lsplited_list1.Count != 0 && Lsplited_list2.Count != 0) {
                if (Compare(Lsplited_list1[0].GetSname(), Lsplited_list2[0].GetSname())>0)
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

        public int BinarySearch(List<Node> nodes, string key)
        {
            if (nodes.Count == 0)
            {
                return -1;
            }

            int low = 0;
            int high = nodes.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparisonResult = Compare(key, nodes[mid].GetSname());

                if (comparisonResult == 0)
                {
                    return mid;
                }
                else if (comparisonResult < 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        private int Compare(string x, string y)
        {
            // Parse numbers from strings
            string[] xParts = System.Text.RegularExpressions.Regex.Split(x, @"(\d+)");
            string[] yParts = System.Text.RegularExpressions.Regex.Split(y, @"(\d+)");

            for (int i = 0; i < Math.Min(xParts.Length, yParts.Length); i++)
            {
                // If both parts are numeric, parse and compare numerically
                int xNum, yNum;
                if (int.TryParse(xParts[i], out xNum) && int.TryParse(yParts[i], out yNum))
                {
                    int comparison = xNum.CompareTo(yNum);
                    if (comparison != 0)
                        return comparison;
                }
                else
                {
                    // If either part is not numeric, compare lexically
                    int comparison = xParts[i].CompareTo(yParts[i]);
                    if (comparison != 0)
                        return comparison;
                }
            }

            // If all parts are equal, compare the lengths
            return x.Length.CompareTo(y.Length);
        }


    }
}
