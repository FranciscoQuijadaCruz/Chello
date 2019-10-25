using System;
using System.Windows.Forms;

namespace ProyectoEscritorio
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreeEquipo = new System.Windows.Forms.Button();
            this.pnInicio = new System.Windows.Forms.Panel();
            this.pnEquipos = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnIndex = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreeTablero = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnUsuario.SuspendLayout();
            this.pnInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 94);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(516, -7);
            this.label3.MinimumSize = new System.Drawing.Size(240, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 106);
            this.label3.TabIndex = 3;
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
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click_1);
            // 
            // btnInicio
            // 
            this.btnInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(9, 9);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(85, 75);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "\r\n";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(991, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(152, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Juan Almanza";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.pnUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUsuario.Controls.Add(this.btnCerrarSesion);
            this.pnUsuario.Controls.Add(this.btnConfiguracion);
            this.pnUsuario.Controls.Add(this.btnPerfil);
            this.pnUsuario.Location = new System.Drawing.Point(981, 93);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(288, 179);
            this.pnUsuario.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 121);
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
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.BackgroundImage")));
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.Location = new System.Drawing.Point(12, 72);
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
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPerfil.Location = new System.Drawing.Point(12, 24);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(267, 43);
            this.btnPerfil.TabIndex = 4;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "TABLEROS PERSONALES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreeEquipo
            // 
            this.btnCreeEquipo.BackColor = System.Drawing.Color.Transparent;
            this.btnCreeEquipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreeEquipo.BackgroundImage")));
            this.btnCreeEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreeEquipo.FlatAppearance.BorderSize = 0;
            this.btnCreeEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreeEquipo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreeEquipo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreeEquipo.Location = new System.Drawing.Point(14, 314);
            this.btnCreeEquipo.Name = "btnCreeEquipo";
            this.btnCreeEquipo.Size = new System.Drawing.Size(267, 43);
            this.btnCreeEquipo.TabIndex = 6;
            this.btnCreeEquipo.Text = "+ Cree un equipo";
            this.btnCreeEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreeEquipo.UseVisualStyleBackColor = false;
            this.btnCreeEquipo.Click += new System.EventHandler(this.btnCreeEquipo_Click);
            // 
            // pnInicio
            // 
            this.pnInicio.BackColor = System.Drawing.SystemColors.Control;
            this.pnInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInicio.Controls.Add(this.pnEquipos);
            this.pnInicio.Controls.Add(this.label2);
            this.pnInicio.Controls.Add(this.btnCreeEquipo);
            this.pnInicio.Location = new System.Drawing.Point(0, 94);
            this.pnInicio.Name = "pnInicio";
            this.pnInicio.Size = new System.Drawing.Size(295, 378);
            this.pnInicio.TabIndex = 1;
            // 
            // pnEquipos
            // 
            this.pnEquipos.AllowDrop = true;
            this.pnEquipos.AutoScroll = true;
            this.pnEquipos.BackColor = System.Drawing.SystemColors.Control;
            this.pnEquipos.ColumnCount = 1;
            this.pnEquipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnEquipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnEquipos.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnEquipos.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnEquipos.Location = new System.Drawing.Point(8, 39);
            this.pnEquipos.Name = "pnEquipos";
            this.pnEquipos.RowCount = 1;
            this.pnEquipos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnEquipos.Size = new System.Drawing.Size(273, 255);
            this.pnEquipos.TabIndex = 11;
            this.pnEquipos.TabStop = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "EQUIPOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnIndex
            // 
            this.pnIndex.AllowDrop = true;
            this.pnIndex.AutoScroll = true;
            this.pnIndex.BackColor = System.Drawing.SystemColors.Window;
            this.pnIndex.ColumnCount = 2;
            this.pnIndex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnIndex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnIndex.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnIndex.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnIndex.Location = new System.Drawing.Point(311, 240);
            this.pnIndex.Name = "pnIndex";
            this.pnIndex.RowCount = 1;
            this.pnIndex.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnIndex.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.pnIndex.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.pnIndex.Size = new System.Drawing.Size(650, 314);
            this.pnIndex.TabIndex = 5;
            this.pnIndex.TabStop = true;
            // 
            // btnCreeTablero
            // 
            this.btnCreeTablero.BackColor = System.Drawing.Color.Transparent;
            this.btnCreeTablero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreeTablero.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnCreeTablero.FlatAppearance.BorderSize = 0;
            this.btnCreeTablero.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnCreeTablero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnCreeTablero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreeTablero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreeTablero.Image = ((System.Drawing.Image)(resources.GetObject("btnCreeTablero.Image")));
            this.btnCreeTablero.Location = new System.Drawing.Point(447, 102);
            this.btnCreeTablero.Name = "btnCreeTablero";
            this.btnCreeTablero.Size = new System.Drawing.Size(383, 50);
            this.btnCreeTablero.TabIndex = 2;
            this.btnCreeTablero.UseVisualStyleBackColor = false;
            this.btnCreeTablero.Click += new System.EventHandler(this.btnCreeTablero_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1269, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnInicio);
            this.Controls.Add(this.pnUsuario);
            this.Controls.Add(this.btnCreeTablero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1285, 643);
            this.MinimumSize = new System.Drawing.Size(1285, 643);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chello";
            this.Load += new System.EventHandler(this.Form1_Load_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnUsuario.ResumeLayout(false);
            this.pnInicio.ResumeLayout(false);
            this.pnInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load_Click(object sender, EventArgs e)
        {
                
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (pnInicio.Visible == true)
            {
                pnInicio.Visible = false;
            }
            else
            {
                pnInicio.Visible = true;
            }
        }

        private void pnIndex_Click(object sender, PaintEventArgs e)
        {
        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreeEquipo;
        private Panel pnInicio;
        private Button btnUsuario;
        private Label label2;
        private Label label3;
        private TableLayoutPanel pnIndex;
        private TableLayoutPanel pnEquipos;
        private Button btnCreeTablero;
    }
}