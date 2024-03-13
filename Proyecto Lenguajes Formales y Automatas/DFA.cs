using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Hosting;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class DFA
    {
        private List<Node> Lnodes = new List<Node>();
        private string Sinitial_node;

        public DFA() { }

        public void ReadFile(string path)
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

                List<Transition> transitions = new List<Transition>();
                string linea;

                while ((linea = streamReader.ReadLine()) != null)
                {
                    transitions.Add(new Transition(linea.Split(',')[0], linea.Split(',')[1], linea.Split(',')[2]));
                }

                transitions = MergeSort(transitions);

                PairTransitions(this.Lnodes, transitions);
                SetFinalStates(this.Lnodes, finalstates);

                streamReader.Close();
                
            }
        }

        private void SetFinalStates(List<Node> lnodes, string finalstates)
        {
            for (int i = 0; i < finalstates.Split(',').Count(); i++)
            {
                int index = BinarySearch<Node>(lnodes, new Node(finalstates.Split(',')[i], null, false));
                lnodes[index].SetBfinal_state(true);
            }
        }

        private void PairTransitions(List<Node> lnodes, List<Transition> transitions)
        {
            int contador = 0;
            string actual = transitions[0].GetStateOrigin();

            while (transitions[contador].GetStateOrigin() == actual)
            {
                contador++;
            }
            
            int amountnodes = lnodes.Count;

            for (int i = 0; i < amountnodes; i++)
            {
                lnodes[i].SetSname(transitions[i*contador].GetStateOrigin());
                lnodes[i].SetLtransitions(transitions.GetRange(i*contador,contador));
            }

        }

        private List<T> MergeSort<T>(List<T> nodes) where T : IComparable<T>
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

        private int BinarySearch<T>(List<T> nodes, T key) where T : IComparable<T>
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
