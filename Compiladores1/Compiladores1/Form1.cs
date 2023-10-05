using Compiladores_Proyecto_Deanosaurios;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Compiladores1
{
    public partial class Form1 : Form
    {
        AFN afn = new AFN();
        AFD afd = new AFD();
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_calcular_posfija_Click(object sender, EventArgs e)
        {
            string expresionRegular = expresion_regular.Text;
            string regexexplicita = Program.convierteExplicita(expresionRegular);
            string posfija = Program.ConvertirAPosfija(regexexplicita);
            posfija_res.Text = posfija;
        }

        private void generaAutomata_Click(object sender, EventArgs e)
        {
            tablaAFN.Columns.Clear();
            tablaAFN.Rows.Clear();

            
            int contadorE = 0;
            int contadorEstados = 0;
            afn.PosfijaEnAFN(posfija_res.Text);
            tablaAFN.Columns.Clear();

            DataGridViewColumn estados = new DataGridViewColumn();
            estados.Name = "EDO";
            estados.HeaderText = "EDO";
            DataGridViewCell dgvcell1 = new DataGridViewTextBoxCell();
            estados.CellTemplate = dgvcell1;
            tablaAFN.Columns.Add(estados);

            foreach (string s in afn.alfabeto)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.Name = s;
                column.HeaderText = s;
                DataGridViewCell dgvcell = new DataGridViewTextBoxCell();
                column.CellTemplate = dgvcell;
                tablaAFN.Columns.Add(column);
            }
            DataGridViewColumn columnEpsilon = new DataGridViewColumn();
            columnEpsilon.Name = "£";
            columnEpsilon.HeaderText = "£";
            DataGridViewCell dgvcellEpsilon = new DataGridViewTextBoxCell();
            columnEpsilon.CellTemplate = dgvcellEpsilon;
            tablaAFN.Columns.Add(columnEpsilon);

            for (int i = 0; i < afn.estados.Count; i++)
            {
                contadorEstados++;
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(tablaAFN);
                r.Cells[0].Value = afn.estados[i].nombre;
                for (int j = 0; j <= afn.alfabeto.Count; j++)
                {
                    if (j == afn.alfabeto.Count)
                    {
                        foreach (Transicion t in afn.estados[i].transiciones)
                        {
                            if (t.valor == "")
                            {
                                contadorE++;
                                r.Cells[j + 1].Value = r.Cells[j + 1].Value + " " + t.destino.nombre.ToString();
                            }
                        }
                    }
                    else
                    {
                        foreach (Transicion t in afn.estados[i].transiciones)
                        {
                            if (t.valor == afn.alfabeto[j])
                            {
                                r.Cells[j + 1].Value = r.Cells[j + 1].Value + " " + t.destino.nombre.ToString();
                            }
                        }
                    }
                }
                tablaAFN.Rows.Add(r);
            }
            nEstados.Text = "Numero de estados: " + contadorEstados.ToString(); 
            nEpsilon.Text = "Numero de transiciones e: " + contadorE.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            afd.construyeAFD(afn);
            dataGridView2.Columns.Clear();

            DataGridViewColumn columnEDO = new DataGridViewColumn();
            columnEDO.Name = "EDO";
            columnEDO.HeaderText = "EDO";
            DataGridViewCell dgvcell1 = new DataGridViewTextBoxCell();
            columnEDO.CellTemplate = dgvcell1;
            dataGridView2.Columns.Add(columnEDO);

            foreach (string s in afn.alfabeto)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.Name = s;
                column.HeaderText = s;
                DataGridViewCell dgvcell = new DataGridViewTextBoxCell();
                column.CellTemplate = dgvcell;
                dataGridView2.Columns.Add(column);
            }
            int contadorDestados = 0;
            for (int i = 0; i < afd.dEstados.Count; i++)
            {
                
                contadorDestados++;
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView2);
                r.Cells[0].Value = afd.dEstados[i].name;
                for (int j = 0; j < afd.alfabeto.Count; j++)
                {

                    foreach (TransicionDestado t in afd.dEstados[i].transiciones)
                    {
                        if (t.valor == afn.alfabeto[j])
                        {
                            r.Cells[j + 1].Value = r.Cells[j + 1].Value + " " + t.destino.name.ToString();
                        }
                    }

                }
                dataGridView2.Rows.Add(r);
            }
            nEstadosAFD.Text = "Número de estados: " + contadorDestados.ToString();
            
        }
    }
}