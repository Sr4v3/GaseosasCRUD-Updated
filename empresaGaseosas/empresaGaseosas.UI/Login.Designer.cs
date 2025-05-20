namespace empresaGaseosas.UI
{
    partial class Login
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
            LblTitulo = new Label();
            TxtPassword = new TextBox();
            TxtUsuario = new TextBox();
            BtnIngresar = new Button();
            BtnSalir = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            panel7 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.Dock = DockStyle.Top;
            LblTitulo.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.FromArgb(28, 37, 65);
            LblTitulo.ImageAlign = ContentAlignment.TopCenter;
            LblTitulo.Location = new Point(0, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(654, 187);
            LblTitulo.TabIndex = 15;
            LblTitulo.Text = "Login";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.BackColor = Color.FromArgb(247, 247, 248);
            TxtPassword.Font = new Font("Poppins Medium", 12F);
            TxtPassword.ForeColor = Color.FromArgb(28, 37, 65);
            TxtPassword.Location = new Point(294, 17);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '&';
            TxtPassword.Size = new Size(231, 31);
            TxtPassword.TabIndex = 2;
            TxtPassword.TextAlign = HorizontalAlignment.Center;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtUsuario.AutoCompleteSource = AutoCompleteSource.FileSystem;
            TxtUsuario.BackColor = Color.FromArgb(247, 247, 248);
            TxtUsuario.Font = new Font("Poppins Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsuario.ForeColor = Color.FromArgb(28, 37, 65);
            TxtUsuario.Location = new Point(294, 15);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(231, 31);
            TxtUsuario.TabIndex = 10;
            TxtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(91, 192, 190);
            BtnIngresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Poppins", 15.75F, FontStyle.Bold);
            BtnIngresar.ForeColor = SystemColors.ButtonHighlight;
            BtnIngresar.Location = new Point(155, 12);
            BtnIngresar.Margin = new Padding(0);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(140, 45);
            BtnIngresar.TabIndex = 3;
            BtnIngresar.Text = "ingresar";
            BtnIngresar.UseMnemonic = false;
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(91, 192, 190);
            BtnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.ButtonHighlight;
            BtnSalir.Location = new Point(385, 12);
            BtnSalir.Margin = new Padding(0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(140, 45);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "salir";
            BtnSalir.UseMnemonic = false;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 247, 248);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(LblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 361);
            panel1.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.soda;
            pictureBox3.Location = new Point(385, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 141);
            panel5.Name = "panel5";
            panel5.Size = new Size(654, 220);
            panel5.TabIndex = 19;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel3);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(655, 228);
            panel7.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(655, 225);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(BtnSalir);
            panel4.Controls.Add(BtnIngresar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 147);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(655, 78);
            panel4.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(TxtPassword);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(655, 60);
            panel6.TabIndex = 17;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(91, 192, 190);
            label1.Location = new Point(168, 19);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 48;
            label1.Text = "contraseña";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.padlock2;
            pictureBox2.Location = new Point(130, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(TxtUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 60);
            panel2.TabIndex = 16;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(91, 192, 190);
            label6.Location = new Point(168, 17);
            label6.Name = "label6";
            label6.Size = new Size(120, 30);
            label6.TabIndex = 47;
            label6.Text = "usuario";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(130, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 361);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresa de Gaseosas - Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LblTitulo;
        private TextBox TxtPassword;
        private TextBox TxtUsuario;
        private Button BtnIngresar;
        private Button BtnSalir;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label6;
    }
}