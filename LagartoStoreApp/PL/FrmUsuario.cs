using LagartoStoreApp.BLL;
using LagartoStoreApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagartoStoreApp.PL
{
    public partial class FrmUsuario : Form
    {
        BindingList<Usuario> usuarios;
        public FrmUsuario()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario();
            if (frmNuevoUsuario.ShowDialog() == DialogResult.OK)
                BuscarUsuarios();
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
                        BuscarUsuarios();
                }
                else if (e.ColumnIndex == cEliminar.Index)
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro de usuario? \n" +
                            "Usuario: " + usuario.ToString() + ".", "Registro de usuaios",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            AppEngine.usuarioDAL.Delete(usuario.Id);
                            MessageBox.Show("Registro eliminado exitosamente.", "Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            BuscarUsuarios();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
        
        private void BuscarUsuarios()
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
            Fuente.DataSource = usuarios.Where(x => x.Nombre.Contains(txtBuscar.Text));
        }
    }
}
