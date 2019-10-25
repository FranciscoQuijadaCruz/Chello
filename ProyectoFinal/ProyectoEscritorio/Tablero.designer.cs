namespace ProyectoEscritorio
{
    partial class Tablero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreTablero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarMiembro = new System.Windows.Forms.Button();
            this.pnModulos = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrearModulo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnTableros = new System.Windows.Forms.TableLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.btnCrearTablero = new System.Windows.Forms.Button();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnConfiguracion = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnMiembros = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnVerTableros = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnVerUsuario = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnModulos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.pnConfiguracion.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 882F));
            this.tableLayoutPanel2.Controls.Add(this.lblNombreTablero, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarMiembro, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1263, 35);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblNombreTablero
            // 
            this.lblNombreTablero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTablero.Location = new System.Drawing.Point(4, 4);
            this.lblNombreTablero.Margin = new System.Windows.Forms.Padding(3);
            this.lblNombreTablero.Name = "lblNombreTablero";
            this.lblNombreTablero.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblNombreTablero.Size = new System.Drawing.Size(323, 27);
            this.lblNombreTablero.TabIndex = 0;
            this.lblNombreTablero.Text = "NOMBRE DEL TABLERO JAJA";
            this.lblNombreTablero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "-Ver lista de miembros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "-Configuración";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAgregarMiembro
            // 
            this.btnAgregarMiembro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAgregarMiembro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregarMiembro.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMiembro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarMiembro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMiembro.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarMiembro.FlatAppearance.BorderSize = 0;
            this.btnAgregarMiembro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMiembro.Image = global::ProyectoEscritorio.Properties.Resources.adduser;
            this.btnAgregarMiembro.Location = new System.Drawing.Point(334, 1);
            this.btnAgregarMiembro.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAgregarMiembro.Name = "btnAgregarMiembro";
            this.btnAgregarMiembro.Size = new System.Drawing.Size(54, 33);
            this.btnAgregarMiembro.TabIndex = 2;
            this.btnAgregarMiembro.Text = "\r\n";
            this.btnAgregarMiembro.UseVisualStyleBackColor = false;
            this.btnAgregarMiembro.Click += new System.EventHandler(this.btnAgregarMiembro_Click);
            this.btnAgregarMiembro.MouseHover += new System.EventHandler(this.btnAgregarMiembro_MouseHover);
            // 
            // pnModulos
            // 
            this.pnModulos.AllowDrop = true;
            this.pnModulos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnModulos.AutoScroll = true;
            this.pnModulos.BackColor = System.Drawing.SystemColors.Menu;
            this.pnModulos.ColumnCount = 1;
            this.pnModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnModulos.Controls.Add(this.btnCrearModulo, 0, 0);
            this.pnModulos.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnModulos.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.pnModulos.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnModulos.Location = new System.Drawing.Point(3, 43);
            this.pnModulos.Margin = new System.Windows.Forms.Padding(0);
            this.pnModulos.Name = "pnModulos";
            this.pnModulos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnModulos.RowCount = 1;
            this.pnModulos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnModulos.Size = new System.Drawing.Size(1262, 296);
            this.pnModulos.TabIndex = 11;
            this.pnModulos.TabStop = true;
            // 
            // btnCrearModulo
            // 
            this.btnCrearModulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCrearModulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearModulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearModulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearModulo.Location = new System.Drawing.Point(8, 3);
            this.btnCrearModulo.Name = "btnCrearModulo";
            this.btnCrearModulo.Size = new System.Drawing.Size(232, 26);
            this.btnCrearModulo.TabIndex = 10;
            this.btnCrearModulo.Text = "+Crear nuevo modulo";
            this.btnCrearModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearModulo.UseVisualStyleBackColor = false;
            this.btnCrearModulo.Click += new System.EventHandler(this.BtnCrearModulo);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnModulos);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 344);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "TABLEROS PERSONALES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnTableros
            // 
            this.pnTableros.AllowDrop = true;
            this.pnTableros.AutoScroll = true;
            this.pnTableros.BackColor = System.Drawing.Color.White;
            this.pnTableros.ColumnCount = 1;
            this.pnTableros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnTableros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnTableros.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnTableros.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnTableros.Location = new System.Drawing.Point(12, 44);
            this.pnTableros.Name = "pnTableros";
            this.pnTableros.RowCount = 1;
            this.pnTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnTableros.Size = new System.Drawing.Size(232, 244);
            this.pnTableros.TabIndex = 8;
            this.pnTableros.TabStop = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pnTableros);
            this.panel.Controls.Add(this.btnCrearTablero);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.materialSingleLineTextField1);
            this.panel.Location = new System.Drawing.Point(0, 95);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(256, 338);
            this.panel.TabIndex = 3;
            this.panel.Visible = false;
            // 
            // btnCrearTablero
            // 
            this.btnCrearTablero.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCrearTablero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearTablero.BackgroundImage")));
            this.btnCrearTablero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearTablero.FlatAppearance.BorderSize = 0;
            this.btnCrearTablero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTablero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTablero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearTablero.Location = new System.Drawing.Point(12, 294);
            this.btnCrearTablero.Name = "btnCrearTablero";
            this.btnCrearTablero.Size = new System.Drawing.Size(232, 45);
            this.btnCrearTablero.TabIndex = 7;
            this.btnCrearTablero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearTablero.UseVisualStyleBackColor = false;
            this.btnCrearTablero.Click += new System.EventHandler(this.btnCrearTablero_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(14, 14);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(230, 23);
            this.materialSingleLineTextField1.TabIndex = 9;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // pnConfiguracion
            // 
            this.pnConfiguracion.BackColor = System.Drawing.Color.White;
            this.pnConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnConfiguracion.Controls.Add(this.button1);
            this.pnConfiguracion.Controls.Add(this.btnEliminar);
            this.pnConfiguracion.Controls.Add(this.label4);
            this.pnConfiguracion.Location = new System.Drawing.Point(594, 131);
            this.pnConfiguracion.Name = "pnConfiguracion";
            this.pnConfiguracion.Size = new System.Drawing.Size(164, 114);
            this.pnConfiguracion.TabIndex = 10;
            this.pnConfiguracion.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(5, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 43);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnMiembros);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(391, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 301);
            this.panel3.TabIndex = 11;
            this.panel3.Visible = false;
            // 
            // pnMiembros
            // 
            this.pnMiembros.AllowDrop = true;
            this.pnMiembros.AutoScroll = true;
            this.pnMiembros.BackColor = System.Drawing.Color.White;
            this.pnMiembros.ColumnCount = 1;
            this.pnMiembros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnMiembros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnMiembros.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnMiembros.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnMiembros.Location = new System.Drawing.Point(7, 10);
            this.pnMiembros.Name = "pnMiembros";
            this.pnMiembros.RowCount = 1;
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.pnMiembros.Size = new System.Drawing.Size(188, 278);
            this.pnMiembros.TabIndex = 18;
            this.pnMiembros.TabStop = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 6;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.White;
            this.pnUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUsuario.Controls.Add(this.btnCerrarSesion);
            this.pnUsuario.Controls.Add(this.btnConfiguracion);
            this.pnUsuario.Controls.Add(this.btnPerfil);
            this.pnUsuario.Controls.Add(this.lblUsuario);
            this.pnUsuario.Controls.Add(this.materialSingleLineTextField2);
            this.pnUsuario.Location = new System.Drawing.Point(977, 97);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(288, 217);
            this.pnUsuario.TabIndex = 9;
            this.pnUsuario.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 166);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(267, 43);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.BackgroundImage")));
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(12, 117);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(267, 43);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Location = new System.Drawing.Point(12, 69);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(267, 43);
            this.btnPerfil.TabIndex = 4;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuario.Location = new System.Drawing.Point(11, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(87, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "<Usuario>";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(12, 14);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(267, 23);
            this.materialSingleLineTextField2.TabIndex = 12;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImage = global::ProyectoEscritorio.Properties.Resources.banner2;
            this.panel1.Controls.Add(this.materialSingleLineTextField3);
            this.panel1.Controls.Add(this.btnVerTableros);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.btnVerUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 94);
            this.panel1.TabIndex = 2;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(9, 106);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(1226, 23);
            this.materialSingleLineTextField3.TabIndex = 5;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.Text = resources.GetString("materialSingleLineTextField3.Text");
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // btnVerTableros
            // 
            this.btnVerTableros.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnVerTableros.BackColor = System.Drawing.Color.Transparent;
            this.btnVerTableros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerTableros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTableros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnVerTableros.FlatAppearance.BorderSize = 0;
            this.btnVerTableros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnVerTableros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnVerTableros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTableros.Image = global::ProyectoEscritorio.Properties.Resources.tablerodeexatlonchico;
            this.btnVerTableros.Location = new System.Drawing.Point(13, 10);
            this.btnVerTableros.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerTableros.Name = "btnVerTableros";
            this.btnVerTableros.Size = new System.Drawing.Size(173, 75);
            this.btnVerTableros.TabIndex = 4;
            this.btnVerTableros.Text = "\r\n";
            this.btnVerTableros.UseVisualStyleBackColor = false;
            this.btnVerTableros.Click += new System.EventHandler(this.btnVerTableros_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogo.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogo.Image = global::ProyectoEscritorio.Properties.Resources.chelloBan;
            this.lblLogo.Location = new System.Drawing.Point(516, -7);
            this.lblLogo.MinimumSize = new System.Drawing.Size(240, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(240, 106);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // btnVerUsuario
            // 
            this.btnVerUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnVerUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnVerUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnVerUsuario.FlatAppearance.BorderSize = 0;
            this.btnVerUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnVerUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnVerUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnVerUsuario.Image")));
            this.btnVerUsuario.Location = new System.Drawing.Point(1172, 9);
            this.btnVerUsuario.Name = "btnVerUsuario";
            this.btnVerUsuario.Size = new System.Drawing.Size(85, 75);
            this.btnVerUsuario.TabIndex = 2;
            this.btnVerUsuario.UseVisualStyleBackColor = false;
            this.btnVerUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnConfiguracion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnUsuario);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1285, 489);
            this.MinimumSize = new System.Drawing.Size(1285, 489);
            this.Name = "Tablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chello";
            this.Load += new System.EventHandler(this.Tablero_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnModulos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.pnConfiguracion.ResumeLayout(false);
            this.pnConfiguracion.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNombreTablero;
        private System.Windows.Forms.Button btnAgregarMiembro;
        private System.Windows.Forms.TableLayoutPanel pnModulos;
        private System.Windows.Forms.Button btnCrearModulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearTablero;
        private System.Windows.Forms.TableLayoutPanel pnTableros;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnVerUsuario;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnVerTableros;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnConfiguracion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel pnMiembros;
    }
}

