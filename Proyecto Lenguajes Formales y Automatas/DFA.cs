using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class DFA
    {
        private List<Node> Lnodes;
        private string Sinitial_node;

        public DFA() { }

        private void ReadFile(string path)
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {                    
                int amount = Convert.ToInt32(streamReader.ReadLine());//cantidad de estados
                this.Sinitial_node = streamReader.ReadLine();//estado inicial
                string finalstates = streamReader.ReadLine();//estados finales

                while (amount > 0) {
                    this.Lnodes.Add(new Node());
                    amount--;
                }

                List<(string Sstate_origin, string Ssymbol, string Sstate_destiny)> transitions = new List<(string Strans_name, string Ssymbol, string Sstate_destiny)>();

                while (streamReader.ReadLine() != null)
                {

                }

            }
        }

        public List<T> MergeSort<T>(List<T> nodes) where T : IComparable<T>
        {
            if (nodes.Count == 1)
            {
                return nodes;
            }
            int half = (int)Math.Round(nodes.Count / 2.0);
            List<T> Lsplited_list1 = nodes.GetRange(0, half);
            List<T> Lsplited_list2 = nodes.GetRange(half, (nodes.Count - half));

            Lsplited_list1 = MergeSort(Lsplited_list1);
            Lsplited_list2 = MergeSort(Lsplited_list2);

            return Merge(Lsplited_list1, Lsplited_list2);
        }

        private List<T> Merge<T>(List<T> Lsplited_list1, List<T> Lsplited_list2) where T : IComparable<T> 
        {
            List<T> MergedList = new List<T>();

            while (Lsplited_list1.Count != 0 && Lsplited_list2.Count != 0) {
                if (Lsplited_list1[0].CompareTo(Lsplited_list2[0])>0)
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

        public int BinarySearch<T>(List<T> nodes, T key) where T : IComparable<T>   
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
                int comparisonResult = nodes[mid].CompareTo(key);

                if (comparisonResult == 0)
                {
                    return mid;
                }
                else if (comparisonResult > 0)
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

    }
}
