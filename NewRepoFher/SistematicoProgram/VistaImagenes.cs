using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistematicoProgram.Model;
using SistematicoProgram.poco;

namespace SistematicoProgram
{
    public partial class VistaImagenes : Form
    {
        public ProductoModel ProductoModel { get; set; }
        private ProductosConImagen ProductosConImagen;
        public VistaImagenes()
        {
            InitializeComponent();
        }

        private void VistaImagenes_Load(object sender, EventArgs e)
        {
            if(ProductoModel.GetAll() == null)
            {
                return;
            }
            Producto[] Array_Var = ProductoModel.GetAll();
            for(int i = 0; i < Array_Var.Length; i++)
            {
                ProductosConImagen = new ProductosConImagen();
                ProductosConImagen.productos = Array_Var[i];
                this.LayoutPanel.Controls.Add(ProductosConImagen);

            }
        }
    }
}
