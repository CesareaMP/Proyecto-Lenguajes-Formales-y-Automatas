using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    internal class NFA : Automaton
    {



        public NFA(string path) : base(path)
        {

        }

        public List<string> SimulateAllPaths(string input)
        {
            List<string> results = new List<string>();
            Dictionary<string, int> stateVisits = new Dictionary<string, int>();
            SimulatePathRecursive(getSinitial_node(), input, "", results, stateVisits);
            return results;
        }


        private void SimulatePathRecursive(string currentState, string remainingInput, string currentPath, List<string> results, Dictionary<string, int> stateVisits)
        {
            string stateInputKey = $"{currentState}:{remainingInput}";
            if (!stateVisits.ContainsKey(stateInputKey))
            {
                stateVisits[stateInputKey] = 0;
            }
            stateVisits[stateInputKey]++;

            if (stateVisits[stateInputKey] > 3)  // Evita bucles infinitos
            {
                results.Add(currentPath + " -> Ciclo detectado, parando recursión");
                return;
            }

            Node state = getLStates().FirstOrDefault(s => s.GetSname() == currentState);
            if (state == null)
            {
                results.Add(currentPath + " -> Estado no encontrado");
                return;
            }

            string newPath = currentPath + (string.IsNullOrEmpty(currentPath) ? "" : " -> ") + currentState;

            if (string.IsNullOrEmpty(remainingInput))
            {
                results.Add(newPath + (state.GetBfinal_state() ? " -> Aceptado" : " -> Rechazado (sin entrada restante)"));
                return;
            }

            bool foundTransition = false;

            foreach (var transition in state.GetLtransitions())
            {
                if (!string.IsNullOrEmpty(transition.GetSymbol()) && remainingInput.StartsWith(transition.GetSymbol()))
                {
                    foundTransition = true;
                    string nextInput = remainingInput.Substring(transition.GetSymbol().Length);
                    SimulatePathRecursive(transition.GetStateDestiny(), nextInput, newPath + " -[" + transition.GetSymbol() + "]-> " + transition.GetStateDestiny(), results, stateVisits);
                }
                else if (string.IsNullOrEmpty(transition.GetSymbol()))
                {
                    foundTransition = true;
                    SimulatePathRecursive(transition.GetStateDestiny(), remainingInput, newPath + " -[ε]-> " + transition.GetStateDestiny(), results, stateVisits);
                }
            }

            if (!foundTransition)  // No se encontraron transiciones válidas
            {
                results.Add(newPath + " -> Rechazado (sin transiciones válidas para '" + remainingInput + "')");
            }
        }



    }
}
