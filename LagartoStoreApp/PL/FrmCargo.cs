using LagartoStoreApp.BLL;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LagartoStoreApp.PL
{
    public partial class FrmCargo : Form
    {
        BindingList<Cargo> cargos;
        public FrmCargo()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cEditar.Index || e.ColumnIndex == cEliminar.Index)
            {
                Cargo cargo = cargos.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();

                if (e.ColumnIndex == cEditar.Index)
                {
                    FrmNuevoCargo frmNuevoCargo = new FrmNuevoCargo(cargo);
                    if (frmNuevoCargo.ShowDialog() == DialogResult.OK)
                        Buscar();
                }
                else if (e.ColumnIndex == cEliminar.Index)
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro de cargo? \n" +
                            "Cargo: " + cargo.ToString() + ".", "Registro de cargos",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            AppEngine.cargoDAL.Delete(cargo.Id);
                            MessageBox.Show("Registro eliminado exitosamente.", "Registro de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                Fuente.DataSource = cargos = new BindingList<Cargo>(AppEngine.cargoDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fuente.DataSource = cargos.Where(x => x.Nombre.Contains(txtBuscar.Text));
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoCargo frmNuevoCargo = new FrmNuevoCargo();
            if (frmNuevoCargo.ShowDialog() == DialogResult.OK)
                Buscar();
        }
    }
}
