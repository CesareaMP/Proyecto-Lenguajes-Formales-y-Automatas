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
            string recorrido = "";
            Boolean foundNext = false;

            while (!failed) 
            {
                List<Transition> TransitionsOfCurrentNode = currentNode.GetLtransitions();
                for (int i = 0; i < Sinput.Length; i++) 
                {
                    if (i == Sinput.Length - 1) { failed = true; }
                    TransitionsOfCurrentNode = currentNode.GetLtransitions();
                    foundNext = false;
                    for (int j = 0; j <= TransitionsOfCurrentNode.Count(); j++) 
                    {
                        if (!foundNext) 
                        {
                            if (j == TransitionsOfCurrentNode.Count()) 
                            {
                                failed = true;
                                recorrido += "No se acepta, no hay una transicion con el caracter "+ Sinput[i].ToString() +" a partir del nodo actual";
                            }
                            else if (Sinput[i].ToString().Equals(TransitionsOfCurrentNode[j].GetSymbol()))
                            {
                                recorrido += currentNode.GetSname() + "->" + Sinput[i].ToString()+"->";
                                currentNode = getNodeByName(TransitionsOfCurrentNode[j].GetStateDestiny());
                                foundNext = true;
                                recorrido += currentNode.GetSname() + "\n";

                                if (i == Sinput.Length - 1) 
                                {
                                    if (currentNode.GetBfinal_state() == true)
                                    {
                                        recorrido += "Es un nodo final, por ende se acepta!";
                                    }
                                    else 
                                    {
                                        recorrido += "Es un nodo no final, por ende no se acepta!";
                                    }
                                    failed = true;
                                }
                            }
                        }
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
