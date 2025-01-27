﻿
namespace Test_WindowsForm
{
    partial class FormBaseDeDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseDeDatos));
            this.txtNombreServidor = new System.Windows.Forms.TextBox();
            this.lblNombreServidor = new System.Windows.Forms.Label();
            this.lblNombreBaseDeDatos = new System.Windows.Forms.Label();
            this.txtNombreBaseDatos = new System.Windows.Forms.TextBox();
            this.btnEstablecerConexion = new System.Windows.Forms.Button();
            this.grpBoxEstadoConexion = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambiarTabla = new System.Windows.Forms.Button();
            this.pgrssBarEstadoConexion = new BControlesDeUsuario.UCProgressBar();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lstBoxMostrar = new System.Windows.Forms.ListBox();
            this.lstBoxEliminar = new System.Windows.Forms.ListBox();
            this.lstBoxModificar = new System.Windows.Forms.ListBox();
            this.lblNombreTabla = new System.Windows.Forms.Label();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.btnObtenerLista = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpGestion = new System.Windows.Forms.GroupBox();
            this.grpBoxEstadoConexion.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.grpGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreServidor
            // 
            this.txtNombreServidor.Location = new System.Drawing.Point(123, 11);
            this.txtNombreServidor.Name = "txtNombreServidor";
            this.txtNombreServidor.Size = new System.Drawing.Size(187, 23);
            this.txtNombreServidor.TabIndex = 0;
            // 
            // lblNombreServidor
            // 
            this.lblNombreServidor.AutoSize = true;
            this.lblNombreServidor.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreServidor.Location = new System.Drawing.Point(7, 15);
            this.lblNombreServidor.Name = "lblNombreServidor";
            this.lblNombreServidor.Size = new System.Drawing.Size(97, 15);
            this.lblNombreServidor.TabIndex = 1;
            this.lblNombreServidor.Text = "Nombre Servidor";
            // 
            // lblNombreBaseDeDatos
            // 
            this.lblNombreBaseDeDatos.AutoSize = true;
            this.lblNombreBaseDeDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreBaseDeDatos.Location = new System.Drawing.Point(328, 14);
            this.lblNombreBaseDeDatos.Name = "lblNombreBaseDeDatos";
            this.lblNombreBaseDeDatos.Size = new System.Drawing.Size(126, 15);
            this.lblNombreBaseDeDatos.TabIndex = 2;
            this.lblNombreBaseDeDatos.Text = "Nombre base de datos";
            // 
            // txtNombreBaseDatos
            // 
            this.txtNombreBaseDatos.Location = new System.Drawing.Point(466, 11);
            this.txtNombreBaseDatos.Name = "txtNombreBaseDatos";
            this.txtNombreBaseDatos.Size = new System.Drawing.Size(187, 23);
            this.txtNombreBaseDatos.TabIndex = 3;
            // 
            // btnEstablecerConexion
            // 
            this.btnEstablecerConexion.Location = new System.Drawing.Point(664, 9);
            this.btnEstablecerConexion.Name = "btnEstablecerConexion";
            this.btnEstablecerConexion.Size = new System.Drawing.Size(128, 27);
            this.btnEstablecerConexion.TabIndex = 4;
            this.btnEstablecerConexion.Text = "Establecer Conexion";
            this.btnEstablecerConexion.UseVisualStyleBackColor = true;
            // 
            // grpBoxEstadoConexion
            // 
            this.grpBoxEstadoConexion.Controls.Add(this.btnSalir);
            this.grpBoxEstadoConexion.Controls.Add(this.btnCambiarTabla);
            this.grpBoxEstadoConexion.Controls.Add(this.pgrssBarEstadoConexion);
            this.grpBoxEstadoConexion.Location = new System.Drawing.Point(1, 413);
            this.grpBoxEstadoConexion.Name = "grpBoxEstadoConexion";
            this.grpBoxEstadoConexion.Size = new System.Drawing.Size(797, 52);
            this.grpBoxEstadoConexion.TabIndex = 7;
            this.grpBoxEstadoConexion.TabStop = false;
            this.grpBoxEstadoConexion.Text = "Estado de la conexion";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(661, 23);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 27);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCambiarTabla
            // 
            this.btnCambiarTabla.Location = new System.Drawing.Point(525, 23);
            this.btnCambiarTabla.Name = "btnCambiarTabla";
            this.btnCambiarTabla.Size = new System.Drawing.Size(130, 27);
            this.btnCambiarTabla.TabIndex = 20;
            this.btnCambiarTabla.Text = "Cambiar Tabla";
            this.btnCambiarTabla.UseVisualStyleBackColor = true;
            this.btnCambiarTabla.Click += new System.EventHandler(this.btnCambiarTabla_Click);
            // 
            // pgrssBarEstadoConexion
            // 
            this.pgrssBarEstadoConexion.Location = new System.Drawing.Point(6, 24);
            this.pgrssBarEstadoConexion.Name = "pgrssBarEstadoConexion";
            this.pgrssBarEstadoConexion.Size = new System.Drawing.Size(513, 23);
            this.pgrssBarEstadoConexion.TabIndex = 3;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lstBoxMostrar);
            this.pnlPrincipal.Controls.Add(this.lstBoxEliminar);
            this.pnlPrincipal.Controls.Add(this.lstBoxModificar);
            this.pnlPrincipal.Location = new System.Drawing.Point(7, 118);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(785, 290);
            this.pnlPrincipal.TabIndex = 8;
            // 
            // lstBoxMostrar
            // 
            this.lstBoxMostrar.FormattingEnabled = true;
            this.lstBoxMostrar.ItemHeight = 15;
            this.lstBoxMostrar.Location = new System.Drawing.Point(3, 13);
            this.lstBoxMostrar.Name = "lstBoxMostrar";
            this.lstBoxMostrar.Size = new System.Drawing.Size(779, 274);
            this.lstBoxMostrar.TabIndex = 2;
            // 
            // lstBoxEliminar
            // 
            this.lstBoxEliminar.FormattingEnabled = true;
            this.lstBoxEliminar.ItemHeight = 15;
            this.lstBoxEliminar.Location = new System.Drawing.Point(3, 13);
            this.lstBoxEliminar.Name = "lstBoxEliminar";
            this.lstBoxEliminar.Size = new System.Drawing.Size(779, 274);
            this.lstBoxEliminar.TabIndex = 1;
            this.lstBoxEliminar.SelectedIndexChanged += new System.EventHandler(this.lstBoxEliminar_SelectedIndexChanged);
            // 
            // lstBoxModificar
            // 
            this.lstBoxModificar.FormattingEnabled = true;
            this.lstBoxModificar.ItemHeight = 15;
            this.lstBoxModificar.Location = new System.Drawing.Point(3, 13);
            this.lstBoxModificar.Name = "lstBoxModificar";
            this.lstBoxModificar.Size = new System.Drawing.Size(779, 274);
            this.lstBoxModificar.TabIndex = 0;
            this.lstBoxModificar.SelectedIndexChanged += new System.EventHandler(this.lstBoxModificar_SelectedIndexChanged);
            // 
            // lblNombreTabla
            // 
            this.lblNombreTabla.AutoSize = true;
            this.lblNombreTabla.Location = new System.Drawing.Point(6, 24);
            this.lblNombreTabla.Name = "lblNombreTabla";
            this.lblNombreTabla.Size = new System.Drawing.Size(81, 15);
            this.lblNombreTabla.TabIndex = 10;
            this.lblNombreTabla.Text = "Nombre Tabla";
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(116, 20);
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(242, 23);
            this.txtNombreTabla.TabIndex = 11;
            // 
            // btnObtenerLista
            // 
            this.btnObtenerLista.Location = new System.Drawing.Point(404, 18);
            this.btnObtenerLista.Name = "btnObtenerLista";
            this.btnObtenerLista.Size = new System.Drawing.Size(90, 27);
            this.btnObtenerLista.TabIndex = 12;
            this.btnObtenerLista.Text = "Cargar";
            this.btnObtenerLista.UseVisualStyleBackColor = true;
            this.btnObtenerLista.Click += new System.EventHandler(this.btnObtenerLista_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(499, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 27);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(7, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(785, 23);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "BIENVENIDO";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(595, 18);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 27);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(691, 18);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 27);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.txtNombreTabla);
            this.grpGestion.Controls.Add(this.btnEliminar);
            this.grpGestion.Controls.Add(this.lblNombreTabla);
            this.grpGestion.Controls.Add(this.btnModificar);
            this.grpGestion.Controls.Add(this.btnObtenerLista);
            this.grpGestion.Controls.Add(this.btnAgregar);
            this.grpGestion.Location = new System.Drawing.Point(7, 74);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Size = new System.Drawing.Size(785, 56);
            this.grpGestion.TabIndex = 21;
            this.grpGestion.TabStop = false;
            this.grpGestion.Text = "Gestion";
            // 
            // FormBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.grpGestion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.grpBoxEstadoConexion);
            this.Controls.Add(this.btnEstablecerConexion);
            this.Controls.Add(this.txtNombreBaseDatos);
            this.Controls.Add(this.lblNombreBaseDeDatos);
            this.Controls.Add(this.lblNombreServidor);
            this.Controls.Add(this.txtNombreServidor);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBaseDeDatos";
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.FormBaseDeDatos_Load);
            this.grpBoxEstadoConexion.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.grpGestion.ResumeLayout(false);
            this.grpGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreServidor;
        private System.Windows.Forms.Label lblNombreServidor;
        private System.Windows.Forms.Label lblNombreBaseDeDatos;
        private System.Windows.Forms.TextBox txtNombreBaseDatos;
        private System.Windows.Forms.Button btnEstablecerConexion;
        private System.Windows.Forms.GroupBox grpBoxEstadoConexion;
        private BControlesDeUsuario.UCProgressBar pgrssBarEstadoConexion;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ListBox lstBoxModificar;
        private System.Windows.Forms.Label lblNombreTabla;
        private System.Windows.Forms.TextBox txtNombreTabla;
        private System.Windows.Forms.Button btnObtenerLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstBoxEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.Button btnCambiarTabla;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstBoxMostrar;
    }
}