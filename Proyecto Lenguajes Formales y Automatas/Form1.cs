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
            /*
              {
               List<Node> nodeList = new List<Node>()
             //examples generation
             {
             new Node("L", null, false),
             new Node("O", null, false),
             new Node("J", null, false),
             new Node("B", null, true),
             new Node("F", null, false),
             new Node("C", null, false),
             new Node("K", null, true),
             new Node("M", null, true),
             new Node("H", null, false),
             new Node("D", null, false),
             new Node("N", null, false),
             new Node("A", null, false),
             new Node("I", null, false),
             new Node("G", null, true),
             new Node("E", null, true)
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
                Console.WriteLine(Convert.ToString(momo.BinarySearch(MergedList, new Node("Momo",null, false))));
             }
             */
            
            momo.ReadFile("D:\\Desktop\\DFA.txt");

        }
    }
}
