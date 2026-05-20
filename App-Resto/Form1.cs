using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectRestaurant;
using BE_Entidades_de_Negocio;
using BLL_Reglas_de_Negocio;

namespace AppResto
{
    public partial class Form1 : Form
    {
        List<BEMesa> mesas;
        BLLMesa bllMesa;
        public Form1()
        {
            InitializeComponent();
            mesas = new List<BEMesa>();
            bllMesa = new BLLMesa();
            mesas = bllMesa.listarMesas();

        }

        private void Mesa_Click(object sender, EventArgs e)
        {
            //cualquier mesa que toque, viene a este evento (para que sea escalable habrá que ver a futuro si quisieran agregar tanta cantidad de mesas)
            Form2 form2 = new Form2();

            // 1. Decirle que no es ventana independiente
            form2.TopLevel = false;

            // 2. Sacar bordes
            form2.FormBorderStyle = FormBorderStyle.None;

            // 3. Que ocupe todo el panel
            form2.Dock = DockStyle.Fill;

            // 4. Limpiar el panel (MUY IMPORTANTE)
            panelConteiner.Controls.Clear();
            panelConteiner.Controls.Add(form2);
            form2.Show();

        }
    }
}
