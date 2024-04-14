using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Hosting;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class DFA : Automaton
    {


        public DFA(string path) : base(path) 
        {

        }


        public string Verify(string Sinput)
        {
            string route = "";//string name, List<Transition> transitions, Boolean finalstate
            int Iinital = BinarySearch(getLStates(), new Node(getSinitial_node(), null, false));
            Node Nactual = getLStates()[Iinital];      
            bool Baccepted = true;

            foreach (char Actual in Sinput)
            {
                if (getLlanguage().Contains(Convert.ToString(Actual)))
                {
                    int Iindex_transition = LinealSearchT(Nactual, Actual);
                    route += Nactual.GetLtransitions()[Iindex_transition].TransitionToString() + "\n";
                    Iinital = BinarySearch(getLStates(), new Node(Nactual.GetLtransitions()[Iindex_transition].GetStateDestiny(), null, false));
                    Nactual = getLStates()[Iinital];
                }
                else
                {
                    Baccepted = false;
                    route += "El simbolo: " + Actual + " no se encuentra en el lenguaje\n";
                    break;
                }
            }

            route += Nactual.Accepted(Baccepted);

            return route;
        }

        int LinealSearchT(Node node, char Sinput)
        {
            for (int i = 0; i <node.GetLtransitions().Count; i++)
            {
                if (node.GetLtransitions()[i].GetSymbol() == Convert.ToString(Sinput))
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
