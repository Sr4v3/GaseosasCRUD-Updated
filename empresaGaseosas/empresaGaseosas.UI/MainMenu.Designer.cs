namespace empresaGaseosas.UI
{
    partial class MainMenu
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
            PBClientes = new PictureBox();
            PBProductos = new PictureBox();
            LblEmployee = new Label();
            BtnSalir = new Button();
            label1 = new Label();
            panel1 = new Panel();
            LblProducts = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)PBClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBProductos).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // PBClientes
            // 
            PBClientes.Cursor = Cursors.Hand;
            PBClientes.Image = Properties.Resources.management2;
            PBClientes.Location = new Point(163, 27);
            PBClientes.Margin = new Padding(2);
            PBClientes.Name = "PBClientes";
            PBClientes.Size = new Size(140, 120);
            PBClientes.SizeMode = PictureBoxSizeMode.Zoom;
            PBClientes.TabIndex = 14;
            PBClientes.TabStop = false;
            PBClientes.Click += PBClientes_Click;
            // 
            // PBProductos
            // 
            PBProductos.Cursor = Cursors.Hand;
            PBProductos.Image = Properties.Resources.product2;
            PBProductos.Location = new Point(360, 27);
            PBProductos.Margin = new Padding(2);
            PBProductos.Name = "PBProductos";
            PBProductos.Size = new Size(140, 120);
            PBProductos.SizeMode = PictureBoxSizeMode.Zoom;
            PBProductos.TabIndex = 15;
            PBProductos.TabStop = false;
            PBProductos.Click += PBProductos_Click;
            // 
            // LblEmployee
            // 
            LblEmployee.BackColor = Color.Transparent;
            LblEmployee.Font = new Font("Poppins", 12F, FontStyle.Bold);
            LblEmployee.ForeColor = Color.FromArgb(91, 192, 190);
            LblEmployee.Location = new Point(163, 149);
            LblEmployee.Name = "LblEmployee";
            LblEmployee.Size = new Size(140, 58);
            LblEmployee.TabIndex = 20;
            LblEmployee.Text = "Gestión de Empleados";
            LblEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(91, 192, 190);
            BtnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.Dock = DockStyle.Fill;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.ButtonHighlight;
            BtnSalir.Location = new Point(0, 0);
            BtnSalir.Margin = new Padding(0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(140, 45);
            BtnSalir.TabIndex = 21;
            BtnSalir.Text = "salir";
            BtnSalir.UseMnemonic = false;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 37, 65);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(118, 19);
            label1.Name = "label1";
            label1.Size = new Size(429, 62);
            label1.TabIndex = 22;
            label1.Text = "Menú Principal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(LblProducts);
            panel1.Controls.Add(PBProductos);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(PBClientes);
            panel1.Controls.Add(LblEmployee);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 290);
            panel1.TabIndex = 23;
            // 
            // LblProducts
            // 
            LblProducts.BackColor = Color.Transparent;
            LblProducts.Font = new Font("Poppins", 12F, FontStyle.Bold);
            LblProducts.ForeColor = Color.FromArgb(91, 192, 190);
            LblProducts.Location = new Point(360, 149);
            LblProducts.Name = "LblProducts";
            LblProducts.Size = new Size(140, 60);
            LblProducts.TabIndex = 24;
            LblProducts.Text = "Gestión de Productos";
            LblProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(BtnSalir);
            panel3.Location = new Point(503, 235);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 45);
            panel3.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(654, 391);
            panel4.TabIndex = 25;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 248);
            ClientSize = new Size(654, 391);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresa de Gaseosas - Menú Principal";
            ((System.ComponentModel.ISupportInitialize)PBClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBProductos).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LblTitulo;
        private Button BtnSalir;
        private PictureBox PBClientes;
        private PictureBox PBProductos;
        private LinkLabel LLClientes;
        private LinkLabel LLProductos;
        private Label LblEmployee;
        private Label label1;
        private Panel panel1;
        private Label LblProducts;
        private Panel panel3;
        private Panel panel4;
    }
}