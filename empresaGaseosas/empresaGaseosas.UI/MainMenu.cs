using empresaGaseosas.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresaGaseosas.UI
{
    public partial class MainMenu : Form
    {
        Form InstanciaPpal;
        public MainMenu(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBProductos_Click(object sender, EventArgs e)
        {
            Products FrmProductos = new Products(InstanciaPpal);
            FrmProductos.Show();
            this.Hide();
        }

        private void PBClientes_Click(object sender, EventArgs e)
        {
            EmployeeManagement FrmGestionEmpleados = new EmployeeManagement(InstanciaPpal);
            FrmGestionEmpleados.Show();
            this.Hide();
        }
    }
}
