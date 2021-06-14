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
    public partial class FrmTabla : Form
    {
        public ProductoModel ProductoModel;
        DataTable products = new DataTable();
        
        public FrmTabla()
        {
            InitializeComponent();
        }


        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {
            string[] titulos = new string[]{"ID", "NOMBRE", "N. EXISTENCIAS", "MODELO", "MARCA",
            "PRECIO DE VENTA", "DESCRIPCION", "URL"};
            foreach (string s in titulos)
            {
                products.Columns.Add(s);
            }
            if (ProductoModel.GetAll() != null)
            {
                foreach (Producto p in ProductoModel.GetAll())
                {
                    products.Rows.Add(p.toArray());
                }
                
                
            }
            dgvTable.DataSource = products;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            products .DefaultView.RowFilter = $"Id LIKE '{txtFilter.Text}%'";

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Any(child => child is FrmRegistrar))
            {
                return;
            }
            FrmRegistrar frmR = new FrmRegistrar();
            frmR.ProductoModel = ProductoModel;
            frmR.MdiParent = this.MdiParent;
            frmR.recibirProducto += new FrmRegistrar.recibir(añadirProducto);
            frmR.Show();            
        }
        public void añadirProducto(Producto p)
        {
            products.Rows.Add(p.toArray());
            dgvTable.DataSource = products;
            MessageBox.Show("Producto Añadido");
            
        }
        public void updateProducto(Producto p)
        {
            p.Id = dgvTable.CurrentCell.RowIndex+1;
            products.Rows[dgvTable.CurrentCell.RowIndex].ItemArray = p.toArray();
            MessageBox.Show("Producto Actualizado");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Any(child => child is FrmRegistrar))
            {
                return;
            }
            FrmRegistrar frmR = new FrmRegistrar();
            frmR.ProductoModel = ProductoModel;
            frmR.MdiParent = this.MdiParent;
            frmR.updatear += new FrmRegistrar.recibir(updateProducto);
            frmR.txtNombres.Text  = dgvTable.CurrentRow.Cells[1].Value.ToString();
            int.TryParse(dgvTable.CurrentRow.Cells[2].Value.ToString(), out int nex);
            frmR.txtNumeroExistencia.Text = nex.ToString();
            frmR.cmbMarca.SelectedItem = dgvTable.CurrentRow.Cells[4].Value.ToString();
            frmR.txtModelo.Text = dgvTable.CurrentRow.Cells[3].Value.ToString();
            decimal.TryParse(dgvTable.CurrentRow.Cells[5].Value.ToString(), out decimal pvu);
            frmR.txtPrecioVenta.Text  = pvu.ToString();           
            frmR.txtDescripcion.Text  = dgvTable.CurrentRow.Cells[6].Value.ToString();
            frmR.txtImagenUrl.Text = dgvTable.CurrentRow.Cells[7].Value.ToString();
            frmR.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ProductoModel.Remove(dgvTable.CurrentCell.RowIndex);
            products.Rows.RemoveAt(dgvTable.CurrentCell.RowIndex);
            dgvTable.DataSource = products;
            
        }
    }
}
