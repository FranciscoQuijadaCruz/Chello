namespace ProyectoEscritorio
{
    partial class Equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipo));
            this.PTableros = new System.Windows.Forms.Panel();
            this.listaTableros = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTablero = new System.Windows.Forms.TextBox();
            this.lbMensajeError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarTablero = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PMiembro = new System.Windows.Forms.Panel();
            this.listaMiembros = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMiembro = new System.Windows.Forms.TextBox();
            this.lbMensajeError2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInvitarMiembro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTableros = new System.Windows.Forms.Label();
            this.lbMiembros = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel = new System.Windows.Forms.Panel();
            this.pnTableros = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrearTablero = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.PTableros.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PMiembro.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.pnUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTableros
            // 
            this.PTableros.Controls.Add(this.listaTableros);
            this.PTableros.Controls.Add(this.panel3);
            this.PTableros.Location = new System.Drawing.Point(0, 197);
            this.PTableros.Name = "PTableros";
            this.PTableros.Size = new System.Drawing.Size(1269, 239);
            this.PTableros.TabIndex = 14;
            this.PTableros.Visible = false;
            // 
            // listaTableros
            // 
            this.listaTableros.AllowDrop = true;
            this.listaTableros.AutoScroll = true;
            this.listaTableros.BackColor = System.Drawing.SystemColors.Window;
            this.listaTableros.ColumnCount = 1;
            this.listaTableros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.listaTableros.Cursor = System.Windows.Forms.Cursors.Default;
            this.listaTableros.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listaTableros.Location = new System.Drawing.Point(396, 31);
            this.listaTableros.Name = "listaTableros";
            this.listaTableros.RowCount = 5;
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaTableros.Size = new System.Drawing.Size(794, 198);
            this.listaTableros.TabIndex = 9;
            this.listaTableros.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTablero);
            this.panel3.Controls.Add(this.lbMensajeError);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnAgregarTablero);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(16, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 198);
            this.panel3.TabIndex = 8;
            // 
            // txtTablero
            // 
            this.txtTablero.Location = new System.Drawing.Point(36, 92);
            this.txtTablero.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.txtTablero.Multiline = true;
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(281, 25);
            this.txtTablero.TabIndex = 2;
            // 
            // lbMensajeError
            // 
            this.lbMensajeError.AutoSize = true;
            this.lbMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lbMensajeError.Location = new System.Drawing.Point(93, 123);
            this.lbMensajeError.Name = "lbMensajeError";
            this.lbMensajeError.Size = new System.Drawing.Size(168, 13);
            this.lbMensajeError.TabIndex = 5;
            this.lbMensajeError.Text = "Favor de no dejar el campo vacio.";
            this.lbMensajeError.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "Agrega todos los tableros que necesites para organizar tus tareas. ¡Comienza ahor" +
    "a!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarTablero
            // 
            this.btnAgregarTablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTablero.Location = new System.Drawing.Point(86, 148);
            this.btnAgregarTablero.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAgregarTablero.Name = "btnAgregarTablero";
            this.btnAgregarTablero.Size = new System.Drawing.Size(172, 30);
            this.btnAgregarTablero.TabIndex = 3;
            this.btnAgregarTablero.Text = "Agregar Tablero";
            this.btnAgregarTablero.UseVisualStyleBackColor = true;
            this.btnAgregarTablero.Click += new System.EventHandler(this.btnAgregarTablero_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Agregar nuevo tablero";
            // 
            // PMiembro
            // 
            this.PMiembro.Controls.Add(this.listaMiembros);
            this.PMiembro.Controls.Add(this.panel4);
            this.PMiembro.Location = new System.Drawing.Point(0, 210);
            this.PMiembro.Name = "PMiembro";
            this.PMiembro.Size = new System.Drawing.Size(1269, 223);
            this.PMiembro.TabIndex = 15;
            // 
            // listaMiembros
            // 
            this.listaMiembros.AllowDrop = true;
            this.listaMiembros.AutoScroll = true;
            this.listaMiembros.BackColor = System.Drawing.SystemColors.Window;
            this.listaMiembros.ColumnCount = 1;
            this.listaMiembros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.listaMiembros.Cursor = System.Windows.Forms.Cursors.Default;
            this.listaMiembros.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listaMiembros.Location = new System.Drawing.Point(396, 18);
            this.listaMiembros.Name = "listaMiembros";
            this.listaMiembros.RowCount = 5;
            this.listaMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listaMiembros.Size = new System.Drawing.Size(794, 198);
            this.listaMiembros.TabIndex = 8;
            this.listaMiembros.TabStop = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtMiembro);
            this.panel4.Controls.Add(this.lbMensajeError2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnInvitarMiembro);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(16, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 198);
            this.panel4.TabIndex = 7;
            // 
            // txtMiembro
            // 
            this.txtMiembro.Location = new System.Drawing.Point(37, 92);
            this.txtMiembro.Multiline = true;
            this.txtMiembro.Name = "txtMiembro";
            this.txtMiembro.Size = new System.Drawing.Size(281, 25);
            this.txtMiembro.TabIndex = 2;
            // 
            // lbMensajeError2
            // 
            this.lbMensajeError2.AutoSize = true;
            this.lbMensajeError2.ForeColor = System.Drawing.Color.Red;
            this.lbMensajeError2.Location = new System.Drawing.Point(97, 123);
            this.lbMensajeError2.Name = "lbMensajeError2";
            this.lbMensajeError2.Size = new System.Drawing.Size(168, 13);
            this.lbMensajeError2.TabIndex = 6;
            this.lbMensajeError2.Text = "Favor de no dejar el campo vacio.";
            this.lbMensajeError2.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "¡Trabajando en equipo es mejor! agrega miembros a tu equipo para iniciar.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInvitarMiembro
            // 
            this.btnInvitarMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvitarMiembro.Location = new System.Drawing.Point(90, 148);
            this.btnInvitarMiembro.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnInvitarMiembro.Name = "btnInvitarMiembro";
            this.btnInvitarMiembro.Size = new System.Drawing.Size(172, 30);
            this.btnInvitarMiembro.TabIndex = 3;
            this.btnInvitarMiembro.Text = "Invitar miembro";
            this.btnInvitarMiembro.UseVisualStyleBackColor = true;
            this.btnInvitarMiembro.Click += new System.EventHandler(this.btnInvitarMiembro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar nuevo miembro";
            // 
            // lbTableros
            // 
            this.lbTableros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbTableros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTableros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTableros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableros.Location = new System.Drawing.Point(433, 90);
            this.lbTableros.Name = "lbTableros";
            this.lbTableros.Size = new System.Drawing.Size(197, 30);
            this.lbTableros.TabIndex = 0;
            this.lbTableros.Text = "Tableros";
            this.lbTableros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTableros.Click += new System.EventHandler(this.lbPerfil_Click);
            // 
            // lbMiembros
            // 
            this.lbMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbMiembros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMiembros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMiembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiembros.Location = new System.Drawing.Point(636, 90);
            this.lbMiembros.Name = "lbMiembros";
            this.lbMiembros.Size = new System.Drawing.Size(205, 30);
            this.lbMiembros.TabIndex = 1;
            this.lbMiembros.Text = "Miembros";
            this.lbMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMiembros.Click += new System.EventHandler(this.lbActividades_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(692, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 50);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Equipo";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(429, 14);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(119, 20);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre Equipo";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(430, 34);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(256, 46);
            this.lbDescripcion.TabIndex = 4;
            this.lbDescripcion.Text = "Esta es una prueba de una descripcion en el sistema Chello";
            this.lbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbNombre);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.lbMiembros);
            this.panel2.Controls.Add(this.lbTableros);
            this.panel2.Controls.Add(this.materialSingleLineTextField1);
            this.panel2.Controls.Add(this.lbDescripcion);
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 122);
            this.panel2.TabIndex = 6;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(421, 14);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(275, 23);
            this.materialSingleLineTextField1.TabIndex = 5;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pnTableros);
            this.panel.Controls.Add(this.btnCrearTablero);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.materialSingleLineTextField2);
            this.panel.Location = new System.Drawing.Point(0, 85);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(256, 338);
            this.panel.TabIndex = 16;
            this.panel.Visible = false;
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
            this.pnTableros.Location = new System.Drawing.Point(11, 44);
            this.pnTableros.Name = "pnTableros";
            this.pnTableros.RowCount = 1;
            this.pnTableros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnTableros.Size = new System.Drawing.Size(232, 244);
            this.pnTableros.TabIndex = 10;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "TABLEROS PERSONALES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(11, 14);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(232, 23);
            this.materialSingleLineTextField2.TabIndex = 11;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.White;
            this.pnUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUsuario.Controls.Add(this.btnCerrarSesion);
            this.pnUsuario.Controls.Add(this.btnConfiguracion);
            this.pnUsuario.Controls.Add(this.btnPerfil);
            this.pnUsuario.Controls.Add(this.lblUsuario);
            this.pnUsuario.Controls.Add(this.materialSingleLineTextField3);
            this.pnUsuario.Location = new System.Drawing.Point(981, 86);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(288, 217);
            this.pnUsuario.TabIndex = 17;
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
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
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
            this.btnConfiguracion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Image")));
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
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
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
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialSingleLineTextField3.BackgroundImage")));
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(12, 12);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(263, 23);
            this.materialSingleLineTextField3.TabIndex = 12;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
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
            this.panel1.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(4, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
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
            // Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 438);
            this.Controls.Add(this.pnUsuario);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PMiembro);
            this.Controls.Add(this.PTableros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1285, 477);
            this.MinimumSize = new System.Drawing.Size(1285, 477);
            this.Name = "Equipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PTableros.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PMiembro.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel PTableros;
        private System.Windows.Forms.Panel PMiembro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiembro;
        private System.Windows.Forms.Button btnInvitarMiembro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTableros;
        private System.Windows.Forms.Label lbMiembros;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarTablero;
        private System.Windows.Forms.TextBox txtTablero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMensajeError;
        private System.Windows.Forms.Label lbMensajeError2;
        private System.Windows.Forms.TableLayoutPanel listaMiembros;
        private System.Windows.Forms.TableLayoutPanel listaTableros;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCrearTablero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.TableLayoutPanel pnTableros;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
    }
}

