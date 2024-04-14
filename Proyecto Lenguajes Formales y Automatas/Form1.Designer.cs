namespace Proyecto_Lenguajes_Formales_y_Automatas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSELECTDFA = new System.Windows.Forms.Button();
            this.cmbDFA = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbcDFA = new System.Windows.Forms.TabPage();
            this.btnTESTDFA = new System.Windows.Forms.Button();
            this.txtWORDDFA = new System.Windows.Forms.TextBox();
            this.lblTRYDFA = new System.Windows.Forms.Label();
            this.lblSELECTDFA = new System.Windows.Forms.Label();
            this.tbcNFA = new System.Windows.Forms.TabPage();
            this.btnTESTNFA = new System.Windows.Forms.Button();
            this.txtWORDNFA = new System.Windows.Forms.TextBox();
            this.lblTRYNFA = new System.Windows.Forms.Label();
            this.lblSELECTNFA = new System.Windows.Forms.Label();
            this.btnSELECTNFA = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbcDFA.SuspendLayout();
            this.tbcNFA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSELECTDFA
            // 
            this.btnSELECTDFA.Location = new System.Drawing.Point(32, 28);
            this.btnSELECTDFA.Name = "btnSELECTDFA";
            this.btnSELECTDFA.Size = new System.Drawing.Size(141, 83);
            this.btnSELECTDFA.TabIndex = 0;
            this.btnSELECTDFA.Text = "Select DFA Files";
            this.btnSELECTDFA.UseVisualStyleBackColor = true;
            this.btnSELECTDFA.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDFA
            // 
            this.cmbDFA.Enabled = false;
            this.cmbDFA.FormattingEnabled = true;
            this.cmbDFA.Location = new System.Drawing.Point(206, 69);
            this.cmbDFA.Name = "cmbDFA";
            this.cmbDFA.Size = new System.Drawing.Size(224, 28);
            this.cmbDFA.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcDFA);
            this.tabControl1.Controls.Add(this.tbcNFA);
            this.tabControl1.Location = new System.Drawing.Point(14, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 398);
            this.tabControl1.TabIndex = 2;
            // 
            // tbcDFA
            // 
            this.tbcDFA.Controls.Add(this.txtRecorrido);
            this.tbcDFA.Controls.Add(this.label1);
            this.tbcDFA.Controls.Add(this.btnTESTDFA);
            this.tbcDFA.Controls.Add(this.txtWORDDFA);
            this.tbcDFA.Controls.Add(this.lblTRYDFA);
            this.tbcDFA.Controls.Add(this.lblSELECTDFA);
            this.tbcDFA.Controls.Add(this.btnSELECTDFA);
            this.tbcDFA.Controls.Add(this.cmbDFA);
            this.tbcDFA.Location = new System.Drawing.Point(4, 29);
            this.tbcDFA.Name = "tbcDFA";
            this.tbcDFA.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbcDFA.Size = new System.Drawing.Size(901, 365);
            this.tbcDFA.TabIndex = 0;
            this.tbcDFA.Text = "DFA";
            this.tbcDFA.UseVisualStyleBackColor = true;
            // 
            // btnTESTDFA
            // 
            this.btnTESTDFA.Location = new System.Drawing.Point(104, 203);
            this.btnTESTDFA.Name = "btnTESTDFA";
            this.btnTESTDFA.Size = new System.Drawing.Size(222, 114);
            this.btnTESTDFA.TabIndex = 5;
            this.btnTESTDFA.Text = "TEST";
            this.btnTESTDFA.UseVisualStyleBackColor = true;
            this.btnTESTDFA.Click += new System.EventHandler(this.btnTESTDFA_Click);
            // 
            // txtWORDDFA
            // 
            this.txtWORDDFA.Enabled = false;
            this.txtWORDDFA.Location = new System.Drawing.Point(206, 137);
            this.txtWORDDFA.Name = "txtWORDDFA";
            this.txtWORDDFA.Size = new System.Drawing.Size(224, 26);
            this.txtWORDDFA.TabIndex = 4;
            // 
            // lblTRYDFA
            // 
            this.lblTRYDFA.AutoSize = true;
            this.lblTRYDFA.Location = new System.Drawing.Point(28, 142);
            this.lblTRYDFA.Name = "lblTRYDFA";
            this.lblTRYDFA.Size = new System.Drawing.Size(162, 20);
            this.lblTRYDFA.TabIndex = 3;
            this.lblTRYDFA.Text = "Enter the word to test";
            // 
            // lblSELECTDFA
            // 
            this.lblSELECTDFA.AutoSize = true;
            this.lblSELECTDFA.Location = new System.Drawing.Point(220, 38);
            this.lblSELECTDFA.Name = "lblSELECTDFA";
            this.lblSELECTDFA.Size = new System.Drawing.Size(198, 20);
            this.lblSELECTDFA.TabIndex = 2;
            this.lblSELECTDFA.Text = "Select the appropiate DFA";
            // 
            // tbcNFA
            // 
            this.tbcNFA.Controls.Add(this.btnTESTNFA);
            this.tbcNFA.Controls.Add(this.txtWORDNFA);
            this.tbcNFA.Controls.Add(this.lblTRYNFA);
            this.tbcNFA.Controls.Add(this.lblSELECTNFA);
            this.tbcNFA.Controls.Add(this.btnSELECTNFA);
            this.tbcNFA.Controls.Add(this.comboBox1);
            this.tbcNFA.Location = new System.Drawing.Point(4, 29);
            this.tbcNFA.Name = "tbcNFA";
            this.tbcNFA.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbcNFA.Size = new System.Drawing.Size(460, 370);
            this.tbcNFA.TabIndex = 1;
            this.tbcNFA.Text = "NFA";
            this.tbcNFA.UseVisualStyleBackColor = true;
            // 
            // btnTESTNFA
            // 
            this.btnTESTNFA.Location = new System.Drawing.Point(104, 214);
            this.btnTESTNFA.Name = "btnTESTNFA";
            this.btnTESTNFA.Size = new System.Drawing.Size(222, 114);
            this.btnTESTNFA.TabIndex = 11;
            this.btnTESTNFA.Text = "TEST";
            this.btnTESTNFA.UseVisualStyleBackColor = true;
            // 
            // txtWORDNFA
            // 
            this.txtWORDNFA.Location = new System.Drawing.Point(206, 149);
            this.txtWORDNFA.Name = "txtWORDNFA";
            this.txtWORDNFA.Size = new System.Drawing.Size(224, 26);
            this.txtWORDNFA.TabIndex = 10;
            // 
            // lblTRYNFA
            // 
            this.lblTRYNFA.AutoSize = true;
            this.lblTRYNFA.Location = new System.Drawing.Point(28, 152);
            this.lblTRYNFA.Name = "lblTRYNFA";
            this.lblTRYNFA.Size = new System.Drawing.Size(162, 20);
            this.lblTRYNFA.TabIndex = 9;
            this.lblTRYNFA.Text = "Enter the word to test";
            // 
            // lblSELECTNFA
            // 
            this.lblSELECTNFA.AutoSize = true;
            this.lblSELECTNFA.BackColor = System.Drawing.Color.Transparent;
            this.lblSELECTNFA.Location = new System.Drawing.Point(220, 49);
            this.lblSELECTNFA.Name = "lblSELECTNFA";
            this.lblSELECTNFA.Size = new System.Drawing.Size(197, 20);
            this.lblSELECTNFA.TabIndex = 8;
            this.lblSELECTNFA.Text = "Select the appropiate NFA";
            // 
            // btnSELECTNFA
            // 
            this.btnSELECTNFA.Location = new System.Drawing.Point(32, 38);
            this.btnSELECTNFA.Name = "btnSELECTNFA";
            this.btnSELECTNFA.Size = new System.Drawing.Size(141, 83);
            this.btnSELECTNFA.TabIndex = 6;
            this.btnSELECTNFA.Text = "Select NFA Files";
            this.btnSELECTNFA.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recorrido:";
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(482, 69);
            this.txtRecorrido.Multiline = true;
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(361, 279);
            this.txtRecorrido.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DFA & NFA Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbcDFA.ResumeLayout(false);
            this.tbcDFA.PerformLayout();
            this.tbcNFA.ResumeLayout(false);
            this.tbcNFA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSELECTDFA;
        private System.Windows.Forms.ComboBox cmbDFA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbcDFA;
        private System.Windows.Forms.TabPage tbcNFA;
        private System.Windows.Forms.Button btnTESTDFA;
        private System.Windows.Forms.TextBox txtWORDDFA;
        private System.Windows.Forms.Label lblTRYDFA;
        private System.Windows.Forms.Label lblSELECTDFA;
        private System.Windows.Forms.Button btnTESTNFA;
        private System.Windows.Forms.TextBox txtWORDNFA;
        private System.Windows.Forms.Label lblTRYNFA;
        private System.Windows.Forms.Label lblSELECTNFA;
        private System.Windows.Forms.Button btnSELECTNFA;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecorrido;
    }
}

