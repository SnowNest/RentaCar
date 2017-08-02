namespace RentaCar
{
    partial class RentaCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentaCar));
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageReservas = new System.Windows.Forms.TabPage();
            this.tabControlReservas = new System.Windows.Forms.TabControl();
            this.tabAgregarReserva = new System.Windows.Forms.TabPage();
            this.tabBorrarReserva = new System.Windows.Forms.TabPage();
            this.tabModificarReserva = new System.Windows.Forms.TabPage();
            this.tabPageAutomoviles = new System.Windows.Forms.TabPage();
            this.tabControlAutomoviles = new System.Windows.Forms.TabControl();
            this.tabAgregarAutomovil = new System.Windows.Forms.TabPage();
            this.tabEliminarAutomovil = new System.Windows.Forms.TabPage();
            this.tabModificarAutomovil = new System.Windows.Forms.TabPage();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.tabControlUsuarios = new System.Windows.Forms.TabControl();
            this.tabAgregarUsuario = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAgregarUsuarionivel = new System.Windows.Forms.ComboBox();
            this.txtAgregarUsuarioContrasenaV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAgregarUsuarioContrasena = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAgregarUsuarioDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAgregarUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgregarUsuarioMaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgregarUsuarioPaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgregarUsuarioNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgregarUsuarioUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabEliminarUsuario = new System.Windows.Forms.TabPage();
            this.tabModificarUsuario = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageReservas.SuspendLayout();
            this.tabControlReservas.SuspendLayout();
            this.tabPageAutomoviles.SuspendLayout();
            this.tabControlAutomoviles.SuspendLayout();
            this.tabPageUsuarios.SuspendLayout();
            this.tabControlUsuarios.SuspendLayout();
            this.tabAgregarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(334, 14);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsuario.TabIndex = 0;
            // 
            // txtLoginContrasena
            // 
            this.txtLoginContrasena.Location = new System.Drawing.Point(510, 10);
            this.txtLoginContrasena.Name = "txtLoginContrasena";
            this.txtLoginContrasena.PasswordChar = '*';
            this.txtLoginContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtLoginContrasena.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(616, 8);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Acceder";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 8);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Salir";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPageReservas);
            this.tabControlPrincipal.Controls.Add(this.tabPageAutomoviles);
            this.tabControlPrincipal.Controls.Add(this.tabPageUsuarios);
            this.tabControlPrincipal.Location = new System.Drawing.Point(-2, 40);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(792, 529);
            this.tabControlPrincipal.TabIndex = 6;
            // 
            // tabPageReservas
            // 
            this.tabPageReservas.Controls.Add(this.tabControlReservas);
            this.tabPageReservas.Location = new System.Drawing.Point(4, 22);
            this.tabPageReservas.Name = "tabPageReservas";
            this.tabPageReservas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReservas.Size = new System.Drawing.Size(784, 503);
            this.tabPageReservas.TabIndex = 0;
            this.tabPageReservas.Text = "Reservas ";
            this.tabPageReservas.UseVisualStyleBackColor = true;
            // 
            // tabControlReservas
            // 
            this.tabControlReservas.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlReservas.Controls.Add(this.tabAgregarReserva);
            this.tabControlReservas.Controls.Add(this.tabBorrarReserva);
            this.tabControlReservas.Controls.Add(this.tabModificarReserva);
            this.tabControlReservas.Location = new System.Drawing.Point(3, 3);
            this.tabControlReservas.Multiline = true;
            this.tabControlReservas.Name = "tabControlReservas";
            this.tabControlReservas.SelectedIndex = 0;
            this.tabControlReservas.Size = new System.Drawing.Size(785, 504);
            this.tabControlReservas.TabIndex = 0;
            // 
            // tabAgregarReserva
            // 
            this.tabAgregarReserva.Location = new System.Drawing.Point(23, 4);
            this.tabAgregarReserva.Name = "tabAgregarReserva";
            this.tabAgregarReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregarReserva.Size = new System.Drawing.Size(758, 496);
            this.tabAgregarReserva.TabIndex = 0;
            this.tabAgregarReserva.Text = "Agregar";
            this.tabAgregarReserva.UseVisualStyleBackColor = true;
            // 
            // tabBorrarReserva
            // 
            this.tabBorrarReserva.Location = new System.Drawing.Point(23, 4);
            this.tabBorrarReserva.Name = "tabBorrarReserva";
            this.tabBorrarReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrarReserva.Size = new System.Drawing.Size(758, 496);
            this.tabBorrarReserva.TabIndex = 1;
            this.tabBorrarReserva.Text = "Borrar";
            this.tabBorrarReserva.UseVisualStyleBackColor = true;
            // 
            // tabModificarReserva
            // 
            this.tabModificarReserva.Location = new System.Drawing.Point(23, 4);
            this.tabModificarReserva.Name = "tabModificarReserva";
            this.tabModificarReserva.Size = new System.Drawing.Size(758, 496);
            this.tabModificarReserva.TabIndex = 2;
            this.tabModificarReserva.Text = "Modificar";
            this.tabModificarReserva.UseVisualStyleBackColor = true;
            // 
            // tabPageAutomoviles
            // 
            this.tabPageAutomoviles.Controls.Add(this.tabControlAutomoviles);
            this.tabPageAutomoviles.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutomoviles.Name = "tabPageAutomoviles";
            this.tabPageAutomoviles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutomoviles.Size = new System.Drawing.Size(784, 503);
            this.tabPageAutomoviles.TabIndex = 1;
            this.tabPageAutomoviles.Text = "Automoviles";
            this.tabPageAutomoviles.UseVisualStyleBackColor = true;
            // 
            // tabControlAutomoviles
            // 
            this.tabControlAutomoviles.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAutomoviles.Controls.Add(this.tabAgregarAutomovil);
            this.tabControlAutomoviles.Controls.Add(this.tabEliminarAutomovil);
            this.tabControlAutomoviles.Controls.Add(this.tabModificarAutomovil);
            this.tabControlAutomoviles.Location = new System.Drawing.Point(3, 3);
            this.tabControlAutomoviles.Multiline = true;
            this.tabControlAutomoviles.Name = "tabControlAutomoviles";
            this.tabControlAutomoviles.SelectedIndex = 0;
            this.tabControlAutomoviles.Size = new System.Drawing.Size(785, 504);
            this.tabControlAutomoviles.TabIndex = 0;
            // 
            // tabAgregarAutomovil
            // 
            this.tabAgregarAutomovil.Location = new System.Drawing.Point(23, 4);
            this.tabAgregarAutomovil.Name = "tabAgregarAutomovil";
            this.tabAgregarAutomovil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregarAutomovil.Size = new System.Drawing.Size(758, 496);
            this.tabAgregarAutomovil.TabIndex = 0;
            this.tabAgregarAutomovil.Text = "Agregar";
            this.tabAgregarAutomovil.UseVisualStyleBackColor = true;
            // 
            // tabEliminarAutomovil
            // 
            this.tabEliminarAutomovil.Location = new System.Drawing.Point(23, 4);
            this.tabEliminarAutomovil.Name = "tabEliminarAutomovil";
            this.tabEliminarAutomovil.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarAutomovil.Size = new System.Drawing.Size(758, 496);
            this.tabEliminarAutomovil.TabIndex = 1;
            this.tabEliminarAutomovil.Text = "Eliminar";
            this.tabEliminarAutomovil.UseVisualStyleBackColor = true;
            // 
            // tabModificarAutomovil
            // 
            this.tabModificarAutomovil.Location = new System.Drawing.Point(23, 4);
            this.tabModificarAutomovil.Name = "tabModificarAutomovil";
            this.tabModificarAutomovil.Size = new System.Drawing.Size(758, 496);
            this.tabModificarAutomovil.TabIndex = 2;
            this.tabModificarAutomovil.Text = "Modificar";
            this.tabModificarAutomovil.UseVisualStyleBackColor = true;
            // 
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.Controls.Add(this.tabControlUsuarios);
            this.tabPageUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuarios.Size = new System.Drawing.Size(784, 503);
            this.tabPageUsuarios.TabIndex = 2;
            this.tabPageUsuarios.Text = "Usuarios";
            this.tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlUsuarios.Controls.Add(this.tabAgregarUsuario);
            this.tabControlUsuarios.Controls.Add(this.tabEliminarUsuario);
            this.tabControlUsuarios.Controls.Add(this.tabModificarUsuario);
            this.tabControlUsuarios.Location = new System.Drawing.Point(3, 3);
            this.tabControlUsuarios.Multiline = true;
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(785, 504);
            this.tabControlUsuarios.TabIndex = 0;
            // 
            // tabAgregarUsuario
            // 
            this.tabAgregarUsuario.Controls.Add(this.btnAgregarUsuario);
            this.tabAgregarUsuario.Controls.Add(this.label12);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarionivel);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarioContrasenaV);
            this.tabAgregarUsuario.Controls.Add(this.label11);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarioContrasena);
            this.tabAgregarUsuario.Controls.Add(this.label10);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarioDireccion);
            this.tabAgregarUsuario.Controls.Add(this.label9);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarioTelefono);
            this.tabAgregarUsuario.Controls.Add(this.label8);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarioMaterno);
            this.tabAgregarUsuario.Controls.Add(this.label7);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarioPaterno);
            this.tabAgregarUsuario.Controls.Add(this.label6);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarioNombre);
            this.tabAgregarUsuario.Controls.Add(this.label5);
            this.tabAgregarUsuario.Controls.Add(this.txtAgregarUsuarioUsuario);
            this.tabAgregarUsuario.Controls.Add(this.label4);
            this.tabAgregarUsuario.Location = new System.Drawing.Point(23, 4);
            this.tabAgregarUsuario.Name = "tabAgregarUsuario";
            this.tabAgregarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregarUsuario.Size = new System.Drawing.Size(758, 496);
            this.tabAgregarUsuario.TabIndex = 0;
            this.tabAgregarUsuario.Text = "Agregar";
            this.tabAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Nivel:";
            // 
            // txtAgregarUsuarionivel
            // 
            this.txtAgregarUsuarionivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAgregarUsuarionivel.FormattingEnabled = true;
            this.txtAgregarUsuarionivel.Items.AddRange(new object[] {
            "administrador",
            "vendedor"});
            this.txtAgregarUsuarionivel.Location = new System.Drawing.Point(75, 235);
            this.txtAgregarUsuarionivel.Name = "txtAgregarUsuarionivel";
            this.txtAgregarUsuarionivel.Size = new System.Drawing.Size(100, 21);
            this.txtAgregarUsuarionivel.TabIndex = 16;
            // 
            // txtAgregarUsuarioContrasenaV
            // 
            this.txtAgregarUsuarioContrasenaV.Location = new System.Drawing.Point(75, 209);
            this.txtAgregarUsuarioContrasenaV.Name = "txtAgregarUsuarioContrasenaV";
            this.txtAgregarUsuarioContrasenaV.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarUsuarioContrasenaV.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Contraseña:";
            // 
            // txtAgregarUsuarioContrasena
            // 
            this.txtAgregarUsuarioContrasena.Location = new System.Drawing.Point(75, 183);
            this.txtAgregarUsuarioContrasena.Name = "txtAgregarUsuarioContrasena";
            this.txtAgregarUsuarioContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarUsuarioContrasena.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Contraseña:";
            // 
            // txtAgregarUsuarioDireccion
            // 
            this.txtAgregarUsuarioDireccion.Location = new System.Drawing.Point(75, 157);
            this.txtAgregarUsuarioDireccion.Name = "txtAgregarUsuarioDireccion";
            this.txtAgregarUsuarioDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarUsuarioDireccion.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Direccion:";
            // 
            // txtAgregarUsuarioTelefono
            // 
            this.txtAgregarUsuarioTelefono.Location = new System.Drawing.Point(75, 131);
            this.txtAgregarUsuarioTelefono.Name = "txtAgregarUsuarioTelefono";
            this.txtAgregarUsuarioTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarUsuarioTelefono.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "telefono:";
            // 
            // txtAgregarUsuarioMaterno
            // 
            this.txtAgregarUsuarioMaterno.Location = new System.Drawing.Point(75, 105);
            this.txtAgregarUsuarioMaterno.Name = "txtAgregarUsuarioMaterno";
            this.txtAgregarUsuarioMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarUsuarioMaterno.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Materno:";
            // 
            // txtAgregarUsuarioPaterno
            // 
            this.txtAgregarUsuarioPaterno.Location = new System.Drawing.Point(75, 79);
            this.txtAgregarUsuarioPaterno.Name = "txtAgregarUsuarioPaterno";
            this.txtAgregarUsuarioPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarUsuarioPaterno.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Paterno:";
            // 
            // txtAgregarUsuarioNombre
            // 
            this.txtAgregarUsuarioNombre.Location = new System.Drawing.Point(75, 53);
            this.txtAgregarUsuarioNombre.Name = "txtAgregarUsuarioNombre";
            this.txtAgregarUsuarioNombre.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarUsuarioNombre.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre:";
            // 
            // txtAgregarUsuarioUsuario
            // 
            this.txtAgregarUsuarioUsuario.Location = new System.Drawing.Point(75, 27);
            this.txtAgregarUsuarioUsuario.Name = "txtAgregarUsuarioUsuario";
            this.txtAgregarUsuarioUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarUsuarioUsuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuario:";
            // 
            // tabEliminarUsuario
            // 
            this.tabEliminarUsuario.Location = new System.Drawing.Point(23, 4);
            this.tabEliminarUsuario.Name = "tabEliminarUsuario";
            this.tabEliminarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarUsuario.Size = new System.Drawing.Size(758, 496);
            this.tabEliminarUsuario.TabIndex = 1;
            this.tabEliminarUsuario.Text = "Eliminar";
            this.tabEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // tabModificarUsuario
            // 
            this.tabModificarUsuario.Location = new System.Drawing.Point(23, 4);
            this.tabModificarUsuario.Name = "tabModificarUsuario";
            this.tabModificarUsuario.Size = new System.Drawing.Size(758, 496);
            this.tabModificarUsuario.TabIndex = 2;
            this.tabModificarUsuario.Text = "Modificar";
            this.tabModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "RentaCarSytem © 2017";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(75, 262);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarUsuario.TabIndex = 18;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // RentaCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControlPrincipal);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginContrasena);
            this.Controls.Add(this.txtLoginUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RentaCar";
            this.Text = "RentaCar © 2017";
            this.Load += new System.EventHandler(this.RentaCar_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageReservas.ResumeLayout(false);
            this.tabControlReservas.ResumeLayout(false);
            this.tabPageAutomoviles.ResumeLayout(false);
            this.tabControlAutomoviles.ResumeLayout(false);
            this.tabPageUsuarios.ResumeLayout(false);
            this.tabControlUsuarios.ResumeLayout(false);
            this.tabAgregarUsuario.ResumeLayout(false);
            this.tabAgregarUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtLoginContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageReservas;
        private System.Windows.Forms.TabControl tabControlReservas;
        private System.Windows.Forms.TabPage tabAgregarReserva;
        private System.Windows.Forms.TabPage tabBorrarReserva;
        private System.Windows.Forms.TabPage tabModificarReserva;
        private System.Windows.Forms.TabPage tabPageAutomoviles;
        private System.Windows.Forms.TabControl tabControlAutomoviles;
        private System.Windows.Forms.TabPage tabAgregarAutomovil;
        private System.Windows.Forms.TabPage tabEliminarAutomovil;
        private System.Windows.Forms.TabPage tabModificarAutomovil;
        private System.Windows.Forms.TabPage tabPageUsuarios;
        private System.Windows.Forms.TabControl tabControlUsuarios;
        private System.Windows.Forms.TabPage tabAgregarUsuario;
        private System.Windows.Forms.TabPage tabEliminarUsuario;
        private System.Windows.Forms.TabPage tabModificarUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtAgregarUsuarionivel;
        private System.Windows.Forms.TextBox txtAgregarUsuarioContrasenaV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAgregarUsuarioContrasena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAgregarUsuarioDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAgregarUsuarioTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAgregarUsuarioMaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgregarUsuarioPaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAgregarUsuarioNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgregarUsuarioUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarUsuario;
    }
}

