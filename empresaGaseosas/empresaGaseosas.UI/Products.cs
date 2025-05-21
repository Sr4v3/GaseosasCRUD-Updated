using empresaGaseosas.Core.Gaseosas_FACADE;
using MySql.Data.MySqlClient;

namespace empresaGaseosas.UI
{
    public partial class Products : Form
    {
        Form InstanciaPpal;
        bool Result = false;
        public Products(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
            CBProductType.SelectedIndex = CBProductState.SelectedIndex = 0;
            LimpiarFormulario();
        }


        private void LimpiarFormulario()
        {
            IntProductId.Text = TxtProductValue.Text = TxtProductDescrip.Text = string.Empty;
            CBProductType.SelectedIndex = CBProductState.SelectedIndex = 0;
            CBProductType.Text = CBProductState.Text = "--Seleccionar--";
            BtnUpdate.Enabled = BtnIngresar.Enabled = BtnDelete.Enabled = true;
        }


        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            MainMenu NuevoMenu = new MainMenu(this);
            NuevoMenu.Show();
            this.Hide();
        }


        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            BtnIngresar.Enabled = false;
            BtnUpdate.Enabled = BtnDelete.Enabled = true;
            FacadeProducts InstSearch = new FacadeProducts();
            Dictionary<string, string> Result = new Dictionary<string, string>();

            try
            {
                Result = InstSearch.LeerProducto(IntProductId.Text);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(
                        "No se ha ingresado un ID de producto. Por favor ingrese uno antes de consultar.",
                        "ID no Ingresado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                Result = null;

            }


            if (Result != null)
            {
                TxtProductValue.Text = Result.GetValueOrDefault("Value_Product");
                TxtProductDescrip.Text = Result.GetValueOrDefault("Descrip_Value");
                CBProductType.Text = Result.GetValueOrDefault("Presentation_Product");
                CBProductState.Text = Result.GetValueOrDefault("State_Product");
            }
        }


        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FacadeProducts InstInactivar = new FacadeProducts();
            bool Result = InstInactivar.InactivarProducto(IntProductId.Text);
            if (Result)
            {
                MessageBox.Show("Inactivación exitosa!", "Inactivación de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al inactivar el producto, valide los valores enviados", "Inactivación de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ExecuteProduct(2);
            if (Result)
            {
                MessageBox.Show("Actualización Exitosa!", "Actualización de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al actualizar el producto, valide los valores enviados", "Actualización de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            ExecuteProduct(1);
            if (Result)
            {
                MessageBox.Show("Ingreso Exitoso!", "Ingreso de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al ingresar el producto, valide los valores enviados", "Ingreso de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        internal bool ExecuteProduct(int Accion)
        {
            Result = false;
            if (string.IsNullOrEmpty(IntProductId.Text) || string.IsNullOrEmpty(TxtProductValue.Text) || string.IsNullOrEmpty(TxtProductDescrip.Text) ||
                   CBProductType.Text == "--Seleccionar--" || CBProductState.Text == "--Seleccionar--")
            {
                MessageBox.Show("Valide los valores ingresados:" + Environment.NewLine +
                    "Todos los campos son obligatorios" + Environment.NewLine + "Debe seleccionar un elemento de la lista diferente a 'Seleccionar'",
                    "Error al Ingresar Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string valorProducto = TxtProductValue.Text.Replace(",", ".");
                Dictionary<string, string> ValuesInsert = new Dictionary<string, string>();
                ValuesInsert.Add("Id_Product", IntProductId.Text);
                ValuesInsert.Add("Value_Product", valorProducto);
                ValuesInsert.Add("Descrip_Value", TxtProductDescrip.Text);
                ValuesInsert.Add("Presentation_Product", CBProductType.Text.ToString().Trim());
                ValuesInsert.Add("State_Product", CBProductState.Text.ToString().Trim());
                FacadeProducts InstInsertar = new FacadeProducts();


                if (Accion == 1)
                    try
                    {
                        Result = InstInsertar.InsertarProducto(ValuesInsert);
                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show(
                                "Ya existe un producto con ese ID. Por favor elige otro o actualiza el actual.",
                                "Clave duplicada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        Result = false;

                    }

                else if (Accion == 2)
                {
                    Result = InstInsertar.ActualizarProducto(ValuesInsert);
                }
            }
            return Result;

        }



        private void TxtProductValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;

            }
        }


        private void IntProductId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
