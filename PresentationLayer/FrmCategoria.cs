using BusinessLayer;
using DataAccessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmCategoria : Form
    {
        BindingList<Categoria> categorias;
        public FrmCategoria()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cEditar.Index || e.ColumnIndex == cEliminar.Index)
            {
                Categoria categoria = categorias.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();

                if (e.ColumnIndex == cEditar.Index)
                {
                    FrmNuevaCategoria frmNuevaCategoria = new FrmNuevaCategoria(categoria);
                    if (frmNuevaCategoria.ShowDialog() == DialogResult.OK)
                        Buscar();
                }
                else if (e.ColumnIndex == cEliminar.Index)
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro de categoría? \n" +
                            "Categoría: " + categoria.ToString() + ".", "Registro de categorías",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            AppEngine.categoriaDAL.Delete(categoria.Id);
                            MessageBox.Show("Registro eliminado exitosamente.", "Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                Fuente.DataSource = categorias = new BindingList<Categoria>(AppEngine.categoriaDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fuente.DataSource = categorias.Where(x => x.Nombre.Contains(txtBuscar.Text));
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaCategoria frmNuevaCategoria = new FrmNuevaCategoria();
            if (frmNuevaCategoria.ShowDialog() == DialogResult.OK)
                Buscar();
        }
    }
}
