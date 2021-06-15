using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SistematicoProgram.poco;

namespace SistematicoProgram
{
    public partial class CardImagen : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager msm;
        public Producto producto { get; set; }
        public CardImagen()
        {
            InitializeComponent();
            producto = new Producto();
            msm = MaterialSkin.MaterialSkinManager.Instance;
            msm.EnforceBackcolorOnAllComponents = true;
            msm.AddFormToManage(this);
            msm.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.
                Indigo500, MaterialSkin.Primary.
                Indigo700, MaterialSkin.Primary.
                Indigo100, MaterialSkin.Accent.
                Pink200,   MaterialSkin.TextShade.WHITE);
        }

        private void CardImagen_Load(object sender, EventArgs e)
        {
            //PcbImagen.Image = Image.FromFile(producto.ImageURl);

            //lblId.Text += Convert.ToString(producto.Id);
            //lblNombre.Text += producto.Nombres;
            //lblNex.Text = producto.Modelo;
            //txtMarcaI.Text = Convert.ToString(producto.Marca);
            //txtNExistenciaI.Text = Convert.ToString(producto.NExistencia);
            //txtPrecioVentaI.Text = Convert.ToString(producto.PrecioVenta);
            //txtDescripcionI.Text = productos.Descripcion;
        }

        private void PcbImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
