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
using MaterialSkin;
using MaterialSkin.Controls;
namespace SistematicoProgram
{
    public partial class ProductosConImagen : UserControl
    {
        //readonly MaterialSkin.MaterialSkinManager msm;

        public Producto productos { get; set; }
        public ProductosConImagen()
        {
            InitializeComponent();
            productos = new Producto();
            //msm = MaterialSkin.MaterialSkinManager.Instance;
            //msm.EnforceBackcolorOnAllComponents = true;
            //msm.AddFormToManage(this);
            //msm.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500)
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
