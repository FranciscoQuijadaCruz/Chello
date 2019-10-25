namespace ProyectoEscritorio
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbConfig = new System.Windows.Forms.Label();
            this.lbActividades = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.listaModificaciones = new System.Windows.Forms.TableLayoutPanel();
            this.listaTableros = new System.Windows.Forms.TableLayoutPanel();
            this.lblCambiarNombre = new System.Windows.Forms.Label();
            this.lblCambiarContra = new System.Windows.Forms.Label();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCambiarCorreo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelConfiguracion = new System.Windows.Forms.Panel();
            this.panelActividades = new System.Windows.Forms.Panel();
            this.pnActividades = new System.Windows.Forms.TableLayoutPanel();
            this.ventanaTableros = new System.Windows.Forms.Panel();
            this.pnTableros = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrearTablero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ventanaUsuario = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            this.panelConfiguracion.SuspendLayout();
            this.panelActividades.SuspendLayout();
            this.ventanaTableros.SuspendLayout();
            this.ventanaUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbConfig);
            this.panel2.Controls.Add(this.lbActividades);
            this.panel2.Controls.Add(this.lbPerfil);
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 109);
            this.panel2.TabIndex = 4;
            // 
            // lbConfig
            // 
            this.lbConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfig.Location = new System.Drawing.Point(710, 78);
            this.lbConfig.Name = "lbConfig";
            this.lbConfig.Size = new System.Drawing.Size(113, 30);
            this.lbConfig.TabIndex = 2;
            this.lbConfig.Text = "Configuración";
            this.lbConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbConfig.Click += new System.EventHandler(this.lbConfig_Click);
            // 
            // lbActividades
            // 
            this.lbActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbActividades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActividades.Location = new System.Drawing.Point(591, 78);
            this.lbActividades.Name = "lbActividades";
            this.lbActividades.Size = new System.Drawing.Size(113, 30);
            this.lbActividades.TabIndex = 1;
            this.lbActividades.Text = "Actividades";
            this.lbActividades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbActividades.Click += new System.EventHandler(this.lbActividades_Click);
            // 
            // lbPerfil
            // 
            this.lbPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(472, 78);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(113, 30);
            this.lbPerfil.TabIndex = 0;
            this.lbPerfil.Text = "Perfil";
            this.lbPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPerfil.Click += new System.EventHandler(this.lbPerfil_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(48, 39);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(511, 23);
            this.materialSingleLineTextField1.TabIndex = 5;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Equipos";
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(687, 39);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(511, 23);
            this.materialSingleLineTextField3.TabIndex = 10;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(707, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Modificaciones";
            // 
            // panelPerfil
            // 
            this.panelPerfil.Controls.Add(this.listaModificaciones);
            this.panelPerfil.Controls.Add(this.listaTableros);
            this.panelPerfil.Controls.Add(this.label6);
            this.panelPerfil.Controls.Add(this.materialSingleLineTextField3);
            this.panelPerfil.Controls.Add(this.label1);
            this.panelPerfil.Controls.Add(this.materialSingleLineTextField1);
            this.panelPerfil.Location = new System.Drawing.Point(0, 194);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(1269, 230);
            this.panelPerfil.TabIndex = 13;
            this.panelPerfil.Visible = false;
            // 
            // listaModificaciones
            // 
            this.listaModificaciones.AllowDrop = true;
            this.listaModificaciones.AutoScroll = true;
            this.listaModificaciones.BackColor = System.Drawing.Color.Transparent;
            this.listaModificaciones.ColumnCount = 1;
            this.listaModificaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.listaModificaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.listaModificaciones.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listaModificaciones.Location = new System.Drawing.Point(711, 65);
            this.listaModificaciones.Name = "listaModificaciones";
            this.listaModificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.listaModificaciones.RowCount = 10;
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaModificaciones.Size = new System.Drawing.Size(456, 146);
            this.listaModificaciones.TabIndex = 16;
            this.listaModificaciones.TabStop = true;
            // 
            // listaTableros
            // 
            this.listaTableros.AllowDrop = true;
            this.listaTableros.AutoScroll = true;
            this.listaTableros.BackColor = System.Drawing.Color.Transparent;
            this.listaTableros.ColumnCount = 1;
            this.listaTableros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.listaTableros.Cursor = System.Windows.Forms.Cursors.Default;
            this.listaTableros.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listaTableros.Location = new System.Drawing.Point(72, 65);
            this.listaTableros.Name = "listaTableros";
            this.listaTableros.Padding = new System.Windows.Forms.Padding(3);
            this.listaTableros.RowCount = 10;
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.Size = new System.Drawing.Size(456, 146);
            this.listaTableros.TabIndex = 15;
            this.listaTableros.TabStop = true;
            // 
            // lblCambiarNombre
            // 
            this.lblCambiarNombre.AutoSize = true;
            this.lblCambiarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambiarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCambiarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarNombre.Location = new System.Drawing.Point(55, 90);
            this.lblCambiarNombre.Name = "lblCambiarNombre";
            this.lblCambiarNombre.Size = new System.Drawing.Size(108, 16);
            this.lblCambiarNombre.TabIndex = 7;
            this.lblCambiarNombre.Text = "Cambiar nombre";
            this.lblCambiarNombre.Click += new System.EventHandler(this.lblCambiarNombre_Click);
            // 
            // lblCambiarContra
            // 
            this.lblCambiarContra.AutoSize = true;
            this.lblCambiarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCambiarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarContra.Location = new System.Drawing.Point(55, 128);
            this.lblCambiarContra.Name = "lblCambiarContra";
            this.lblCambiarContra.Size = new System.Drawing.Size(129, 16);
            this.lblCambiarContra.TabIndex = 8;
            this.lblCambiarContra.Text = "Cambiar contraseña";
            this.lblCambiarContra.Click += new System.EventHandler(this.lblCambiarContra_Click);
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(22, 50);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(511, 23);
            this.materialSingleLineTextField4.TabIndex = 5;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // lblCambiarCorreo
            // 
            this.lblCambiarCorreo.AutoSize = true;
            this.lblCambiarCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambiarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCambiarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarCorreo.Location = new System.Drawing.Point(55, 166);
            this.lblCambiarCorreo.Name = "lblCambiarCorreo";
            this.lblCambiarCorreo.Size = new System.Drawing.Size(170, 16);
            this.lblCambiarCorreo.TabIndex = 9;
            this.lblCambiarCorreo.Text = "Cambiar correo electrónico";
            this.lblCambiarCorreo.Click += new System.EventHandler(this.lblCambiarCorreo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(42, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Detalles de la cuenta";
            // 
            // panelConfiguracion
            // 
            this.panelConfiguracion.Controls.Add(this.label7);
            this.panelConfiguracion.Controls.Add(this.lblCambiarCorreo);
            this.panelConfiguracion.Controls.Add(this.materialSingleLineTextField4);
            this.panelConfiguracion.Controls.Add(this.lblCambiarContra);
            this.panelConfiguracion.Controls.Add(this.lblCambiarNombre);
            this.panelConfiguracion.Location = new System.Drawing.Point(355, 197);
            this.panelConfiguracion.MaximumSize = new System.Drawing.Size(593, 227);
            this.panelConfiguracion.MinimumSize = new System.Drawing.Size(593, 227);
            this.panelConfiguracion.Name = "panelConfiguracion";
            this.panelConfiguracion.Size = new System.Drawing.Size(593, 227);
            this.panelConfiguracion.TabIndex = 14;
            // 
            // panelActividades
            // 
            this.panelActividades.AutoScroll = true;
            this.panelActividades.Controls.Add(this.pnActividades);
            this.panelActividades.Location = new System.Drawing.Point(320, 194);
            this.panelActividades.Name = "panelActividades";
            this.panelActividades.Size = new System.Drawing.Size(645, 230);
            this.panelActividades.TabIndex = 12;
            this.panelActividades.Visible = false;
            // 
            // pnActividades
            // 
            this.pnActividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnActividades.AutoScroll = true;
            this.pnActividades.ColumnCount = 4;
            this.pnActividades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnActividades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnActividades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnActividades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnActividades.Location = new System.Drawing.Point(14, 14);
            this.pnActividades.Name = "pnActividades";
            this.pnActividades.RowCount = 1;
            this.pnActividades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnActividades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnActividades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.pnActividades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.pnActividades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.pnActividades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.pnActividades.Size = new System.Drawing.Size(614, 201);
            this.pnActividades.TabIndex = 16;
            // 
            // ventanaTableros
            // 
            this.ventanaTableros.BackColor = System.Drawing.Color.White;
            this.ventanaTableros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventanaTableros.Controls.Add(this.pnTableros);
            this.ventanaTableros.Controls.Add(this.btnCrearTablero);
            this.ventanaTableros.Controls.Add(this.label2);
            this.ventanaTableros.Controls.Add(this.materialSingleLineTextField2);
            this.ventanaTableros.Location = new System.Drawing.Point(-1, 85);
            this.ventanaTableros.Name = "ventanaTableros";
            this.ventanaTableros.Size = new System.Drawing.Size(256, 338);
            this.ventanaTableros.TabIndex = 15;
            this.ventanaTableros.Visible = false;
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
            // btnCrearTablero
            // 
            this.btnCrearTablero.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCrearTablero.BackgroundImage = global::ProyectoEscritorio.Properties.Resources.banner2;
            this.btnCrearTablero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearTablero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTablero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearTablero.Location = new System.Drawing.Point(12, 294);
            this.btnCrearTablero.Name = "btnCrearTablero";
            this.btnCrearTablero.Size = new System.Drawing.Size(232, 30);
            this.btnCrearTablero.TabIndex = 7;
            this.btnCrearTablero.Text = "+Crear nuevo tablero";
            this.btnCrearTablero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearTablero.UseVisualStyleBackColor = false;
            this.btnCrearTablero.Click += new System.EventHandler(this.btnCrearTablero_Click);
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
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(232, 23);
            this.materialSingleLineTextField2.TabIndex = 12;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // ventanaUsuario
            // 
            this.ventanaUsuario.BackColor = System.Drawing.Color.White;
            this.ventanaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventanaUsuario.Controls.Add(this.btnCerrarSesion);
            this.ventanaUsuario.Controls.Add(this.btnConfiguracion);
            this.ventanaUsuario.Controls.Add(this.btnPerfil);
            this.ventanaUsuario.Controls.Add(this.lblUsuario);
            this.ventanaUsuario.Controls.Add(this.materialSingleLineTextField5);
            this.ventanaUsuario.Location = new System.Drawing.Point(982, 85);
            this.ventanaUsuario.Name = "ventanaUsuario";
            this.ventanaUsuario.Size = new System.Drawing.Size(288, 217);
            this.ventanaUsuario.TabIndex = 16;
            this.ventanaUsuario.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(15, 14);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(259, 23);
            this.materialSingleLineTextField5.TabIndex = 12;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImage = global::ProyectoEscritorio.Properties.Resources.banner2;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 85);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProyectoEscritorio.Properties.Resources.tablerodeexatlonchico;
            this.button1.Location = new System.Drawing.Point(15, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Image = global::ProyectoEscritorio.Properties.Resources.chelloBan;
            this.label3.Location = new System.Drawing.Point(512, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 84);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.Location = new System.Drawing.Point(1172, 9);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(85, 75);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 425);
            this.Controls.Add(this.ventanaUsuario);
            this.Controls.Add(this.ventanaTableros);
            this.Controls.Add(this.panelConfiguracion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelActividades);
            this.Controls.Add(this.panelPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1285, 464);
            this.MinimumSize = new System.Drawing.Size(1285, 464);
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            this.panelConfiguracion.ResumeLayout(false);
            this.panelConfiguracion.PerformLayout();
            this.panelActividades.ResumeLayout(false);
            this.ventanaTableros.ResumeLayout(false);
            this.ventanaTableros.PerformLayout();
            this.ventanaUsuario.ResumeLayout(false);
            this.ventanaUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbConfig;
        private System.Windows.Forms.Label lbActividades;
        private System.Windows.Forms.Label lbPerfil;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Label lblCambiarNombre;
        private System.Windows.Forms.Label lblCambiarContra;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private System.Windows.Forms.Label lblCambiarCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelConfiguracion;
        private System.Windows.Forms.Panel panelActividades;
        private System.Windows.Forms.TableLayoutPanel pnActividades;
        private System.Windows.Forms.TableLayoutPanel listaModificaciones;
        private System.Windows.Forms.TableLayoutPanel listaTableros;
        private System.Windows.Forms.Panel ventanaTableros;
        private System.Windows.Forms.TableLayoutPanel pnTableros;
        private System.Windows.Forms.Button btnCrearTablero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ventanaUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
    }
}

