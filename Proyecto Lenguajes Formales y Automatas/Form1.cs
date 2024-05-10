using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        List<DFA> dfas = new List<DFA>();
        List<NFA> nfas = new List<NFA>();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "All Files (*.*)|*.*";
                choofdlog.FilterIndex = 1;
                choofdlog.Multiselect = true;//crikoseada para recibir varios archivos xddd

                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    string[] arrAllFiles = choofdlog.FileNames;//D:\\Desktop\\AFD's\\AFD1.txt                
                    for (int i = 0; i < arrAllFiles.Count(); i++)
                    {
                        string fileName = Path.GetFileName(arrAllFiles[i]);                        
                        DFA temp = new DFA(arrAllFiles[i]);
                        dfas.Add(temp);
                        cmbDFA.Items.Add(fileName);
                    }
                    this.cmbDFA.Enabled = true;
                    this.txtWORDDFA.Enabled = true;
                    cmbDFA.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo no es válido");
            }
        }

        private void btnTESTDFA_Click(object sender, EventArgs e)
        {
            ltRECORRIDO.Items.Clear();

            int Icurrent_momomaton = cmbDFA.SelectedIndex;

            DFA Nactual_dfa = dfas.ElementAt(Icurrent_momomaton);

            string recorrido = Nactual_dfa.Verify(txtWORDDFA.Text);

            string[] lines = recorrido.Split('\n');
            foreach (string line in lines)
            {
                ltRECORRIDO.Items.Add(line + Environment.NewLine);
            }

            txtWORDDFA.Text = "";
        }

        private void btnSELECTNFA_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "All Files (*.*)|*.*";
                choofdlog.FilterIndex = 1;
                choofdlog.Multiselect = true;//crikoseada para recibir varios archivos xddd

                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    string[] arrAllFiles = choofdlog.FileNames;//D:\\Desktop\\AFD's\\AFD1.txt                
                    for (int i = 0; i < arrAllFiles.Count(); i++)
                    {
                        string fileName = Path.GetFileName(arrAllFiles[i]);
                        NFA temp = new NFA(arrAllFiles[i]);
                        nfas.Add(temp);
                        cmbNFA.Items.Add(fileName);
                    }
                    this.cmbNFA.Enabled = true;
                    this.txtWORDNFA.Enabled = true;
                    cmbNFA.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo no es válido");
            }
        }

        private void btnTESTNFA_Click(object sender, EventArgs e)
        {
            ltRECORRIDOSNFA.Items.Clear();

            int currentAutomatonIndex = cmbNFA.SelectedIndex;

          
            //nfas[0].Verify(txtWORDNFA.Text);
            
            if(currentAutomatonIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un autómata de la lista.");
                return;
            }

            NFA currentNFA = nfas.ElementAt(currentAutomatonIndex);

            if(currentNFA == null)
            {
                MessageBox.Show("No se encontró el autómata seleccionado.");
                return;
            }

            // Usa el método SimulateAllPaths para obtener todos los caminos posibles para la cadena de entrada
            List<string> results = currentNFA.SimulateAllPaths(txtWORDNFA.Text);

            // Agrega cada resultado al ListBox, formateando las transiciones en una sola línea
            foreach (var result in results)
            {
                // Dividir cada parte de la transición y reconstruir en formato compacto
                string[] transitions = result.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder formattedResult = new StringBuilder();
                foreach (var transition in transitions)
                {
                    if (!string.IsNullOrEmpty(formattedResult.ToString()))
                    {
                        formattedResult.Append(" -> ");
                    }
                    formattedResult.Append(transition.Trim());
                }
                ltRECORRIDOSNFA.Items.Add(formattedResult.ToString());
            }

        }
    }
}
