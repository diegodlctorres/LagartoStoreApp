using BusinessLayer;
using DataAccessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmCompra : Form
    {
        BindingList<Producto> productos;
        BindingList<Producto> productosDelCarrito;
        private Cliente Cliente;

        public FrmCompra()
        {
            InitializeComponent();
            productosDelCarrito = new BindingList<Producto>();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            Buscar();
            LoadCategoriaComboBox();
        }

        private void Buscar()
        {
            try
            {
                ProductosDataSource.DataSource = productos = new BindingList<Producto>(AppEngine.productoDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void LoadCategoriaComboBox()
        {
            try
            {
                categoriaComboBox.DataSource = AppEngine.categoriaDAL.GetAll();
                categoriaComboBox.DisplayMember = "NOMBRE";
                categoriaComboBox.ValueMember = "ID";
                categoriaComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        #region Filtros
        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductosDataSource.DataSource = productos.Where(x => x.Nombre.Contains(nombreTextBox.Text));
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductosDataSource.DataSource = productos.Where(x => x.Id.ToString().Contains(idTextBox.Text));
        }

        private void CategoriaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            categoriaComboBox.Enabled = categoriaCheckBox.Checked;
        }

        private void CategoriaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!categoriaCheckBox.Checked) return;

            ProductosDataSource.DataSource = productos.Where(x => x.Categoria.Id == (categoriaComboBox.SelectedItem as Categoria).Id);
        }
        #endregion

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            categoriaCheckBox.Checked = false;
            categoriaComboBox.SelectedIndex = -1;
            nombreTextBox.Text = idTextBox.Text = "";

            Buscar();
        }

        private void GrdProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            productosDelCarrito.Add(grdProductos.CurrentRow.DataBoundItem as Producto);
            CarritoDataSource.DataSource = GetCarrito();
        }

        private void GrdCarrito_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == cDisminuir.Index && e.RowIndex > -1)
            {
                productosDelCarrito.Remove(productos
                    .First(x => x.Id == Convert.ToInt32(grdCarrito.CurrentRow.Cells[cIdCarrito.Index].Value)));
                CarritoDataSource.DataSource = GetCarrito();
            }
        }

        private BindingList<Acumulado> GetCarrito()
        {
            totalAPagarTextBox.Text = productosDelCarrito
                .Select(x => x.Precio)
                .DefaultIfEmpty()
                .Sum().ToString();

            return new BindingList<Acumulado>(productosDelCarrito
                .GroupBy(x => x.Id)
                .OrderBy(x => x.First().Id)
                .Select(x => new Acumulado(
                    x.First().Id,
                    x.First().Nombre,
                    x.First().Precio,
                    x.First().Categoria,
                    x.Count(y => y.Id == x.First().Id),
                    x.Sum(y => y.Precio))).ToList());
        }

        private void BtnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            productosDelCarrito.Clear();
            CarritoDataSource.DataSource = GetCarrito();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnCancelar_Click(sender, e);

            FrmCliente frmCliente = new FrmCliente(true);
            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                Cliente = frmCliente.Cliente;

                idClienteTextBox.Text = frmCliente.Cliente.Id.ToString();
                nombreClienteTextBox.Text = frmCliente.Cliente.Nombre;
                apellidoClienteTextBox.Text = frmCliente.Cliente.Apellido;
                dniClienteTextBox.Text = frmCliente.Cliente.Dni.ToString();

                grdProductos.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(GrdProductos_CellMouseDoubleClick);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            idClienteTextBox.Text = nombreClienteTextBox.Text = apellidoClienteTextBox.Text = dniClienteTextBox.Text = "";
            BtnLimpiarCarrito_Click(sender, e);

            grdProductos.CellMouseDoubleClick -= GrdProductos_CellMouseDoubleClick;
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            AppEngine.compraDAL.Create(new Compra(0, DateTime.Now, AppEngine.Colaborador, Cliente));
        }
    }

    public class Acumulado : Producto
    {
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }

        public Acumulado(int id, string nombre, decimal precio, Categoria categoria, int cantidad, decimal subTotal) :
            base(id, nombre, precio, categoria)
        {
            Cantidad = cantidad;
            SubTotal = subTotal;
        }
    }
}
