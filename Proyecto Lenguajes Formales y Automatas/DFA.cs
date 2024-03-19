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
                    //Se comprueba si se ha recorrido todo el string input o si el caracter actual esta en el lenguaje
                    if (i == Sinput.Length - 1 || Llanguage.Contains(Sinput[i].ToString()))
                    {
                        //Se termina el algoritmo
                        failed = true;
                    }

                    //Obtenemos todas las transiciones del nodo actual
                    TransitionsOfCurrentNode = currentNode.GetLtransitions();
                    //declaramos foundNext como falso
                    foundNext = false;
                    //Recorremos cada transicion del nodo actual
                    for (int j = 0; j <= TransitionsOfCurrentNode.Count(); j++) 
                    {
                        //Si no se ha encontrado el siguiente nodo y no ha fallado
                        if (!foundNext && failed == false) 
                        {
                            //Si ya se comprobaron todas las transiciones (esto significa que no hay una transicion valida con el caracter actual)
                            if (j == TransitionsOfCurrentNode.Count())
                            {
                                //Se detiene
                                failed = true;
                                recorrido += "No se acepta, no hay una transicion con el caracter " + Sinput[i].ToString() + " a partir del nodo actual";
                            }
                            else if (Sinput[i].ToString().Equals(TransitionsOfCurrentNode[j].GetSymbol()) && failed == false) //Se comprueba que el caracter sea el mismo que el de la transicion
                            {
                                //Se escribe el nodo en el que esta y con que caracter hace la transicion
                                recorrido += currentNode.GetSname() + "->" + Sinput[i].ToString()+"->";
                                //Se cambia al siguiente nodo y se declara foundnext como true (esto hara que ya no se recorran las transiciones restantes)
                                currentNode = getNodeByName(TransitionsOfCurrentNode[j].GetStateDestiny());
                                foundNext = true;
                                //Se escribe hacia que nodo va
                                recorrido += currentNode.GetSname() + "\n";

                                //Si es el ultimo caracter del string
                                if (i == Sinput.Length - 1) 
                                {
                                    //Se comprueba si es final o no
                                    if (currentNode.GetBfinal_state() == true)
                                    {
                                        recorrido += "Es un nodo final, por ende se acepta!";
                                    }
                                    else 
                                    {
                                        recorrido += "Es un nodo no final, por ende no se acepta!";
                                    }
                                    //Se termina de recorrer
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
