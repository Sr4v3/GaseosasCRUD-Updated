namespace empresaGaseosas.UI
{
    partial class EmployeeManagement
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
            TxtEmployeeName = new TextBox();
            CBDocumentType = new ComboBox();
            IntEmployeeId = new TextBox();
            label4 = new Label();
            TxtDocNumber = new TextBox();
            TxtEmployeeLName = new TextBox();
            TxtEmployeeMail = new TextBox();
            TxtEmployeePhone = new TextBox();
            CBWorkArea = new ComboBox();
            CBEducationLevel = new ComboBox();
            CBEmployeeState = new ComboBox();
            TxtEmployeeHiring = new TextBox();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnIngresar = new Button();
            BtnSalir = new Button();
            BtnConsultar = new Button();
            BtnCreateEmployee = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            TxtPassword = new TextBox();
            panel13 = new Panel();
            TxtPassword2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // TxtEmployeeName
            // 
            TxtEmployeeName.BackColor = Color.FromArgb(247, 247, 248);
            TxtEmployeeName.Font = new Font("Poppins Medium", 12F);
            TxtEmployeeName.ForeColor = Color.FromArgb(28, 37, 65);
            TxtEmployeeName.Location = new Point(186, 10);
            TxtEmployeeName.Margin = new Padding(0);
            TxtEmployeeName.Name = "TxtEmployeeName";
            TxtEmployeeName.Size = new Size(231, 31);
            TxtEmployeeName.TabIndex = 54;
            // 
            // CBDocumentType
            // 
            CBDocumentType.BackColor = Color.FromArgb(247, 247, 248);
            CBDocumentType.FlatStyle = FlatStyle.Popup;
            CBDocumentType.Font = new Font("Poppins Medium", 12F);
            CBDocumentType.ForeColor = Color.FromArgb(28, 37, 65);
            CBDocumentType.FormattingEnabled = true;
            CBDocumentType.Items.AddRange(new object[] { "--Seleccionar--", "   Cédula de Ciudadanía", "   Tarjeta de Identidad", "   Cédula de Extranjería", "   Pasaporte", "   NIT", "   Registro Civil", "   Libreta Militar", "   Documento de Identidad", "   DNI", "   Otro" });
            CBDocumentType.Location = new Point(186, 4);
            CBDocumentType.Margin = new Padding(0);
            CBDocumentType.Name = "CBDocumentType";
            CBDocumentType.Size = new Size(231, 36);
            CBDocumentType.TabIndex = 52;
            // 
            // IntEmployeeId
            // 
            IntEmployeeId.BackColor = Color.FromArgb(247, 247, 248);
            IntEmployeeId.Font = new Font("Poppins Medium", 12F);
            IntEmployeeId.ForeColor = Color.FromArgb(28, 37, 65);
            IntEmployeeId.Location = new Point(186, 12);
            IntEmployeeId.Margin = new Padding(0);
            IntEmployeeId.Name = "IntEmployeeId";
            IntEmployeeId.Size = new Size(76, 31);
            IntEmployeeId.TabIndex = 44;
            IntEmployeeId.KeyPress += IntEmployeeId_KeyPress;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 59;
            // 
            // TxtDocNumber
            // 
            TxtDocNumber.BackColor = Color.FromArgb(247, 247, 248);
            TxtDocNumber.Font = new Font("Poppins Medium", 12F);
            TxtDocNumber.ForeColor = Color.FromArgb(28, 37, 65);
            TxtDocNumber.Location = new Point(186, 10);
            TxtDocNumber.Margin = new Padding(0);
            TxtDocNumber.Name = "TxtDocNumber";
            TxtDocNumber.Size = new Size(231, 31);
            TxtDocNumber.TabIndex = 45;
            // 
            // TxtEmployeeLName
            // 
            TxtEmployeeLName.BackColor = Color.FromArgb(247, 247, 248);
            TxtEmployeeLName.Font = new Font("Poppins Medium", 12F);
            TxtEmployeeLName.ForeColor = Color.FromArgb(28, 37, 65);
            TxtEmployeeLName.Location = new Point(186, 9);
            TxtEmployeeLName.Margin = new Padding(0);
            TxtEmployeeLName.Name = "TxtEmployeeLName";
            TxtEmployeeLName.Size = new Size(231, 31);
            TxtEmployeeLName.TabIndex = 62;
            // 
            // TxtEmployeeMail
            // 
            TxtEmployeeMail.BackColor = Color.FromArgb(247, 247, 248);
            TxtEmployeeMail.Font = new Font("Poppins Medium", 12F);
            TxtEmployeeMail.ForeColor = Color.FromArgb(28, 37, 65);
            TxtEmployeeMail.Location = new Point(186, 12);
            TxtEmployeeMail.Margin = new Padding(0);
            TxtEmployeeMail.Name = "TxtEmployeeMail";
            TxtEmployeeMail.Size = new Size(231, 31);
            TxtEmployeeMail.TabIndex = 63;
            // 
            // TxtEmployeePhone
            // 
            TxtEmployeePhone.BackColor = Color.FromArgb(247, 247, 248);
            TxtEmployeePhone.Font = new Font("Poppins Medium", 12F);
            TxtEmployeePhone.ForeColor = Color.FromArgb(28, 37, 65);
            TxtEmployeePhone.Location = new Point(186, 12);
            TxtEmployeePhone.Margin = new Padding(0);
            TxtEmployeePhone.Name = "TxtEmployeePhone";
            TxtEmployeePhone.Size = new Size(231, 31);
            TxtEmployeePhone.TabIndex = 66;
            // 
            // CBWorkArea
            // 
            CBWorkArea.BackColor = Color.FromArgb(247, 247, 248);
            CBWorkArea.FlatStyle = FlatStyle.Popup;
            CBWorkArea.Font = new Font("Poppins Medium", 12F);
            CBWorkArea.ForeColor = Color.FromArgb(28, 37, 65);
            CBWorkArea.FormattingEnabled = true;
            CBWorkArea.Items.AddRange(new object[] { "--Seleccionar--", "   Ventas", "   Administración", "   Logística", "   Operaciones", "   Finanzas", "   Recursos Humanos", "   Marketing", "   Tecnología", "   Atención al Cliente", "   Producción" });
            CBWorkArea.Location = new Point(195, 9);
            CBWorkArea.Margin = new Padding(0);
            CBWorkArea.Name = "CBWorkArea";
            CBWorkArea.Size = new Size(231, 36);
            CBWorkArea.TabIndex = 77;
            // 
            // CBEducationLevel
            // 
            CBEducationLevel.BackColor = Color.FromArgb(247, 247, 248);
            CBEducationLevel.FlatStyle = FlatStyle.Popup;
            CBEducationLevel.Font = new Font("Poppins Medium", 12F);
            CBEducationLevel.ForeColor = Color.FromArgb(28, 37, 65);
            CBEducationLevel.FormattingEnabled = true;
            CBEducationLevel.Items.AddRange(new object[] { "--Seleccionar--", "   Primaria", "   Secundaria", "   Bachillerato", "   Técnico", "   Tecnólogo", "   Pregrado", "   Maestría", "   Doctorado", "   Postdoctorado", "   Sin estudio" });
            CBEducationLevel.Location = new Point(195, 6);
            CBEducationLevel.Margin = new Padding(0);
            CBEducationLevel.Name = "CBEducationLevel";
            CBEducationLevel.Size = new Size(231, 36);
            CBEducationLevel.TabIndex = 78;
            // 
            // CBEmployeeState
            // 
            CBEmployeeState.BackColor = Color.FromArgb(247, 247, 248);
            CBEmployeeState.FlatStyle = FlatStyle.Popup;
            CBEmployeeState.Font = new Font("Poppins Medium", 12F);
            CBEmployeeState.ForeColor = Color.FromArgb(28, 37, 65);
            CBEmployeeState.FormattingEnabled = true;
            CBEmployeeState.Items.AddRange(new object[] { "--Seleccionar--", "   Activo", "   Inactivo" });
            CBEmployeeState.Location = new Point(192, 8);
            CBEmployeeState.Margin = new Padding(0);
            CBEmployeeState.Name = "CBEmployeeState";
            CBEmployeeState.Size = new Size(231, 36);
            CBEmployeeState.TabIndex = 80;
            // 
            // TxtEmployeeHiring
            // 
            TxtEmployeeHiring.BackColor = Color.FromArgb(247, 247, 248);
            TxtEmployeeHiring.Font = new Font("Poppins Medium", 12F);
            TxtEmployeeHiring.ForeColor = Color.FromArgb(28, 37, 65);
            TxtEmployeeHiring.Location = new Point(186, 11);
            TxtEmployeeHiring.Margin = new Padding(0);
            TxtEmployeeHiring.Name = "TxtEmployeeHiring";
            TxtEmployeeHiring.Size = new Size(231, 31);
            TxtEmployeeHiring.TabIndex = 81;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(58, 80, 107);
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Poppins", 8F, FontStyle.Bold);
            BtnUpdate.ForeColor = SystemColors.ButtonHighlight;
            BtnUpdate.Location = new Point(658, 401);
            BtnUpdate.Margin = new Padding(0);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(140, 45);
            BtnUpdate.TabIndex = 83;
            BtnUpdate.Text = "actualizar empleado";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click_1;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(11, 19, 43);
            BtnDelete.Cursor = Cursors.Hand;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Poppins", 8F, FontStyle.Bold);
            BtnDelete.ForeColor = SystemColors.ButtonHighlight;
            BtnDelete.Location = new Point(819, 401);
            BtnDelete.Margin = new Padding(0);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(140, 45);
            BtnDelete.TabIndex = 84;
            BtnDelete.Text = "inactivar empleado";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click_1;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(91, 192, 190);
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Poppins", 9F, FontStyle.Bold);
            BtnIngresar.ForeColor = SystemColors.ButtonHighlight;
            BtnIngresar.Location = new Point(496, 401);
            BtnIngresar.Margin = new Padding(0);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(140, 45);
            BtnIngresar.TabIndex = 82;
            BtnIngresar.Text = "insertar empleado";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click_1;
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
            BtnSalir.Location = new Point(835, 507);
            BtnSalir.Margin = new Padding(0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(140, 45);
            BtnSalir.TabIndex = 87;
            BtnSalir.Text = "salir";
            BtnSalir.UseMnemonic = false;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click_1;
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
            BtnConsultar.Location = new Point(297, 11);
            BtnConsultar.Margin = new Padding(0);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(120, 34);
            BtnConsultar.TabIndex = 86;
            BtnConsultar.Text = "consultar";
            BtnConsultar.UseVisualStyleBackColor = false;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // BtnCreateEmployee
            // 
            BtnCreateEmployee.BackColor = Color.Transparent;
            BtnCreateEmployee.BackgroundImage = Properties.Resources.background;
            BtnCreateEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCreateEmployee.Cursor = Cursors.Hand;
            BtnCreateEmployee.FlatAppearance.BorderSize = 0;
            BtnCreateEmployee.FlatStyle = FlatStyle.Flat;
            BtnCreateEmployee.Font = new Font("Poppins", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCreateEmployee.ForeColor = SystemColors.ButtonHighlight;
            BtnCreateEmployee.Location = new Point(68, 38);
            BtnCreateEmployee.Margin = new Padding(0);
            BtnCreateEmployee.Name = "BtnCreateEmployee";
            BtnCreateEmployee.Size = new Size(140, 45);
            BtnCreateEmployee.TabIndex = 88;
            BtnCreateEmployee.Text = "nuevo empleado";
            BtnCreateEmployee.UseVisualStyleBackColor = false;
            BtnCreateEmployee.Click += BtnCreateEmployee_Click_1;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(28, 37, 65);
            label14.ImageAlign = ContentAlignment.TopCenter;
            label14.Location = new Point(0, 0);
            label14.Margin = new Padding(0);
            label14.Name = "label14";
            label14.Size = new Size(984, 123);
            label14.TabIndex = 89;
            label14.Text = "Gestión de Empleados";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(91, 192, 190);
            label15.Location = new Point(63, 12);
            label15.Name = "label15";
            label15.Size = new Size(120, 30);
            label15.TabIndex = 90;
            label15.Text = "Id Empleado";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(91, 192, 190);
            label16.Location = new Point(63, 10);
            label16.Name = "label16";
            label16.Size = new Size(120, 30);
            label16.TabIndex = 91;
            label16.Text = "Tipo Doc.";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(91, 192, 190);
            label17.Location = new Point(63, 12);
            label17.Name = "label17";
            label17.Size = new Size(120, 30);
            label17.TabIndex = 92;
            label17.Text = "Número Doc.";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(91, 192, 190);
            label18.Location = new Point(63, 10);
            label18.Name = "label18";
            label18.Size = new Size(120, 30);
            label18.TabIndex = 93;
            label18.Text = "Nombre";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(91, 192, 190);
            label19.Location = new Point(63, 11);
            label19.Name = "label19";
            label19.Size = new Size(120, 30);
            label19.TabIndex = 94;
            label19.Text = "Apellido";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(91, 192, 190);
            label20.Location = new Point(63, 14);
            label20.Name = "label20";
            label20.Size = new Size(120, 30);
            label20.TabIndex = 95;
            label20.Text = "Correo";
            label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(91, 192, 190);
            label21.Location = new Point(63, 12);
            label21.Name = "label21";
            label21.Size = new Size(120, 30);
            label21.TabIndex = 96;
            label21.Text = "Teléfono";
            label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label22.ForeColor = Color.FromArgb(91, 192, 190);
            label22.Location = new Point(3, 12);
            label22.Name = "label22";
            label22.Size = new Size(180, 30);
            label22.TabIndex = 97;
            label22.Text = "Fecha Contratación";
            label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label23.ForeColor = Color.FromArgb(91, 192, 190);
            label23.Location = new Point(12, 11);
            label23.Name = "label23";
            label23.Size = new Size(180, 30);
            label23.TabIndex = 98;
            label23.Text = "Área Tabajo";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label24.ForeColor = Color.FromArgb(91, 192, 190);
            label24.Location = new Point(12, 8);
            label24.Name = "label24";
            label24.Size = new Size(180, 30);
            label24.TabIndex = 99;
            label24.Text = "Nivel Educativo";
            label24.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(91, 192, 190);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 100;
            label1.Text = "Contraseña";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(91, 192, 190);
            label2.Location = new Point(7, 11);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 101;
            label2.Text = "Confirmar Contraseña";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(91, 192, 190);
            label3.Location = new Point(9, 10);
            label3.Name = "label3";
            label3.Size = new Size(180, 30);
            label3.TabIndex = 102;
            label3.Text = "Estado Empleado";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtEmployeeHiring);
            panel1.Controls.Add(label22);
            panel1.Location = new Point(25, 499);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 50);
            panel1.TabIndex = 103;
            // 
            // panel2
            // 
            panel2.Controls.Add(CBEmployeeState);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(496, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 50);
            panel2.TabIndex = 104;
            // 
            // panel3
            // 
            panel3.Controls.Add(TxtEmployeePhone);
            panel3.Controls.Add(label21);
            panel3.Location = new Point(25, 443);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 50);
            panel3.TabIndex = 105;
            // 
            // panel4
            // 
            panel4.Controls.Add(TxtEmployeeMail);
            panel4.Controls.Add(label20);
            panel4.Location = new Point(25, 387);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 50);
            panel4.TabIndex = 105;
            // 
            // panel5
            // 
            panel5.Controls.Add(TxtEmployeeLName);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(25, 331);
            panel5.Name = "panel5";
            panel5.Size = new Size(432, 50);
            panel5.TabIndex = 105;
            // 
            // panel6
            // 
            panel6.Controls.Add(TxtEmployeeName);
            panel6.Controls.Add(label18);
            panel6.Location = new Point(25, 275);
            panel6.Name = "panel6";
            panel6.Size = new Size(432, 50);
            panel6.TabIndex = 105;
            // 
            // panel7
            // 
            panel7.Controls.Add(TxtDocNumber);
            panel7.Controls.Add(label17);
            panel7.Location = new Point(25, 219);
            panel7.Name = "panel7";
            panel7.Size = new Size(432, 50);
            panel7.TabIndex = 105;
            // 
            // panel8
            // 
            panel8.Controls.Add(CBDocumentType);
            panel8.Controls.Add(label16);
            panel8.Location = new Point(25, 163);
            panel8.Name = "panel8";
            panel8.Size = new Size(432, 50);
            panel8.TabIndex = 105;
            // 
            // panel9
            // 
            panel9.Controls.Add(IntEmployeeId);
            panel9.Controls.Add(label15);
            panel9.Controls.Add(BtnConsultar);
            panel9.Location = new Point(25, 107);
            panel9.Name = "panel9";
            panel9.Size = new Size(432, 50);
            panel9.TabIndex = 105;
            // 
            // panel10
            // 
            panel10.Controls.Add(label23);
            panel10.Controls.Add(CBWorkArea);
            panel10.Location = new Point(496, 107);
            panel10.Name = "panel10";
            panel10.Size = new Size(432, 50);
            panel10.TabIndex = 105;
            // 
            // panel11
            // 
            panel11.Controls.Add(CBEducationLevel);
            panel11.Controls.Add(label24);
            panel11.Location = new Point(496, 163);
            panel11.Name = "panel11";
            panel11.Size = new Size(432, 50);
            panel11.TabIndex = 105;
            // 
            // panel12
            // 
            panel12.Controls.Add(label1);
            panel12.Controls.Add(TxtPassword);
            panel12.Location = new Point(496, 275);
            panel12.Name = "panel12";
            panel12.Size = new Size(432, 50);
            panel12.TabIndex = 105;
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.BackColor = Color.FromArgb(247, 247, 248);
            TxtPassword.Font = new Font("Poppins Medium", 12F);
            TxtPassword.ForeColor = Color.FromArgb(91, 192, 190);
            TxtPassword.Location = new Point(195, 9);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '&';
            TxtPassword.Size = new Size(231, 31);
            TxtPassword.TabIndex = 106;
            TxtPassword.TextAlign = HorizontalAlignment.Center;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(TxtPassword2);
            panel13.Controls.Add(label2);
            panel13.Location = new Point(479, 331);
            panel13.Name = "panel13";
            panel13.Size = new Size(449, 50);
            panel13.TabIndex = 105;
            // 
            // TxtPassword2
            // 
            TxtPassword2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword2.BackColor = Color.FromArgb(247, 247, 248);
            TxtPassword2.Font = new Font("Poppins Medium", 12F);
            TxtPassword2.ForeColor = Color.FromArgb(91, 192, 190);
            TxtPassword2.Location = new Point(212, 9);
            TxtPassword2.Name = "TxtPassword2";
            TxtPassword2.PasswordChar = '&';
            TxtPassword2.Size = new Size(231, 31);
            TxtPassword2.TabIndex = 107;
            TxtPassword2.TextAlign = HorizontalAlignment.Center;
            TxtPassword2.UseSystemPasswordChar = true;
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 248);
            ClientSize = new Size(984, 586);
            Controls.Add(panel10);
            Controls.Add(BtnCreateEmployee);
            Controls.Add(BtnSalir);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnIngresar);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(label14);
            Controls.Add(panel11);
            Controls.Add(panel12);
            Controls.Add(panel13);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "EmployeeManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresa de Gaseosas - Gestión de Empleados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox CBDocumentType;
        private TextBox IntEmployeeId;
        private Label label4;
        private TextBox TxtDocNumber;
        private TextBox TxtEmployeeLName;
        private TextBox TxtEmployeeMail;
        private TextBox TxtEmployeePhone;
        private TextBox TxtEmployeeName;
        private ComboBox CBWorkArea;
        private ComboBox CBEducationLevel;
        private ComboBox CBEmployeeState;
        private TextBox TxtEmployeeHiring;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnIngresar;
        private Button BtnSalir;
        private Button BtnConsultar;
        private Button BtnCreateEmployee;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private TextBox TxtPassword;
        private TextBox TxtPassword2;
    }
}