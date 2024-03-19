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
        private List<Node> Lstates = new List<Node>();
        private List<string> Llanguage = new List<string>();
        private string Sinitial_node;
        private Node initialNode;

        public DFA(string path) : base(path) 
        {
            Lstates = getLStates();
            Llanguage = getLlanguage();
            Sinitial_node = getSinitial_node();
            
            for (int i = 0; i < Lstates.Count; i++) 
            {
                if (Lstates[i].GetSname().Equals(Sinitial_node)) 
                {
                    initialNode = Lstates[i];
                }
            }
        }

        public string RunDFAString(String Sinput)
        {
            Node currentNode = initialNode;
            Boolean failed = false;
            string recorrido = initialNode.GetSname()+", ";
            int currentInputPos = 0;

            while (!failed) 
            {
                List<Transition> TransitionsOfCurrentNode = currentNode.GetLtransitions();
                for (int i = 0; i <= TransitionsOfCurrentNode.Count(); i++) 
                {
                    if (i == TransitionsOfCurrentNode.Count()) 
                    {
                        failed = true;
                    }
                    else if (TransitionsOfCurrentNode[i].GetSymbol().Contains(Sinput[currentInputPos])) 
                    {
                        currentNode = getNodeByName(TransitionsOfCurrentNode[i].GetStateDestiny());
                        recorrido += currentNode.GetSname() + ", ";
                        currentInputPos++;
                    }
                }
            }
            return recorrido;
        }

        public Node getNodeByName(string nodeName) 
        {
            for (int i = 0; i < Lstates.Count(); i++) 
            {
                if (Lstates[i].GetSname().Equals(nodeName)) { return Lstates[i]; }
            }
            return null;
        }


    }
}
