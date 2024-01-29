using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;

namespace Aplicación
{
    public partial class VentanaSecundaria : Form
    {
        private Articulos articulos = null;
        private OpenFileDialog archivo = null;
        public VentanaSecundaria()
        {
            InitializeComponent();
            Text = "Agregar articulo";
        }
        public VentanaSecundaria(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = "Modificar articulo";
        }
        private void VentanaSecundaria_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            cargarImagen();

            try
            {
                cbxMarca.DataSource = marca.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                cbxMarca.SelectedIndex = -1;
                cbxCategoria.SelectedIndex = -1;

                if (articulos != null)
                {
                    tbxCodigo.Text = articulos.Codigo;
                    tbxNombre.Text = articulos.Nombre;
                    tbxDescripcion.Text = articulos.Descripcion;
                    tbxImagenUrl.Text = articulos.ImagenUrl;
                    cargarImagen(articulos.ImagenUrl);
                    cbxCategoria.SelectedValue = articulos.Categorias.Id;
                    cbxMarca.SelectedValue = articulos.Marcas.Id;
                    tbxPrecio.Text = articulos.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void cargarImagen(string imagen)
        {
            {
                try
                {
                    pbxArticulo.Load(imagen);
                }
                catch (Exception)
                {
                    pbxArticulo.Load("https://cdnx.jumpseller.com/patagon-shop/image/38339252/resize/640/640?1691509015");
                }
            }
        }
        public void cargarImagen()
        {
            pbxArticulo.Load("https://cdnx.jumpseller.com/patagon-shop/image/38339252/resize/640/640?1691509015");
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            string path = @"C:\Imagenes-Aplicación\";
            try
            {
                if (validarAceptar())
                {
                    return;
                }

                if (articulos == null)
                {
                    articulos = new Articulos();
                }

                articulos.Codigo = tbxCodigo.Text.ToUpper();
                articulos.Nombre = tbxNombre.Text;
                articulos.Descripcion = tbxDescripcion.Text;
                articulos.ImagenUrl = tbxImagenUrl.Text;
                articulos.Categorias = (Categorias)cbxCategoria.SelectedItem;
                articulos.Marcas = (Marcas)cbxMarca.SelectedItem;
                articulos.Precio = int.Parse(tbxPrecio.Text);

                if (articulos.Id != 0)
                {
                    negocio.modificar(articulos);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulos);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (!string.IsNullOrEmpty(tbxImagenUrl.Text) && !tbxImagenUrl.Text.ToUpper().Contains("HTTP"))
                {
                    string ruta = Path.Combine(path, Path.GetFileName(tbxImagenUrl.Text));
                    if (File.Exists(ruta))
                    {
                        File.Delete(ruta);
                    }
                    if (archivo != null && File.Exists(archivo.FileName))
                    {
                        File.Copy(archivo.FileName, ruta);
                    }                 
                }
                
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool validarAceptar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            if (string.IsNullOrEmpty(tbxCodigo.Text) || string.IsNullOrEmpty(tbxNombre.Text) || cbxMarca.SelectedIndex < 0 || cbxCategoria.SelectedIndex < 0 || string.IsNullOrEmpty(tbxPrecio.Text))
            {
                lbDatosObligatorios.ForeColor = Color.Red;

                if (string.IsNullOrEmpty(tbxCodigo.Text))
                {
                    lbCodigoCheck.ForeColor = Color.Red;
                }
                else
                {
                    lbCodigoCheck.ForeColor = System.Drawing.SystemColors.Control;
                }

                if (string.IsNullOrEmpty(tbxNombre.Text))
                {
                    lbNombreCheck.ForeColor = Color.Red;
                }
                else
                {
                    lbNombreCheck.ForeColor = System.Drawing.SystemColors.Control;
                }

                if (cbxMarca.SelectedIndex == -1)
                {
                    lbMarcaCheck.ForeColor = Color.Red;
                }
                else
                {
                    lbMarcaCheck.ForeColor = System.Drawing.SystemColors.Control;
                }

                if (cbxCategoria.SelectedIndex == -1)
                {
                    lbCategoriaCheck.ForeColor = Color.Red;
                }
                else
                {
                    lbCategoriaCheck.ForeColor = System.Drawing.SystemColors.Control;
                }

                if (string.IsNullOrWhiteSpace(tbxPrecio.Text))
                {
                    lbPrecioCheck.ForeColor = Color.Red;
                }
                else
                {
                    lbPrecioCheck.ForeColor = System.Drawing.SystemColors.Control;                 
                }
                return true;
            }
            return false;
        }
        private void tbxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tbxCodigo.Text.Length >= 3)
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbxNombre.Text.Length >= 25)
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void tbxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbxDescripcion.Text.Length >= 25)
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            if (tbxPrecio.Text.Length >= 9)
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCodigo.Text))
            {
                lbCodigoCheck.ForeColor = Color.Red;
            }
            else
            {
                lbCodigoCheck.ForeColor = System.Drawing.SystemColors.Control;
            }
        }
        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNombre.Text))
            {
                lbNombreCheck.ForeColor = Color.Red;
            }
            else
            {
                lbNombreCheck.ForeColor = System.Drawing.SystemColors.Control;
            }
        }
        private void tbxDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDescripcion.Text))
            {
                lbPrecioCheck.ForeColor = Color.Red;
            }
            else
            {
                lbPrecioCheck.ForeColor = System.Drawing.SystemColors.Control;
            }
        }
        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.SelectedIndex == -2)
            {
                lbCategoriaCheck.ForeColor = Color.Red;
            }
            else
            {
                lbCategoriaCheck.ForeColor = System.Drawing.SystemColors.Control;
            }
        }
        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarca.SelectedIndex == -2)
            {
                lbMarcaCheck.ForeColor = Color.Red;
            }
            else
            {
                lbMarcaCheck.ForeColor = System.Drawing.SystemColors.Control;
            }
        }
        private void tbxPrecio_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPrecio.Text))
            {
                lbPrecioCheck.ForeColor = Color.Red;
            }
            else
            {
                lbPrecioCheck.ForeColor = System.Drawing.SystemColors.Control;
            }
        }
        private void tbxImagenUrl_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(tbxImagenUrl.Text);

            if (!string.IsNullOrEmpty(tbxImagenUrl.Text) && !tbxImagenUrl.Text.ToUpper().Contains("HTTP"))
            {
                lbImagenLocal.ForeColor = Color.Black;
            }
            else
            {
                lbImagenLocal.ForeColor = System.Drawing.SystemColors.Control;
            }
        }
        private void btnAgregarImagen_Click_1(object sender, EventArgs e)
        {
            string path = @"C:\Imagenes-Aplicación\";
            Directory.CreateDirectory(path);
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg| png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbxImagenUrl.Text = archivo.FileName;
                cargarImagen(tbxImagenUrl.Text);
            }          
        }
    }
}




