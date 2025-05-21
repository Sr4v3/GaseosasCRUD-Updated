namespace empresaGaseosas.UI
{
    partial class Products
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
            TxtProductValue = new TextBox();
            BtnIngresar = new Button();
            CBProductType = new ComboBox();
            CBProductState = new ComboBox();
            TxtProductDescrip = new TextBox();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnCreateUser = new Button();
            BtnSalir = new Button();
            label5 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            IntProductId = new TextBox();
            BtnConsultar = new Button();
            panel5 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // TxtProductValue
            // 
            TxtProductValue.BackColor = Color.FromArgb(247, 247, 248);
            TxtProductValue.Font = new Font("Poppins Medium", 12F);
            TxtProductValue.ForeColor = Color.FromArgb(28, 37, 65);
            TxtProductValue.Location = new Point(229, 12);
            TxtProductValue.Margin = new Padding(4, 5, 4, 5);
            TxtProductValue.Name = "TxtProductValue";
            TxtProductValue.RightToLeft = RightToLeft.No;
            TxtProductValue.Size = new Size(231, 31);
            TxtProductValue.TabIndex = 27;
            TxtProductValue.KeyPress += TxtProductValue_KeyPress;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(91, 192, 190);
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            BtnIngresar.ForeColor = SystemColors.ButtonHighlight;
            BtnIngresar.Location = new Point(622, 245);
            BtnIngresar.Margin = new Padding(0);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(140, 45);
            BtnIngresar.TabIndex = 28;
            BtnIngresar.Text = "insertar producto";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // CBProductType
            // 
            CBProductType.BackColor = Color.FromArgb(247, 247, 248);
            CBProductType.FlatStyle = FlatStyle.Popup;
            CBProductType.Font = new Font("Poppins Medium", 12F);
            CBProductType.ForeColor = Color.FromArgb(28, 37, 65);
            CBProductType.FormattingEnabled = true;
            CBProductType.Items.AddRange(new object[] { "--Seleccionar--", "   350mL", "   3L" });
            CBProductType.Location = new Point(226, 9);
            CBProductType.Margin = new Padding(0);
            CBProductType.Name = "CBProductType";
            CBProductType.Size = new Size(231, 36);
            CBProductType.TabIndex = 35;
            // 
            // CBProductState
            // 
            CBProductState.BackColor = Color.FromArgb(247, 247, 248);
            CBProductState.FlatStyle = FlatStyle.Popup;
            CBProductState.Font = new Font("Poppins Medium", 12F);
            CBProductState.ForeColor = Color.FromArgb(28, 37, 65);
            CBProductState.FormattingEnabled = true;
            CBProductState.Items.AddRange(new object[] { "--Seleccionar--", "   Activo", "   Inactivo" });
            CBProductState.Location = new Point(226, 10);
            CBProductState.Margin = new Padding(0);
            CBProductState.Name = "CBProductState";
            CBProductState.Size = new Size(231, 36);
            CBProductState.TabIndex = 36;
            // 
            // TxtProductDescrip
            // 
            TxtProductDescrip.BackColor = Color.FromArgb(247, 247, 248);
            TxtProductDescrip.Font = new Font("Poppins Medium", 12F);
            TxtProductDescrip.ForeColor = Color.FromArgb(28, 37, 65);
            TxtProductDescrip.Location = new Point(229, 11);
            TxtProductDescrip.Margin = new Padding(4, 5, 4, 5);
            TxtProductDescrip.Name = "TxtProductDescrip";
            TxtProductDescrip.Size = new Size(231, 31);
            TxtProductDescrip.TabIndex = 38;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(58, 80, 107);
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Poppins", 8F, FontStyle.Bold);
            BtnUpdate.ForeColor = SystemColors.ButtonHighlight;
            BtnUpdate.Location = new Point(622, 310);
            BtnUpdate.Margin = new Padding(0);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(140, 45);
            BtnUpdate.TabIndex = 39;
            BtnUpdate.Text = "actualizar producto";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(11, 19, 43);
            BtnDelete.Cursor = Cursors.Hand;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            BtnDelete.ForeColor = SystemColors.ButtonHighlight;
            BtnDelete.Location = new Point(622, 369);
            BtnDelete.Margin = new Padding(0);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(140, 45);
            BtnDelete.TabIndex = 40;
            BtnDelete.Text = "inactivar producto";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnCreateUser
            // 
            BtnCreateUser.BackColor = Color.Transparent;
            BtnCreateUser.BackgroundImage = Properties.Resources.background;
            BtnCreateUser.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCreateUser.Cursor = Cursors.Hand;
            BtnCreateUser.FlatAppearance.BorderSize = 0;
            BtnCreateUser.FlatStyle = FlatStyle.Flat;
            BtnCreateUser.Font = new Font("Poppins", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCreateUser.ForeColor = SystemColors.ButtonHighlight;
            BtnCreateUser.Location = new Point(67, 43);
            BtnCreateUser.Margin = new Padding(0);
            BtnCreateUser.Name = "BtnCreateUser";
            BtnCreateUser.Size = new Size(140, 45);
            BtnCreateUser.TabIndex = 42;
            BtnCreateUser.Text = "nuevo producto";
            BtnCreateUser.UseVisualStyleBackColor = false;
            BtnCreateUser.Click += BtnCreateUser_Click;
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
            BtnSalir.Location = new Point(835, 407);
            BtnSalir.Margin = new Padding(0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(140, 45);
            BtnSalir.TabIndex = 43;
            BtnSalir.Text = "salir";
            BtnSalir.UseMnemonic = false;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click_1;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(28, 37, 65);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(984, 134);
            label5.TabIndex = 44;
            label5.Text = "Gestión de Productos";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(BtnUpdate);
            panel1.Controls.Add(BtnDelete);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BtnIngresar);
            panel1.Controls.Add(BtnCreateUser);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 461);
            panel1.TabIndex = 45;
            // 
            // panel6
            // 
            panel6.Controls.Add(label9);
            panel6.Controls.Add(CBProductType);
            panel6.Location = new Point(32, 305);
            panel6.Name = "panel6";
            panel6.Size = new Size(517, 54);
            panel6.TabIndex = 49;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(91, 192, 190);
            label9.Location = new Point(17, 11);
            label9.Name = "label9";
            label9.Size = new Size(202, 30);
            label9.TabIndex = 49;
            label9.Text = "Presentación Producto";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Controls.Add(TxtProductValue);
            panel4.Location = new Point(32, 185);
            panel4.Name = "panel4";
            panel4.Size = new Size(517, 54);
            panel4.TabIndex = 49;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(91, 192, 190);
            label7.Location = new Point(63, 12);
            label7.Name = "label7";
            label7.Size = new Size(156, 30);
            label7.TabIndex = 47;
            label7.Text = "Valor Producto";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(CBProductState);
            panel3.Location = new Point(32, 365);
            panel3.Name = "panel3";
            panel3.Size = new Size(517, 54);
            panel3.TabIndex = 48;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(91, 192, 190);
            label10.Location = new Point(17, 10);
            label10.Name = "label10";
            label10.Size = new Size(202, 30);
            label10.TabIndex = 50;
            label10.Text = "Estado Producto";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(IntProductId);
            panel2.Controls.Add(BtnConsultar);
            panel2.Location = new Point(32, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 54);
            panel2.TabIndex = 47;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(91, 192, 190);
            label6.Location = new Point(99, 9);
            label6.Name = "label6";
            label6.Size = new Size(120, 30);
            label6.TabIndex = 46;
            label6.Text = "Id Producto";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // IntProductId
            // 
            IntProductId.BackColor = Color.FromArgb(247, 247, 248);
            IntProductId.Font = new Font("Poppins Medium", 12F);
            IntProductId.ForeColor = Color.FromArgb(28, 37, 65);
            IntProductId.Location = new Point(229, 7);
            IntProductId.Margin = new Padding(4, 5, 4, 5);
            IntProductId.Name = "IntProductId";
            IntProductId.Size = new Size(231, 31);
            IntProductId.TabIndex = 26;
            IntProductId.KeyPress += IntProductId_KeyPress_1;
            // 
            // BtnConsultar
            // 
            BtnConsultar.BackColor = Color.FromArgb(91, 192, 190);
            BtnConsultar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnConsultar.Cursor = Cursors.Hand;
            BtnConsultar.FlatAppearance.BorderSize = 0;
            BtnConsultar.FlatStyle = FlatStyle.Flat;
            BtnConsultar.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConsultar.ForeColor = Color.Transparent;
            BtnConsultar.Location = new Point(489, 7);
            BtnConsultar.Margin = new Padding(0);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(120, 34);
            BtnConsultar.TabIndex = 41;
            BtnConsultar.Text = "consultar";
            BtnConsultar.UseVisualStyleBackColor = false;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label8);
            panel5.Controls.Add(TxtProductDescrip);
            panel5.Location = new Point(32, 245);
            panel5.Name = "panel5";
            panel5.Size = new Size(517, 54);
            panel5.TabIndex = 49;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(91, 192, 190);
            label8.Location = new Point(17, 13);
            label8.Name = "label8";
            label8.Size = new Size(202, 30);
            label8.TabIndex = 48;
            label8.Text = "Descripción Producto";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 248);
            ClientSize = new Size(984, 461);
            Controls.Add(BtnSalir);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            MinimizeBox = false;
            Name = "Products";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresa de Gaseosas - Productos";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }
        private TextBox TxtProductValue;
        private Button BtnIngresar;
        private ComboBox CBProductType;
        private ComboBox CBProductState;
        private TextBox TxtProductDescrip;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnCreateUser;
        #endregion

        private Button BtnSalir;
        private Label label5;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox IntProductId;
        private Label label6;
        private Button BtnConsultar;
        private Panel panel6;
        private Panel panel5;
    }
}