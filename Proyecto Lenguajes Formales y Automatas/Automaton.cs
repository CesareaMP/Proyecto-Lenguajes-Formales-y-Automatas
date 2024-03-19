using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class Automaton
    {
        private List<Node> Lstates = new List<Node>();
        private List<string> Llanguage = new List<string>();
        private string Sinitial_node;

        public Automaton(string path) {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                int amount = Convert.ToInt32(streamReader.ReadLine());//cantidad de estados
                this.Sinitial_node = streamReader.ReadLine();//estado inicial
                string finalstates = Regex.Replace(streamReader.ReadLine(), @"\s", "");//estados finales

                for (int i = 1; i <= amount; i++)
                {
                    this.Lstates.Add(new Node(Convert.ToString(i), new List<Transition>(), false));
                }

                List<Transition> transitions = new List<Transition>();
                string linea;

                while ((linea = streamReader.ReadLine()) != null)
                {
                    transitions.Add(new Transition(Regex.Replace(linea.Split(',')[0], @"\s", ""), Regex.Replace(linea.Split(',')[1], @"\s", ""), Regex.Replace(linea.Split(',')[2], @"\s", "")));
                }

                transitions = MergeSort(transitions);

                this.Llanguage = ObtainLanguage(transitions);
                PairTransitions(this.Lstates, transitions);
                SetFinalStates(this.Lstates, finalstates);

                streamReader.Close();

            }
        }

        private List<string> ObtainLanguage(List<Transition> transitions)
        {
            List<string> language = new List<string>();
            for (int i = 0; i < transitions.Count; i++)
            {
                if (!language.Contains(transitions[i].GetSymbol()))
                {
                    language.Add(Regex.Replace(transitions[i].GetSymbol(), @"\s", ""));
                }
            }
            return language;
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
            int contador = this.Llanguage.Count;
            string actual = Regex.Replace(transitions[0].GetStateOrigin(), @"\s", "");

            for (int i = 0; i < transitions.Count; i++)
            {
                int index = BinarySearch<Node>(lnodes, new Node(Regex.Replace(transitions[i].GetStateOrigin(), @"\s", ""), null, false));
                lnodes[index].AddLtransitions(transitions[i]);
            }

        }

        protected List<T> MergeSort<T>(List<T> nodes) where T : IComparable<T>
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

            while (Lsplited_list1.Count != 0 && Lsplited_list2.Count != 0)
            {
                if (Lsplited_list1[0].CompareTo(Lsplited_list2[0]) > 0)
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

        protected int BinarySearch<T>(List<T> nodes, T key) where T : IComparable<T>
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
