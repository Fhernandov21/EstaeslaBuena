using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistematicoProgram.poco;

namespace SistematicoProgram
{
    public partial class ProductosConImagen : UserControl
    {
        public Producto productos { get; set; }
        public ProductosConImagen()
        {
            InitializeComponent();
            productos = new Producto();
        }

        private void ProductosConImagen_Load(object sender, EventArgs e)
        {
            PcbImagen.Image = Image.FromFile(productos.ImageURl);
       
            txtID.Text = Convert.ToString(productos.Id) ;
            txtNameI.Text = productos.Nombres;
            txtModeloI.Text = productos.Modelo;
            txtMarcaI.Text = Convert.ToString (productos.Marca);
            txtNExistenciaI.Text = Convert.ToString(productos.NExistencia);
            txtPrecioVentaI.Text = Convert.ToString(productos.PrecioVenta);
            txtDescripcionI.Text = productos.Descripcion;
        }
    }
}
