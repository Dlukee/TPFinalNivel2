
namespace Aplicación
{
    partial class VentanaSecundaria
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
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxImagenUrl = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lbCodigoCheck = new System.Windows.Forms.Label();
            this.lbNombreCheck = new System.Windows.Forms.Label();
            this.lbCategoriaCheck = new System.Windows.Forms.Label();
            this.lbMarcaCheck = new System.Windows.Forms.Label();
            this.lbDatosObligatorios = new System.Windows.Forms.Label();
            this.lbSoloNumeros = new System.Windows.Forms.Label();
            this.lbPrecioCheck = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lbImagenLocal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxArticulo.Location = new System.Drawing.Point(404, 30);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(344, 320);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 2;
            this.pbxArticulo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ImagenUrl:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(139, 27);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(234, 29);
            this.tbxCodigo.TabIndex = 0;
            this.tbxCodigo.TextChanged += new System.EventHandler(this.tbxCodigo_TextChanged);
            this.tbxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCodigo_KeyPress);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(139, 75);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(234, 29);
            this.tbxNombre.TabIndex = 1;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca:";
            // 
            // tbxImagenUrl
            // 
            this.tbxImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxImagenUrl.Location = new System.Drawing.Point(139, 170);
            this.tbxImagenUrl.Name = "tbxImagenUrl";
            this.tbxImagenUrl.Size = new System.Drawing.Size(199, 29);
            this.tbxImagenUrl.TabIndex = 3;
            this.tbxImagenUrl.TextChanged += new System.EventHandler(this.tbxImagenUrl_TextChanged);
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(139, 122);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(234, 29);
            this.tbxDescripcion.TabIndex = 2;
            this.tbxDescripcion.TextChanged += new System.EventHandler(this.tbxDescripcion_TextChanged);
            this.tbxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDescripcion_KeyPress);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(139, 220);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(234, 32);
            this.cbxCategoria.TabIndex = 4;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(139, 270);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(234, 32);
            this.cbxMarca.TabIndex = 5;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(239, 382);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 34);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(404, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 34);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio:";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrecio.Location = new System.Drawing.Point(139, 323);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(234, 29);
            this.tbxPrecio.TabIndex = 14;
            this.tbxPrecio.TextChanged += new System.EventHandler(this.tbxPrecio_TextChanged);
            this.tbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecio_KeyPress);
            // 
            // lbCodigoCheck
            // 
            this.lbCodigoCheck.AutoSize = true;
            this.lbCodigoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCodigoCheck.Location = new System.Drawing.Point(375, 30);
            this.lbCodigoCheck.Name = "lbCodigoCheck";
            this.lbCodigoCheck.Size = new System.Drawing.Size(23, 24);
            this.lbCodigoCheck.TabIndex = 15;
            this.lbCodigoCheck.Text = "◀";
            // 
            // lbNombreCheck
            // 
            this.lbNombreCheck.AutoSize = true;
            this.lbNombreCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNombreCheck.Location = new System.Drawing.Point(375, 78);
            this.lbNombreCheck.Name = "lbNombreCheck";
            this.lbNombreCheck.Size = new System.Drawing.Size(23, 24);
            this.lbNombreCheck.TabIndex = 17;
            this.lbNombreCheck.Text = "◀";
            // 
            // lbCategoriaCheck
            // 
            this.lbCategoriaCheck.AutoSize = true;
            this.lbCategoriaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCategoriaCheck.Location = new System.Drawing.Point(375, 223);
            this.lbCategoriaCheck.Name = "lbCategoriaCheck";
            this.lbCategoriaCheck.Size = new System.Drawing.Size(23, 24);
            this.lbCategoriaCheck.TabIndex = 16;
            this.lbCategoriaCheck.Text = "◀";
            // 
            // lbMarcaCheck
            // 
            this.lbMarcaCheck.AutoSize = true;
            this.lbMarcaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcaCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMarcaCheck.Location = new System.Drawing.Point(375, 273);
            this.lbMarcaCheck.Name = "lbMarcaCheck";
            this.lbMarcaCheck.Size = new System.Drawing.Size(23, 24);
            this.lbMarcaCheck.TabIndex = 18;
            this.lbMarcaCheck.Text = "◀";
            // 
            // lbDatosObligatorios
            // 
            this.lbDatosObligatorios.AutoSize = true;
            this.lbDatosObligatorios.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDatosObligatorios.Location = new System.Drawing.Point(136, 11);
            this.lbDatosObligatorios.Name = "lbDatosObligatorios";
            this.lbDatosObligatorios.Size = new System.Drawing.Size(133, 13);
            this.lbDatosObligatorios.TabIndex = 19;
            this.lbDatosObligatorios.Text = "¡DATOS OBLIGATORIOS!";
            // 
            // lbSoloNumeros
            // 
            this.lbSoloNumeros.AutoSize = true;
            this.lbSoloNumeros.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSoloNumeros.Location = new System.Drawing.Point(136, 355);
            this.lbSoloNumeros.Name = "lbSoloNumeros";
            this.lbSoloNumeros.Size = new System.Drawing.Size(71, 13);
            this.lbSoloNumeros.TabIndex = 20;
            this.lbSoloNumeros.Text = "Solo numeros";
            // 
            // lbPrecioCheck
            // 
            this.lbPrecioCheck.AutoSize = true;
            this.lbPrecioCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPrecioCheck.Location = new System.Drawing.Point(375, 326);
            this.lbPrecioCheck.Name = "lbPrecioCheck";
            this.lbPrecioCheck.Size = new System.Drawing.Size(23, 24);
            this.lbPrecioCheck.TabIndex = 21;
            this.lbPrecioCheck.Text = "◀";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(344, 170);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarImagen.TabIndex = 29;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click_1);
            // 
            // lbImagenLocal
            // 
            this.lbImagenLocal.AutoSize = true;
            this.lbImagenLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagenLocal.ForeColor = System.Drawing.SystemColors.Control;
            this.lbImagenLocal.Location = new System.Drawing.Point(139, 202);
            this.lbImagenLocal.Name = "lbImagenLocal";
            this.lbImagenLocal.Size = new System.Drawing.Size(161, 12);
            this.lbImagenLocal.TabIndex = 30;
            this.lbImagenLocal.Text = "Guardada en C:\\Imagenes-Aplicación ";
            // 
            // VentanaSecundaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 441);
            this.Controls.Add(this.lbImagenLocal);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lbPrecioCheck);
            this.Controls.Add(this.lbSoloNumeros);
            this.Controls.Add(this.lbDatosObligatorios);
            this.Controls.Add(this.lbMarcaCheck);
            this.Controls.Add(this.lbNombreCheck);
            this.Controls.Add(this.lbCategoriaCheck);
            this.Controls.Add(this.lbCodigoCheck);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.tbxImagenUrl);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxArticulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(786, 480);
            this.MinimumSize = new System.Drawing.Size(786, 480);
            this.Name = "VentanaSecundaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaSecundaria";
            this.Load += new System.EventHandler(this.VentanaSecundaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxImagenUrl;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lbCodigoCheck;
        private System.Windows.Forms.Label lbNombreCheck;
        private System.Windows.Forms.Label lbCategoriaCheck;
        private System.Windows.Forms.Label lbMarcaCheck;
        private System.Windows.Forms.Label lbDatosObligatorios;
        private System.Windows.Forms.Label lbSoloNumeros;
        private System.Windows.Forms.Label lbPrecioCheck;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lbImagenLocal;
    }
}