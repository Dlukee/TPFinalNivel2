using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;
using System.IO;

namespace Aplicación
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            Text = "Artículos";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();

            cbxCampo.Items.Add("Codigo");
            cbxCampo.Items.Add("Categoria");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Precio");

        }
        private List<Articulos> listaArticulos;
        private void cargar()
        {
            ArticulosNegocio datos = new ArticulosNegocio();
            listaArticulos = datos.listar();
            dgvArticulos.DataSource = listaArticulos;
            cargarImagen(listaArticulos[0].ImagenUrl);
            ocultarColumnas();
        }
        private void cargarImagen(string imagen)
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
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            //dgvArticulos.Columns["Categorias"].Visible = false;
            //dgvArticulos.Columns["Marcas"].Visible = false;
            //dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VentanaSecundaria agregar = new VentanaSecundaria();
            agregar.ShowDialog();
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarSeleccion())
                {
                    return;
                }

                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                VentanaSecundaria Modificar = new VentanaSecundaria(seleccionado);
                string rutaAnterior = @"C:\Imagenes-Aplicación\" + Path.GetFileName(seleccionado.ImagenUrl);
                Modificar.ShowDialog();
                string rutaNueva = @"C:\Imagenes-Aplicación\" + Path.GetFileName(seleccionado.ImagenUrl);
                if(rutaAnterior != rutaNueva)
                {
                    File.Delete(rutaAnterior);
                }
                cargar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (validarSeleccion())
                {
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Seguro querés eliminarlo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    string ruta = @"C:\Imagenes-Aplicación\" + Path.GetFileName(seleccionado.ImagenUrl);
                    if (File.Exists(ruta))
                    {
                        File.Delete(ruta);
                    }    
                    negocio.eliminar(seleccionado.Id);
                    cargar();                   
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;

            try
            {
                if (validarSeleccion())
                {
                    return;
                }

                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                VentanaInformación informacion = new VentanaInformación(seleccionado);
                informacion.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool validarSeleccion()
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("¡Seleccione un artículo!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = tbxFiltroPorNombre.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().StartsWith(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void FiltroPorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbxFiltroPorNombre.Text.Length >= 25)
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
        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }

            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Empieza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (validarFriltroAvanzado())
                {
                    return;
                }
                    string campo = cbxCampo.SelectedItem.ToString();
                    string criterio = cbxCriterio.SelectedItem.ToString();
                    string filtroAvanzado = tbxFiltroAvanzado.Text;
                    dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtroAvanzado);
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool soloNumeros(string cadena)
        {
            foreach (char catacter in cadena)
            {
                if (!(char.IsNumber(catacter)))
                {
                    return false;
                }
            }
            return  true;
        }
        public bool validarFriltroAvanzado()
        {
            if (cbxCampo.SelectedIndex < 0 || cbxCriterio.SelectedIndex < 0 || tbxFiltroAvanzado.Text == "")
            {
                lbIngreseDatos.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lbIngreseDatos.ForeColor = System.Drawing.SystemColors.Control;
            }

            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(tbxFiltroAvanzado.Text)))
                { 
                    lbPrecioFiltroAvanzado.ForeColor = Color.Red;
                    return true;
                }
            }
            else
            {
                lbPrecioFiltroAvanzado.ForeColor = System.Drawing.SystemColors.Control;
            }
            return false;
        }
        private void tbxFiltroAvanzado_TextChanged_1(object sender, EventArgs e)
        {

            if (tbxFiltroAvanzado.Text == "")
            {
                cargar();
            }

            if (cbxCampo.SelectedItem.ToString() == "Precio" || tbxFiltroAvanzado.Text == "")
            {
                cargar();
                lbPrecioFiltroAvanzado.ForeColor = System.Drawing.SystemColors.Control;
            }
        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {

        }
    }
}
