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
    public partial class FrmCliente : Form
    {
        public Usuario Usuario { get; set; }
        BindingList<Cliente> clientes;
        public FrmCliente()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FrmCliente_SizeChanged(object sender, EventArgs e)
        {
            Util.Centrar(this, lblTitulo);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(this);
            if (frmUsuario.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AppEngine.clienteDAL.Create(new Cliente(Usuario));
                    Buscar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cEditar.Index || e.ColumnIndex == cEliminar.Index)
            {
                Cliente cliente = clientes.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();

                if (e.ColumnIndex == cEditar.Index)
                {
                    FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario(cliente);
                    if (frmNuevoUsuario.ShowDialog() == DialogResult.OK)
                        Buscar();
                }
                else if (e.ColumnIndex == cEliminar.Index)
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro de cliente? \n" +
                            "Cliente: " + cliente.ToString() + ".", "Registro de clientes",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            AppEngine.clienteDAL.Delete(cliente.Id);
                            MessageBox.Show("Registro eliminado exitosamente.", "Registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                Fuente.DataSource = clientes = new BindingList<Cliente>(AppEngine.clienteDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fuente.DataSource = clientes.Where(x => x.Nombre.Contains(txtBuscar.Text));
        }
    }
}
