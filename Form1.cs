using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplatePattern.Clases_Patron;

namespace TemplatePattern
{
    public partial class Form1 : Form
    {
        List<Cliente> _clientes;
        List<String> _creditos;

        public Form1()
        {
            InitializeComponent();
            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente("Juan Topo"));
            _clientes.Add(new Cliente("Homero Simpson"));

            this.comboBox1.DataSource = _clientes;

            _creditos = new List<string>();
            _creditos.Add("Personal");
            _creditos.Add("Hipotecario");
            this.comboBox2.DataSource = _creditos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var credito = this.comboBox2.SelectedItem.ToString();
            var cliente = (Cliente)this.comboBox1.SelectedItem;
            try {
                if (credito == null) throw new Exception("Debe seleccionar un credito de la lista");
              
                Credito c;

                switch (credito)
                {
                    case "Hipotecario":
                        c = new CreditoHipotecario(cliente);
                        break;
                    case "Personal":
                        c = new CreditoPersonal(cliente);
                        break;
                    default:
                        throw new Exception("Debe seleccionar un credito");
                }

                this.resultados.Clear();
                this.resultados.Lines = c.Verifificar();

            }
            catch (Exception ex)
            {
                 MessageBox.Show( ex.Message);
            }
        }
    }
}
