using empresaGaseosas.Core.Gaseosas_FACADE;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresaGaseosas.UI
{
    public partial class EmployeeManagement : Form
    {
        Form InstanciaPpal;
        bool Result = false;
        public EmployeeManagement(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
            CBDocumentType.SelectedIndex = CBWorkArea.SelectedIndex = CBEducationLevel.SelectedIndex = 0;
            MessageBox.Show("Valide que el formato de la fecha a ingresar sea dd/mm/yyyy o dd-mm-yyyy",
                    "Formato Fecha - Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LimpiarFormulario();

        }


        private void LimpiarFormulario()
        {
            IntEmployeeId.Text = TxtDocNumber.Text = TxtEmployeeName.Text = TxtEmployeeLName.Text = TxtEmployeeMail.Text = TxtEmployeePhone.Text = TxtEmployeeHiring.Text = TxtPassword.Text = TxtPassword2.Text = string.Empty;
            CBDocumentType.SelectedIndex = CBWorkArea.SelectedIndex = CBEducationLevel.SelectedIndex = CBEmployeeState.SelectedIndex = 0;
            CBDocumentType.Text = CBWorkArea.Text = CBEducationLevel.Text = CBEmployeeState.Text = "--Seleccionar--";
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
            FacadeEmployee InstSearch = new FacadeEmployee();
            Dictionary<string, string> Result = new Dictionary<string, string>();

            try
            {
                Result = InstSearch.LeerEmpleado(IntEmployeeId.Text);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(
                        "No se ha ingresado un ID de empleado. Por favor ingrese uno antes de consultar.",
                        "ID no Ingresado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                Result = null;

            }


            if (Result != null)
            {
                TxtDocNumber.Text = Result.GetValueOrDefault("DocNumber_Employee");
                TxtEmployeeName.Text = Result.GetValueOrDefault("Name_Employee");
                TxtEmployeeLName.Text = Result.GetValueOrDefault("LName_Employee");
                TxtEmployeeMail.Text = Result.GetValueOrDefault("Mail_Employee");
                TxtEmployeePhone.Text = Result.GetValueOrDefault("Phone_Employee");
                TxtEmployeeHiring.Text = Result.GetValueOrDefault("HiringDate_Employee");
                CBDocumentType.Text = Result.GetValueOrDefault("DocType_Employee");
                CBWorkArea.Text = Result.GetValueOrDefault("WorkArea_Employee");
                CBEducationLevel.Text = Result.GetValueOrDefault("EducationLevel_Employee");
                CBEmployeeState.Text = Result.GetValueOrDefault("State_Employee");


                string fechaContratacion = Result.GetValueOrDefault("HiringDate_Employee");



            }
        }

        private void BtnCreateEmployee_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
            MessageBox.Show("Valide que el formato de la fecha a ingresar sea dd/mm/yyyy o dd-mm-yyyy",
                    "Formato Fecha - Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            FacadeEmployee InstInactivar = new FacadeEmployee();
            bool Result = InstInactivar.InactivarEmpleado(IntEmployeeId.Text);
            if (Result)
            {
                MessageBox.Show("Inactivación Exitosa!", "Inactivación de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al inactivar el empleado, valide los valores enviados", "Inactivación de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            ExecuteEmployee(2);
            if (Result)
            {
                MessageBox.Show("Actualización Exitosa!", "Actualización de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al actualizar el empleado, valide los valores enviados", "Actualización de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            ExecuteEmployee(1);
            if (Result)
            {
                MessageBox.Show("Ingreso Exitoso!", "Ingreso de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al ingresar el empleado, valide los valores enviados", "Ingreso de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        internal bool ExecuteEmployee(int Accion)
        {
            Result = false;

            
            if (string.IsNullOrEmpty(IntEmployeeId.Text) || string.IsNullOrEmpty(TxtDocNumber.Text) || string.IsNullOrEmpty(TxtEmployeeName.Text) ||
                string.IsNullOrEmpty(TxtEmployeeLName.Text) || string.IsNullOrEmpty(TxtEmployeeMail.Text) || string.IsNullOrEmpty(TxtEmployeePhone.Text) ||
                   string.IsNullOrEmpty(TxtEmployeeHiring.Text) || CBDocumentType.Text == "--Seleccionar--" || CBWorkArea.Text == "--Seleccionar--" || CBEducationLevel.Text == "--Seleccionar--" ||
                   CBEmployeeState.Text == "--Seleccionar--" || (string.IsNullOrEmpty(TxtPassword.Text) != string.IsNullOrEmpty(TxtPassword2.Text) || TxtPassword.Text != TxtPassword2.Text))
            {

                MessageBox.Show("Valide los valores ingresados:" + Environment.NewLine +
                "Todos los campos son obligatorios" + Environment.NewLine + "Debe seleccionar un elemento de la lista diferente a 'Seleccionar'" + Environment.NewLine +
                "Las dos contraseñas deben coincidir", "Error al Ingresar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
            else
            {
                string fechaContratacion = TxtEmployeeHiring.Text.Replace(",", ".");
                DateTime fecha = DateTime.Parse(fechaContratacion);
                string fechaFormateada = fecha.ToString("yyyy-MM-dd");

                Dictionary<string, string> ValuesInsert = new Dictionary<string, string>();
                ValuesInsert.Add("Id_Employee", IntEmployeeId.Text);
                ValuesInsert.Add("DocNumber_Employee", TxtDocNumber.Text);
                ValuesInsert.Add("Name_Employee", TxtEmployeeName.Text);
                ValuesInsert.Add("LName_Employee", TxtEmployeeLName.Text);
                ValuesInsert.Add("Mail_Employee", TxtEmployeeMail.Text);
                ValuesInsert.Add("Phone_Employee", TxtEmployeePhone.Text);
                ValuesInsert.Add("HiringDate_Employee", fechaFormateada);
                ValuesInsert.Add("Password", TxtPassword.Text);
                ValuesInsert.Add("DocType_Employee", CBDocumentType.Text.ToString().Trim());
                ValuesInsert.Add("WorkArea_Employee", CBWorkArea.Text.ToString().Trim());
                ValuesInsert.Add("EducationLevel_Employee", CBEducationLevel.Text.ToString().Trim());
                ValuesInsert.Add("State_Employee", CBEmployeeState.Text.ToString().Trim());
                FacadeEmployee InstInsertar = new FacadeEmployee();


                if (Accion == 1)
                    try
                    {
                        Result = InstInsertar.InsertarEmpleado(ValuesInsert);
                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show(
                                "Ya existe un empleado con ese ID. Por favor elige otro o actualiza el actual.",
                                "Clave duplicada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        Result = false;

                    }

                else if (Accion == 2)
                {
                    Result = InstInsertar.ActualizarEmpleado(ValuesInsert);
                }
            }
            return Result;

        }
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnIngresar_Click_1(sender, e);
            }
        }

        private void TxtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnIngresar_Click_1(sender, e);
            }
        }
    }
}
