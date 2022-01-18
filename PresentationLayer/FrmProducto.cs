using BusinessLayer;
using DataAccessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilitario;

namespace PresentationLayer
{
    public partial class FrmProducto : Form
    {
        BindingList<Producto> productos;
        public FrmProducto()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Buscar();
            Util.Centrar(this, lblTitulo);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            if (frmNuevoProducto.ShowDialog() == DialogResult.OK)
                Buscar();
        }

        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cEditar.Index || e.ColumnIndex == cEliminar.Index)
            {
                Producto producto = productos.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();

                if (e.ColumnIndex == cEditar.Index)
                {
                    FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto(producto);
                    if (frmNuevoProducto.ShowDialog() == DialogResult.OK)
                        Buscar();
                }
                else if (e.ColumnIndex == cEliminar.Index)
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro de producto? \n" +
                            "Producto: " + producto.ToString() + ".", "Registro de productos",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            AppEngine.productoDAL.Delete(producto.Id);
                            MessageBox.Show("Registro eliminado exitosamente.", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Buscar();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void Buscar()
        {
            try
            {
                txtBuscar.Text = "";
                Fuente.DataSource = productos = new BindingList<Producto>(AppEngine.productoDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fuente.DataSource = productos.Where(x => x.Nombre.Contains(txtBuscar.Text));
        }
    }
}
