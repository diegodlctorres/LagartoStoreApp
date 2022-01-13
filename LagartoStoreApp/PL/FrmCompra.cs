using LagartoStoreApp.BLL;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LagartoStoreApp.PL
{
    public partial class FrmCompra : Form
    {
        BindingList<Producto> productos;
        public FrmCompra()
        {
            InitializeComponent();
            grdProductos.AutoGenerateColumns = false;
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            Buscar();

            try
            {
                LoadCategoriaComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void LoadCategoriaComboBox()
        {
            categoriaComboBox.DataSource = AppEngine.categoriaDAL.GetAll();
            categoriaComboBox.DisplayMember = "NOMBRE";
            categoriaComboBox.ValueMember = "ID";
            categoriaComboBox.SelectedIndex = -1;
        }

        private void Buscar()
        {
            try
            {
                nombreTextBox.Text = "";
                ProductosDataSource.DataSource = productos = new BindingList<Producto>(AppEngine.productoDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void CategoriaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            categoriaComboBox.Enabled = categoriaCheckBox.Checked;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            categoriaCheckBox.Checked = false;
            categoriaComboBox.SelectedIndex = -1;
            nombreTextBox.Text = idTextBox.Text = "";

            grdProductos.DataSource = productos;
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductosDataSource.DataSource = productos.Where(x => x.Nombre.Contains(nombreTextBox.Text));
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductosDataSource.DataSource = productos.Where(x => x.Id.ToString().Contains(idTextBox.Text));
        }

        private void CategoriaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!categoriaCheckBox.Checked) return;

            ProductosDataSource.DataSource = productos.Where(x => x.Categoria.Id == (categoriaComboBox.SelectedItem as Categoria).Id);
        }
    }
}
