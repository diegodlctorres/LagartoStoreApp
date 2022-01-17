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
    public partial class FrmUsuario : Form
    {
        public Usuario Usuario { get; private set; }
        BindingList<Usuario> usuarios;

        public FrmUsuario(bool isClienteOrColaborador)
        {
            InitializeComponent();
            if (isClienteOrColaborador)
                grdConsulta.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(GrdConsulta_CellMouseDoubleClick);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Util.Centrar(this, lblTitulo);
            filtroComboBox.SelectedIndex = 1;
            txtBuscar.Select();
            Buscar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario();
            if (frmNuevoUsuario.ShowDialog() == DialogResult.OK)
                Buscar();
        }

        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cEditar.Index || e.ColumnIndex == cEliminar.Index)
            {
                Usuario usuario = usuarios.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();

                if (e.ColumnIndex == cEditar.Index)
                {
                    FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario(usuario);
                    if (frmNuevoUsuario.ShowDialog() == DialogResult.OK)
                        Buscar();
                }
                else if (e.ColumnIndex == cEliminar.Index)
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro de usuario? \n" +
                            "Usuario: " + usuario.ToString() + ".", "Registro de usuarios",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            AppEngine.usuarioDAL.Delete(usuario.Id);
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
                Fuente.DataSource = usuarios = new BindingList<Usuario>(AppEngine.usuarioDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            switch (filtroComboBox.SelectedIndex)
            {
                case 0:
                    Fuente.DataSource = usuarios.Where(x => x.Id == Convert.ToInt32(txtBuscar.Text));
                    break;
                case 1:
                    Fuente.DataSource = usuarios.Where(x => x.Nombre.Contains(txtBuscar.Text.ToUpper()));
                    break;
                case 2:
                    Fuente.DataSource = usuarios.Where(x => x.Apellido.Contains(txtBuscar.Text.ToUpper()));
                    break;
                case 3:
                    Fuente.DataSource = usuarios.Where(x => x.Dni.ToString().Contains(txtBuscar.Text));
                    break;
                case 4:
                    Fuente.DataSource = usuarios.Where(x => x.Correo.Contains(txtBuscar.Text.ToLower()));
                    break;
                case 5:
                    Fuente.DataSource = usuarios.Where(x => x.Telefono.ToString().Contains(txtBuscar.Text));
                    break;
            }            
        }
        private void FiltroComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void GrdConsulta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || e.RowIndex < 0 || e.ColumnIndex == cEliminar.Index || e.ColumnIndex == cEditar.Index) 
                return;

            Usuario = usuarios.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();
            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
