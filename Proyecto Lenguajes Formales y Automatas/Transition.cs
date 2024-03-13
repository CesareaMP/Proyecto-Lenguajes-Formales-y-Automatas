using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class Transition : IComparable<Transition>
    {
        private string Sstate_origin;
        private string Ssymbol;
        private string Sstate_destiny;

        public Transition(string state_origin, string symbol, string state_destiny)
        {
            Sstate_origin = state_origin;
            Ssymbol = symbol;
            Sstate_destiny = state_destiny;
        }

        public Transition() { }

        public string GetStateOrigin()
        {
            return Sstate_origin;
        }

        public void SetStateOrigin(string value)
        {
            Sstate_origin = value;
        }

        // Getter and Setter for Ssymbol
        public string GetSymbol()
        {
            return Ssymbol;
        }

        public void SetSymbol(string value)
        {
            Ssymbol = value;
        }

        // Getter and Setter for Sstate_destiny
        public string GetStateDestiny()
        {
            return Sstate_destiny;
        }

        public void SetStateDestiny(string value)
        {
            Sstate_destiny = value;
        }

        public int CompareTo(Transition other)
        {
            // Parse numbers from strings
            string[] xParts = System.Text.RegularExpressions.Regex.Split(this.Sstate_origin, @"(\d+)");
            string[] yParts = System.Text.RegularExpressions.Regex.Split(other.Sstate_origin, @"(\d+)");

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
            return this.Sstate_origin.Length.CompareTo(other.Sstate_origin.Length);
        }

    }
}
