
namespace Aplicación
{
    partial class VentanaPrincipal
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.tbxFiltroPorNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lbListaArticulos = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lbCampo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPrecioFiltroAvanzado = new System.Windows.Forms.Label();
            this.lbIngreseDatos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.Location = new System.Drawing.Point(15, 24);
            this.dgvArticulos.MaximumSize = new System.Drawing.Size(573, 190);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(573, 190);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.ShowRowErrors = false;
            this.dgvArticulos.Size = new System.Drawing.Size(573, 190);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(599, 24);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(210, 190);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            this.pbxArticulo.Click += new System.EventHandler(this.pbxArticulo_Click);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(344, 230);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(91, 13);
            this.lbFiltro.TabIndex = 2;
            this.lbFiltro.Text = "Filtrar por nombre:";
            // 
            // tbxFiltroPorNombre
            // 
            this.tbxFiltroPorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFiltroPorNombre.Location = new System.Drawing.Point(438, 227);
            this.tbxFiltroPorNombre.Name = "tbxFiltroPorNombre";
            this.tbxFiltroPorNombre.Size = new System.Drawing.Size(150, 20);
            this.tbxFiltroPorNombre.TabIndex = 3;
            this.tbxFiltroPorNombre.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            this.tbxFiltroPorNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltroPorNombre_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 33);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(98, 220);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(77, 33);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(182, 220);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 33);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.Window;
            this.btnInfo.Location = new System.Drawing.Point(265, 220);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(77, 33);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Más info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lbListaArticulos
            // 
            this.lbListaArticulos.AutoSize = true;
            this.lbListaArticulos.Location = new System.Drawing.Point(15, 8);
            this.lbListaArticulos.Name = "lbListaArticulos";
            this.lbListaArticulos.Size = new System.Drawing.Size(85, 13);
            this.lbListaArticulos.TabIndex = 8;
            this.lbListaArticulos.Text = "Lista de atículos";
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(84, 42);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 21);
            this.cbxCampo.TabIndex = 10;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(296, 42);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 11;
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Location = new System.Drawing.Point(38, 45);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(40, 13);
            this.lbCampo.TabIndex = 12;
            this.lbCampo.Text = "Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Criterio";
            // 
            // tbxFiltroAvanzado
            // 
            this.tbxFiltroAvanzado.Location = new System.Drawing.Point(498, 42);
            this.tbxFiltroAvanzado.MaxLength = 100;
            this.tbxFiltroAvanzado.Name = "tbxFiltroAvanzado";
            this.tbxFiltroAvanzado.Size = new System.Drawing.Size(121, 20);
            this.tbxFiltroAvanzado.TabIndex = 14;
            this.tbxFiltroAvanzado.TextChanged += new System.EventHandler(this.tbxFiltroAvanzado_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filtro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(645, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 33);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPrecioFiltroAvanzado);
            this.groupBox1.Controls.Add(this.cbxCampo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxCriterio);
            this.groupBox1.Controls.Add(this.lbCampo);
            this.groupBox1.Controls.Add(this.tbxFiltroAvanzado);
            this.groupBox1.Location = new System.Drawing.Point(27, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 94);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Avanzado";
            // 
            // lbPrecioFiltroAvanzado
            // 
            this.lbPrecioFiltroAvanzado.AutoSize = true;
            this.lbPrecioFiltroAvanzado.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPrecioFiltroAvanzado.Location = new System.Drawing.Point(495, 65);
            this.lbPrecioFiltroAvanzado.Name = "lbPrecioFiltroAvanzado";
            this.lbPrecioFiltroAvanzado.Size = new System.Drawing.Size(89, 13);
            this.lbPrecioFiltroAvanzado.TabIndex = 17;
            this.lbPrecioFiltroAvanzado.Text = "Ingrese un precio";
            // 
            // lbIngreseDatos
            // 
            this.lbIngreseDatos.AutoSize = true;
            this.lbIngreseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbIngreseDatos.Location = new System.Drawing.Point(30, 367);
            this.lbIngreseDatos.Name = "lbIngreseDatos";
            this.lbIngreseDatos.Size = new System.Drawing.Size(175, 20);
            this.lbIngreseDatos.TabIndex = 17;
            this.lbIngreseDatos.Text = "Ingrese todos los datos";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(821, 407);
            this.Controls.Add(this.lbIngreseDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbListaArticulos);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxFiltroPorNombre);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(837, 446);
            this.MinimumSize = new System.Drawing.Size(837, 446);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox tbxFiltroPorNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lbListaArticulos;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFiltroAvanzado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbIngreseDatos;
        private System.Windows.Forms.Label lbPrecioFiltroAvanzado;
    }
}

