﻿namespace Proyecto_Lenguajes_Formales_y_Automatas
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.ltRECORRIDO = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tbcDFA.SuspendLayout();
            this.tbcNFA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSELECTDFA
            // 
            this.btnSELECTDFA.Location = new System.Drawing.Point(28, 22);
            this.btnSELECTDFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSELECTDFA.Name = "btnSELECTDFA";
            this.btnSELECTDFA.Size = new System.Drawing.Size(125, 66);
            this.btnSELECTDFA.TabIndex = 0;
            this.btnSELECTDFA.Text = "Select DFA Files";
            this.btnSELECTDFA.UseVisualStyleBackColor = true;
            this.btnSELECTDFA.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDFA
            // 
            this.cmbDFA.Enabled = false;
            this.cmbDFA.FormattingEnabled = true;
            this.cmbDFA.Location = new System.Drawing.Point(183, 55);
            this.cmbDFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDFA.Name = "cmbDFA";
            this.cmbDFA.Size = new System.Drawing.Size(200, 24);
            this.cmbDFA.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcDFA);
            this.tabControl1.Controls.Add(this.tbcNFA);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 318);
            this.tabControl1.TabIndex = 2;
            // 
            // tbcDFA
            // 
            this.tbcDFA.Controls.Add(this.ltRECORRIDO);
            this.tbcDFA.Controls.Add(this.label1);
            this.tbcDFA.Controls.Add(this.btnTESTDFA);
            this.tbcDFA.Controls.Add(this.txtWORDDFA);
            this.tbcDFA.Controls.Add(this.lblTRYDFA);
            this.tbcDFA.Controls.Add(this.lblSELECTDFA);
            this.tbcDFA.Controls.Add(this.btnSELECTDFA);
            this.tbcDFA.Controls.Add(this.cmbDFA);
            this.tbcDFA.Location = new System.Drawing.Point(4, 25);
            this.tbcDFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcDFA.Name = "tbcDFA";
            this.tbcDFA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcDFA.Size = new System.Drawing.Size(800, 289);
            this.tbcDFA.TabIndex = 0;
            this.tbcDFA.Text = "DFA";
            this.tbcDFA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recorrido:";
            // 
            // btnTESTDFA
            // 
            this.btnTESTDFA.Location = new System.Drawing.Point(92, 162);
            this.btnTESTDFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTESTDFA.Name = "btnTESTDFA";
            this.btnTESTDFA.Size = new System.Drawing.Size(197, 91);
            this.btnTESTDFA.TabIndex = 5;
            this.btnTESTDFA.Text = "TEST";
            this.btnTESTDFA.UseVisualStyleBackColor = true;
            this.btnTESTDFA.Click += new System.EventHandler(this.btnTESTDFA_Click);
            // 
            // txtWORDDFA
            // 
            this.txtWORDDFA.Enabled = false;
            this.txtWORDDFA.Location = new System.Drawing.Point(183, 110);
            this.txtWORDDFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWORDDFA.Name = "txtWORDDFA";
            this.txtWORDDFA.Size = new System.Drawing.Size(200, 22);
            this.txtWORDDFA.TabIndex = 4;
            // 
            // lblTRYDFA
            // 
            this.lblTRYDFA.AutoSize = true;
            this.lblTRYDFA.Location = new System.Drawing.Point(25, 114);
            this.lblTRYDFA.Name = "lblTRYDFA";
            this.lblTRYDFA.Size = new System.Drawing.Size(129, 16);
            this.lblTRYDFA.TabIndex = 3;
            this.lblTRYDFA.Text = "Enter the word to test";
            // 
            // lblSELECTDFA
            // 
            this.lblSELECTDFA.AutoSize = true;
            this.lblSELECTDFA.Location = new System.Drawing.Point(196, 30);
            this.lblSELECTDFA.Name = "lblSELECTDFA";
            this.lblSELECTDFA.Size = new System.Drawing.Size(165, 16);
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
            this.tbcNFA.Location = new System.Drawing.Point(4, 25);
            this.tbcNFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcNFA.Name = "tbcNFA";
            this.tbcNFA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcNFA.Size = new System.Drawing.Size(800, 289);
            this.tbcNFA.TabIndex = 1;
            this.tbcNFA.Text = "NFA";
            this.tbcNFA.UseVisualStyleBackColor = true;
            // 
            // btnTESTNFA
            // 
            this.btnTESTNFA.Location = new System.Drawing.Point(92, 171);
            this.btnTESTNFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTESTNFA.Name = "btnTESTNFA";
            this.btnTESTNFA.Size = new System.Drawing.Size(197, 91);
            this.btnTESTNFA.TabIndex = 11;
            this.btnTESTNFA.Text = "TEST";
            this.btnTESTNFA.UseVisualStyleBackColor = true;
            // 
            // txtWORDNFA
            // 
            this.txtWORDNFA.Location = new System.Drawing.Point(183, 119);
            this.txtWORDNFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWORDNFA.Name = "txtWORDNFA";
            this.txtWORDNFA.Size = new System.Drawing.Size(200, 22);
            this.txtWORDNFA.TabIndex = 10;
            // 
            // lblTRYNFA
            // 
            this.lblTRYNFA.AutoSize = true;
            this.lblTRYNFA.Location = new System.Drawing.Point(25, 122);
            this.lblTRYNFA.Name = "lblTRYNFA";
            this.lblTRYNFA.Size = new System.Drawing.Size(129, 16);
            this.lblTRYNFA.TabIndex = 9;
            this.lblTRYNFA.Text = "Enter the word to test";
            // 
            // lblSELECTNFA
            // 
            this.lblSELECTNFA.AutoSize = true;
            this.lblSELECTNFA.BackColor = System.Drawing.Color.Transparent;
            this.lblSELECTNFA.Location = new System.Drawing.Point(196, 39);
            this.lblSELECTNFA.Name = "lblSELECTNFA";
            this.lblSELECTNFA.Size = new System.Drawing.Size(165, 16);
            this.lblSELECTNFA.TabIndex = 8;
            this.lblSELECTNFA.Text = "Select the appropiate NFA";
            // 
            // btnSELECTNFA
            // 
            this.btnSELECTNFA.Location = new System.Drawing.Point(28, 30);
            this.btnSELECTNFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSELECTNFA.Name = "btnSELECTNFA";
            this.btnSELECTNFA.Size = new System.Drawing.Size(125, 66);
            this.btnSELECTNFA.TabIndex = 6;
            this.btnSELECTNFA.Text = "Select NFA Files";
            this.btnSELECTNFA.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 64);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // ltRECORRIDO
            // 
            this.ltRECORRIDO.FormattingEnabled = true;
            this.ltRECORRIDO.ItemHeight = 16;
            this.ltRECORRIDO.Location = new System.Drawing.Point(428, 41);
            this.ltRECORRIDO.Name = "ltRECORRIDO";
            this.ltRECORRIDO.Size = new System.Drawing.Size(351, 228);
            this.ltRECORRIDO.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 384);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ListBox ltRECORRIDO;
    }
}

