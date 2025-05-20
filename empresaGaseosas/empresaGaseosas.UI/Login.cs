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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<bool, string> EsCorrecto = new Dictionary<bool, string>();
                bool existe;
                empresaGaseosas.Core.Gaseosas_FACADE.FacadeLogin ValidateLogin = new Core.Gaseosas_FACADE.FacadeLogin();
                EsCorrecto = ValidateLogin.ValidarLogin(string.IsNullOrEmpty(TxtUsuario.Text) ? string.Empty : TxtUsuario.Text, string.IsNullOrEmpty(TxtPassword.Text) ? string.Empty : TxtPassword.Text);
                existe = EsCorrecto.ContainsValue("Login Correcto");
                EsCorrecto.TryGetValue(false, out string MensajeLogeo);

                if (existe)
                {
                    MainMenu NuevoMenu = new MainMenu(this);
                    NuevoMenu.Show();
                    this.Hide();
                }
                else if (string.IsNullOrEmpty(TxtUsuario.Text))
                    MessageBox.Show("Login incorrecto. No ha ingresado un usuario.", "Error de Login - Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrEmpty(TxtPassword.Text))
                    MessageBox.Show("Login incorrecto. No ha ingresado una contraseña.", "Error de Login - Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show("Login incorrecto, valide sus credenciales: " + Environment.NewLine + MensajeLogeo, "Error de Login - Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message + Environment.NewLine + exc.StackTrace, "Error controlado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnIngresar_Click(sender, e);
            }
        }
    }
}
