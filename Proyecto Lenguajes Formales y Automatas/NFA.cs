using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class NFA : Automaton
    {
        
        List<(int current, Transition destiny)> Lactual_matches = new List<(int current, Transition destiny)>();
        public NFA(string path) : base(path)
        {
            
        }
       
        public List<string> Verify(string Sinput)
        {   
            List<string> paths = new List<string>();
            int current = BinarySearch(getLStates(), new Node(getSinitial_node(), null, false));
            Node Nactual = getLStates()[current];
            Lactual_matches.Add((0,new Transition("1","","1")));           
            for (int i = 0; i < Lactual_matches.Count; i++)
            {
                var actualpath = Lactual_matches[i];
                current = BinarySearch(getLStates(), new Node(actualpath.destiny.GetStateDestiny(), null, false));
                Nactual = getLStates()[current];
                string path = "";
                List<(int current, Transition destiny)> temporal = AllTransitions(Nactual,Sinput, actualpath.current);
                if (actualpath.current == Sinput.Length)
                {

                    for (int j = 1; j < Lactual_matches.Count-1; j++)
                    {
                        path += Lactual_matches[j].destiny.TransitionToString() + "\n";
                        Lactual_matches.RemoveAt(j);
                        j--;
                        i--;
                    }
                    if (Nactual.GetBfinal_state()) path += "PALABRA ACEPTADA POR ESTA RUTA";
                    else path += "PALABRA NO ACEPTADA POR ESTA RUTA";
                    paths.Add(path);

                }

                if (actualpath.current != Sinput.Length)
                {
                    if (temporal.Count > 0)
                    {
                        Lactual_matches.InsertRange(i + 1, temporal);
                    }
                    else
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            path += Lactual_matches[j].destiny.TransitionToString() + "\n";
                            Lactual_matches.RemoveAt(j);
                            i--;
                            j--;
                        }
                        path += "PALABRA NO ACEPTADA POR ESTA RUTA";
                        paths.Add(path);

                    }
                }
            }
            return paths;
        }

        List<(int current, Transition destiny)> AllTransitions (Node node,string input, int current)
        {
            List<(int current, Transition destiny)> pathss = new List<(int current, Transition destiny)> ();

            string actualinput = "";

            for (int i = current; i < input.Length; i++)
            {
                actualinput += input[i];

                for (int j = 0; j < node.GetLtransitions().Count; j++)
                {
                    if (node.GetLtransitions()[j].GetSymbol() == actualinput)
                    {
                        pathss.Add((actualinput.Length+current, node.GetLtransitions()[j]));
                    }
                }
            }

            if (pathss.Count == 0 || getLlanguage().Contains(""))
            {
                actualinput = "";
                for (int j = 0; j < node.GetLtransitions().Count; j++)
                {
                    if (node.GetLtransitions()[j].GetSymbol() == "")
                    {
                        pathss.Add((current, node.GetLtransitions()[j]));
                    }
                }
            }

            return pathss;
        }

    }
}
