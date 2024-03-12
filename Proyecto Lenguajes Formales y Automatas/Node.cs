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

        public void SetSname(string name)
        {
            Sname = name;
        } 

        public void SetLtransitions(List<(string, string)> transitions)
        {
            this.Ltransitions = transitions;
        }

        public void SetBfinal_state(Boolean final_state)
        {
            Bfinal_state = final_state;
        }

        public string GetSname()
        {
            return Sname;
        }

        public List<(string Strans_name, string Ssymbol)> GetLtransitions()
        {
            return Ltransitions;
        }

        public bool GetBfinal_state()
        {
            return Bfinal_state;
        }
        public Node() { }
    }
}
