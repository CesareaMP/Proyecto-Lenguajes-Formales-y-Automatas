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
        private List<(string Sstate_origin, string Ssymbol)> Ltransitions;//, string Sstate_destiny
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

        public List<(string Sstate_origin, string Ssymbol)> GetLtransitions()//, string Sstate_destiny
        {
            return Ltransitions;
        }

        public bool GetBfinal_state()
        {
            return Bfinal_state;
        }
            
        public Node() { }

        public int CompareTo(Node other)
        {
            // Parse numbers from strings
            string[] xParts = System.Text.RegularExpressions.Regex.Split(this.Sname, @"(\d+)");
            string[] yParts = System.Text.RegularExpressions.Regex.Split(other.Sname, @"(\d+)");

            for (int i = 0; i < Math.Min(xParts.Length, yParts.Length); i++)
            {
                // If both parts are numeric, parse and compare numerically
                int xNum, yNum;
                if (int.TryParse(xParts[i], out xNum) && int.TryParse(yParts[i], out yNum))
                {
                    int comparison = xNum.CompareTo(yNum);
                    if (comparison != 0)
                        return comparison;
                }
                else
                {
                    // If either part is not numeric, compare lexically
                    int comparison = xParts[i].CompareTo(yParts[i]);
                    if (comparison != 0)
                        return comparison;
                }
            }

            // If all parts are equal, compare the lengths
            return this.Sname.Length.CompareTo(other.Sname.Length);
        }



    }
}
