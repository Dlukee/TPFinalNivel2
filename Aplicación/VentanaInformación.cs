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

namespace Aplicación
{
    public partial class VentanaInformación : Form
    {
        private Articulos articulos;
        public VentanaInformación(Articulos seleccionado)
        {
            InitializeComponent();
            this.articulos = seleccionado;
            Text = "Información del articulo";
        }

        private void VentanaInformación_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            negocio.informacion(articulos);
          
            tbxCodigoInfo.Text = articulos.Codigo;
            tbxNombreInfo.Text = articulos.Nombre;
            tbxDescripcionInfo.Text = articulos.Descripcion;
            cargarImagen(articulos.ImagenUrl);
            tbxUrlImagenInfo.Text = articulos.ImagenUrl;
            tbxCategoriaInfo.Text = articulos.Categorias.ToString();
            tbxMarcaInfo.Text = articulos.Marcas.ToString();
            tbxPrecioInfo.Text = articulos.Precio.ToString();
                 
        }

        public void cargarImagen(string imagen)
        {
            {
                try
                {
                    pbxImagen.Load(imagen);
                }
                catch (Exception)
                {
                    pbxImagen.Load("https://cdnx.jumpseller.com/patagon-shop/image/38339252/resize/640/640?1691509015");
                }
            }
        }

    }
}
