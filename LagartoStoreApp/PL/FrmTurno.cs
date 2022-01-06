using LagartoStoreApp.BLL;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LagartoStoreApp.PL
{
    public partial class FrmTurno : Form
    {
        BindingList<Turno> turnos;
        public FrmTurno()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoTurno frmNuevoTurno = new FrmNuevoTurno();
            if (frmNuevoTurno.ShowDialog() == DialogResult.OK)
                Buscar();
        }

        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cEditar.Index || e.ColumnIndex == cEliminar.Index)
            {
                Turno turno = turnos.Where(x => x.Id == Convert.ToInt32(grdConsulta.Rows[e.RowIndex].Cells[cId.Index].Value)).FirstOrDefault();

                if (e.ColumnIndex == cEditar.Index)
                {
                    FrmNuevoTurno frmNuevoTurno = new FrmNuevoTurno(turno);
                    if (frmNuevoTurno.ShowDialog() == DialogResult.OK)
                        Buscar();
                }
                else if (e.ColumnIndex == cEliminar.Index)
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro de turno? \n" +
                            turno.ToString() + ".", "Registro de turnos",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            AppEngine.turnoDAL.Delete(turno.Id);
                            MessageBox.Show("Registro eliminado exitosamente.", "Registro de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                Fuente.DataSource = turnos = new BindingList<Turno>(AppEngine.turnoDAL.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fuente.DataSource = turnos.Where(x => x.Nombre.Contains(txtBuscar.Text));
        }
    }
}
