using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        DFA momo = new DFA();

        private void Form1_Load(object sender, EventArgs e)
        {
            //momazos
            {
              List<Node> nodeList = new List<Node>()
            //examples generation
            {
                new Node("L", new List<(string, string)> { ("AL", "SymbolAL"), ("BL", "SymbolBM") }, false),
            new Node("O", new List<(string, string)> { ("AO", "SymbolAO"), ("BO", "SymbolBP") }, false),
            new Node("J", new List<(string, string)> { ("AJ", "SymbolAJ"), ("BJ", "SymbolBK") }, false),
            new Node("B", new List<(string, string)> { ("AB", "SymbolAB"), ("BB", "SymbolBC") }, true),
            new Node("F", new List<(string, string)> { ("AF", "SymbolAF"), ("BF", "SymbolBG") }, false),
            new Node("C", new List<(string, string)> { ("AC", "SymbolAC"), ("BC", "SymbolBD") }, false),
            new Node("K", new List<(string, string)> { ("AK", "SymbolAK"), ("BK", "SymbolBL") }, true),
            new Node("M", new List<(string, string)> { ("AM", "SymbolAM"), ("BM", "SymbolBN") }, true),
            new Node("H", new List<(string, string)> { ("AH", "SymbolAH"), ("BH", "SymbolBI") }, false),
            new Node("D", new List<(string, string)> { ("AD", "SymbolAD"), ("BD", "SymbolBE") }, false),
            new Node("N", new List<(string, string)> { ("AN", "SymbolAN"), ("BN", "SymbolBO") }, false),
            new Node("A", new List<(string, string)> { ("AA", "SymbolAA"), ("BA", "SymbolAB") }, false),
            new Node("I", new List<(string, string)> { ("AI", "SymbolAI"), ("BI", "SymbolBJ") }, false),
            new Node("G", new List<(string, string)> { ("AG", "SymbolAG"), ("BG", "SymbolBH") }, true),
            new Node("E", new List<(string, string)> { ("AE", "SymbolAE"), ("BE", "SymbolBF") }, true)
        };

            //print unsorted list
            {
                Console.WriteLine("Unsorted Node List:");
                foreach (Node node in nodeList)
                {
                    Console.WriteLine(node.GetSname() + "," + node.GetLtransitions().Count + "," + node.GetBfinal_state());
                }
            }

            List<Node> MergedList = momo.MergeSort(nodeList);

            {
                Console.WriteLine("");
                Console.WriteLine("Sorted Node List:");
                foreach (Node node in MergedList)
                {
                    Console.WriteLine(node.GetSname() + "," + node.GetLtransitions().Count + "," + node.GetBfinal_state());
                }
            }
                Console.WriteLine(Convert.ToString(momo.BinarySearch(MergedList, "M")));
            }

        }
    }
}
