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

        public string TransitionToString()
        {
            return Sstate_origin + "->" + Ssymbol + "->" + Sstate_destiny;
        }
        public int CompareTo(Transition other)
        {
            return Sstate_origin.CompareTo(other.Sstate_origin);
        }

    }
}
