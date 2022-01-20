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
    public partial class FrmColaborador : Form
    {
        BindingList<Colaborador> colaboradores;
        public FrmColaborador()
        {
            InitializeComponent();
        }

        private void FrmColaborador_Load(object sender, EventArgs e)
        {
            Buscar();

            Util.AjustarDataGridView(this, grdConsulta);
            Util.Centrar(this, lblTitulo);
            
            txtBuscar.Select();
            filtroComboBox.SelectedIndex = 1;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(true);
            if (frmUsuario.ShowDialog() == DialogResult.OK)
            {
                FrmNuevoColaborador frmNuevoColaborador = new FrmNuevoColaborador(frmUsuario.Usuario);
                if (frmNuevoColaborador.ShowDialog() == DialogResult.OK)
                    Buscar();
            }
        }

        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cEditar.Index || e.ColumnIndex == cEliminar.Index)
            {
                Colaborador colaborador = colaboradores.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();

                if (e.ColumnIndex == cEditar.Index)
                {
                    FrmNuevoColaborador frmNuevoColaborador = new FrmNuevoColaborador(colaborador);
                    if (frmNuevoColaborador.ShowDialog() == DialogResult.OK)
                        Buscar();
                }
                else if (e.ColumnIndex == cEliminar.Index)
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro de colaborador? \n" +
                            "Colaborador: " + colaborador.ToString() + ".", "Registro de colaboradores",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            AppEngine.colaboradorDAL.Delete(colaborador.Id);
                            MessageBox.Show("Registro eliminado exitosamente.", "Registro de colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                Fuente.DataSource = colaboradores = new BindingList<Colaborador>(AppEngine.colaboradorDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length == 0)
            {
                Fuente.DataSource = colaboradores;
                return;
            }

            switch (filtroComboBox.SelectedIndex)
            {
                case 0:
                    Fuente.DataSource = colaboradores.Where(x => x.Id.ToString().Contains(txtBuscar.Text));
                    break;
                case 1:
                    Fuente.DataSource = colaboradores.Where(x => x.Codigo.ToString().Contains(txtBuscar.Text));
                    break;
                case 2:
                    Fuente.DataSource = colaboradores.Where(x => x.Nombre.Contains(txtBuscar.Text.ToUpper()));
                    break;
                case 3:
                    Fuente.DataSource = colaboradores.Where(x => x.Apellido.Contains(txtBuscar.Text.ToUpper()));
                    break;
                case 4:
                    Fuente.DataSource = colaboradores.Where(x => x.Dni.ToString().Contains(txtBuscar.Text));
                    break;
                case 5:
                    Fuente.DataSource = colaboradores.Where(x => x.Correo.Contains(txtBuscar.Text.ToLower()));
                    break;
                case 6:
                    Fuente.DataSource = colaboradores.Where(x => x.Telefono.ToString().Contains(txtBuscar.Text));
                    break;
            }
        }

        private void FiltroComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }
    }
}
