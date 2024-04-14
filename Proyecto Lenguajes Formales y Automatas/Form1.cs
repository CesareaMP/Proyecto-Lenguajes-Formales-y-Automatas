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

namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        List<DFA> dfas = new List<DFA>();

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
            int Icurrent_momomaton = cmbDFA.SelectedIndex;

            DFA Nactual_dfa = dfas.ElementAt(Icurrent_momomaton);

            string recorrido = Nactual_dfa.RunDFAString(txtWORDDFA.Text);

            string[] lines = recorrido.Split('\n');
            foreach (string line in lines)
            {
                txtRecorrido.AppendText(line + Environment.NewLine);
            }
        }
    }
}
