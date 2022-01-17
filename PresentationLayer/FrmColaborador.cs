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
        public Usuario Usuario { get; set; }
        BindingList<Colaborador> colaboradores;
        public FrmColaborador()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmColaborador_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FrmColaborador_SizeChanged(object sender, EventArgs e)
        {
            Util.Centrar(this, lblTitulo);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(true);
            if (frmUsuario.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //AppEngine.colaboradorDAL.Create(new Colaborador(frmUsuario.Usuario, );
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
                Colaborador colaborador = colaboradores.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();

                if (e.ColumnIndex == cEditar.Index)
                {
                    FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario(colaborador);
                    if (frmNuevoUsuario.ShowDialog() == DialogResult.OK)
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
            Fuente.DataSource = colaboradores.Where(x => x.Nombre.Contains(txtBuscar.Text));
        }
    }
}
