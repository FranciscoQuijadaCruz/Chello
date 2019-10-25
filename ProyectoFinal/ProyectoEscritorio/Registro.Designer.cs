namespace ProyectoEscritorio
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MsgVacios = new System.Windows.Forms.Label();
            this.MsgNombre = new System.Windows.Forms.Label();
            this.MsgCorreo = new System.Windows.Forms.Label();
            this.MsgContrasena = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistarse = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crear una cuenta nueva de";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombre.Location = new System.Drawing.Point(69, 197);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 31);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEmail.Location = new System.Drawing.Point(69, 289);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 31);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPassword.Location = new System.Drawing.Point(68, 380);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(313, 31);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MsgVacios);
            this.panel2.Controls.Add(this.MsgNombre);
            this.panel2.Controls.Add(this.MsgCorreo);
            this.panel2.Controls.Add(this.MsgContrasena);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblMsg);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPassword2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRegistarse);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 624);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MsgVacios
            // 
            this.MsgVacios.AutoSize = true;
            this.MsgVacios.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgVacios.ForeColor = System.Drawing.Color.Red;
            this.MsgVacios.Location = new System.Drawing.Point(67, 512);
            this.MsgVacios.Name = "MsgVacios";
            this.MsgVacios.Size = new System.Drawing.Size(11, 18);
            this.MsgVacios.TabIndex = 19;
            this.MsgVacios.Text = " ";
            // 
            // MsgNombre
            // 
            this.MsgNombre.AutoSize = true;
            this.MsgNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgNombre.ForeColor = System.Drawing.Color.Red;
            this.MsgNombre.Location = new System.Drawing.Point(65, 238);
            this.MsgNombre.Name = "MsgNombre";
            this.MsgNombre.Size = new System.Drawing.Size(0, 18);
            this.MsgNombre.TabIndex = 18;
            // 
            // MsgCorreo
            // 
            this.MsgCorreo.AutoSize = true;
            this.MsgCorreo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgCorreo.ForeColor = System.Drawing.Color.Red;
            this.MsgCorreo.Location = new System.Drawing.Point(65, 332);
            this.MsgCorreo.Name = "MsgCorreo";
            this.MsgCorreo.Size = new System.Drawing.Size(0, 18);
            this.MsgCorreo.TabIndex = 17;
            // 
            // MsgContrasena
            // 
            this.MsgContrasena.AutoSize = true;
            this.MsgContrasena.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgContrasena.ForeColor = System.Drawing.Color.Red;
            this.MsgContrasena.Location = new System.Drawing.Point(67, 426);
            this.MsgContrasena.Name = "MsgContrasena";
            this.MsgContrasena.Size = new System.Drawing.Size(0, 18);
            this.MsgContrasena.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(229, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 15;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(221, 303);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 18);
            this.lblMsg.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(65, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Repetir Contraseña";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPassword2.Location = new System.Drawing.Point(68, 474);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(313, 31);
            this.txtPassword2.TabIndex = 12;
            this.txtPassword2.Enter += new System.EventHandler(this.txtPassword2_Enter);
            this.txtPassword2.Leave += new System.EventHandler(this.txtPassword2_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(92, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "iniciar sesión con su cuenta";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(66, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "o";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(65, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(66, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(66, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chello";
            // 
            // btnRegistarse
            // 
            this.btnRegistarse.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistarse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistarse.FlatAppearance.BorderSize = 0;
            this.btnRegistarse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistarse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarse.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistarse.Image = global::ProyectoEscritorio.Properties.Resources.btnRegistrar;
            this.btnRegistarse.Location = new System.Drawing.Point(109, 533);
            this.btnRegistarse.Name = "btnRegistarse";
            this.btnRegistarse.Size = new System.Drawing.Size(232, 75);
            this.btnRegistarse.TabIndex = 1;
            this.btnRegistarse.UseVisualStyleBackColor = false;
            this.btnRegistarse.Click += new System.EventHandler(this.btnRegistarse_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(446, 641);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(462, 680);
            this.MinimumSize = new System.Drawing.Size(462, 680);
            this.Name = "Registro";
            this.Text = "Chello";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.Enter += new System.EventHandler(this.Registro_Enter);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label MsgContrasena;
        private System.Windows.Forms.Label MsgCorreo;
        private System.Windows.Forms.Label MsgNombre;
        private System.Windows.Forms.Label MsgVacios;
    }
}