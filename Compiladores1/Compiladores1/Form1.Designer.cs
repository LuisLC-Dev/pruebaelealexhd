namespace Compiladores1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.expresion_regular = new System.Windows.Forms.TextBox();
            this.posfija_res = new System.Windows.Forms.TextBox();
            this.boton_calcular_posfija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generaAFN = new System.Windows.Forms.Button();
            this.tablaAFN = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nEstados = new System.Windows.Forms.Label();
            this.nEpsilon = new System.Windows.Forms.Label();
            this.nEstadosAFD = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAFN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // expresion_regular
            // 
            this.expresion_regular.Location = new System.Drawing.Point(19, 46);
            this.expresion_regular.Name = "expresion_regular";
            this.expresion_regular.Size = new System.Drawing.Size(302, 23);
            this.expresion_regular.TabIndex = 0;
            // 
            // posfija_res
            // 
            this.posfija_res.Location = new System.Drawing.Point(19, 126);
            this.posfija_res.Name = "posfija_res";
            this.posfija_res.Size = new System.Drawing.Size(302, 23);
            this.posfija_res.TabIndex = 1;
            // 
            // boton_calcular_posfija
            // 
            this.boton_calcular_posfija.Location = new System.Drawing.Point(194, 76);
            this.boton_calcular_posfija.Name = "boton_calcular_posfija";
            this.boton_calcular_posfija.Size = new System.Drawing.Size(127, 23);
            this.boton_calcular_posfija.TabIndex = 2;
            this.boton_calcular_posfija.Text = "Convertir a Posfija";
            this.boton_calcular_posfija.UseVisualStyleBackColor = true;
            this.boton_calcular_posfija.Click += new System.EventHandler(this.boton_calcular_posfija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expresion Regular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Posfija:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boton_calcular_posfija);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.posfija_res);
            this.groupBox1.Controls.Add(this.expresion_regular);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Análisis Léxico";
            // 
            // generaAFN
            // 
            this.generaAFN.Location = new System.Drawing.Point(10, 176);
            this.generaAFN.Name = "generaAFN";
            this.generaAFN.Size = new System.Drawing.Size(127, 23);
            this.generaAFN.TabIndex = 5;
            this.generaAFN.Text = "Genera AFN";
            this.generaAFN.UseVisualStyleBackColor = true;
            this.generaAFN.Click += new System.EventHandler(this.generaAutomata_Click);
            // 
            // tablaAFN
            // 
            this.tablaAFN.AllowUserToAddRows = false;
            this.tablaAFN.AllowUserToDeleteRows = false;
            this.tablaAFN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAFN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaAFN.Location = new System.Drawing.Point(10, 254);
            this.tablaAFN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaAFN.Name = "tablaAFN";
            this.tablaAFN.ReadOnly = true;
            this.tablaAFN.RowHeadersWidth = 51;
            this.tablaAFN.Size = new System.Drawing.Size(573, 357);
            this.tablaAFN.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(589, 254);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(556, 357);
            this.dataGridView2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Genera AFD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nEstados
            // 
            this.nEstados.AutoSize = true;
            this.nEstados.Location = new System.Drawing.Point(10, 202);
            this.nEstados.Name = "nEstados";
            this.nEstados.Size = new System.Drawing.Size(116, 15);
            this.nEstados.TabIndex = 8;
            this.nEstados.Text = "Número de estados: ";
            // 
            // nEpsilon
            // 
            this.nEpsilon.AutoSize = true;
            this.nEpsilon.Location = new System.Drawing.Point(10, 226);
            this.nEpsilon.Name = "nEpsilon";
            this.nEpsilon.Size = new System.Drawing.Size(147, 15);
            this.nEpsilon.TabIndex = 9;
            this.nEpsilon.Text = "Número de transiciones ε: ";
            // 
            // nEstadosAFD
            // 
            this.nEstadosAFD.AutoSize = true;
            this.nEstadosAFD.Location = new System.Drawing.Point(589, 202);
            this.nEstadosAFD.Name = "nEstadosAFD";
            this.nEstadosAFD.Size = new System.Drawing.Size(116, 15);
            this.nEstadosAFD.TabIndex = 10;
            this.nEstadosAFD.Text = "Número de estados: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 620);
            this.Controls.Add(this.nEstadosAFD);
            this.Controls.Add(this.nEpsilon);
            this.Controls.Add(this.nEstados);
            this.Controls.Add(this.generaAFN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tablaAFN);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAFN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox expresion_regular;
        private TextBox posfija_res;
        private Button boton_calcular_posfija;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button generaAFN;
        private DataGridView tablaAFN;
        private DataGridView dataGridView2;
        private Button button1;
        private Label nEstados;
        private Label nEpsilon;
        private Label nEstadosAFD;
    }
}