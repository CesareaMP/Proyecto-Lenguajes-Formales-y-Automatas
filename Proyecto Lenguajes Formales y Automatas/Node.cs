using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class Node : IComparable<Node>
    {
        private string Sname;
        private List<Transition> Ltransitions = new List<Transition>();
        private Boolean Bfinal_state;

        public Node(string name, List<Transition> transitions, Boolean finalstate)
        {
            this.Sname = name;
            this.Ltransitions = transitions;
            this.Bfinal_state = finalstate;
        }

        public void SetSname(string name)
        {
            Sname = name;
        } 

        public void SetLtransitions(List<Transition> transitions)
        {
            this.Ltransitions = transitions;
        }

        public void AddLtransitions(Transition transition)
        {
            this.Ltransitions.Add(transition);
        }

        public void SetBfinal_state(Boolean final_state)
        {
            Bfinal_state = final_state;
        }

        public string GetSname()
        {
            return Sname;
        }

        public List<Transition> GetLtransitions()//, string Sstate_destiny
        {
            return Ltransitions;
        }

        public bool GetBfinal_state()
        {
            return Bfinal_state;
        }

        public string Accepted(bool condition)
        {
            if (GetBfinal_state() && condition)
            {
                return "Se acepta la palabra";
            }
            else
            {
                return "No se acepta la palabra";
            }
        }
            
        public Node() { }

        public int CompareTo(Node other)
        {
            return Sname.CompareTo(other.Sname);
        }

    }
  
}
