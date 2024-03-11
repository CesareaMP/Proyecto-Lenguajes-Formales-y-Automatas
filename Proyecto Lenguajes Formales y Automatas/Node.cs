using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class Node
    {
        private string Sname;
        private List<(string Strans_name, string Ssymbol)> Ltransitions;
        private Boolean Bfinal_state;

        public Node(string name, List<(string, string)> transitions, Boolean finalstate)
        {
            this.Sname = name;
            this.Ltransitions = transitions;
            this.Bfinal_state = finalstate;
        }

        public Node() { }
    }
}
