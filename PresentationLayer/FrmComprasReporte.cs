using DataAccessLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilitario;

namespace PresentationLayer
{
    public partial class FrmComprasReporte : Form
    {
        DataTable dataTable;
        public FrmComprasReporte()
        {
            InitializeComponent();
        }

        private void FrmComprasReporte_Load(object sender, EventArgs e)
        {
            Buscar();

            Util.Centrar(panelSuperior, lblTitulo);
            //Util.AjustarDataGridView(this, grdConsulta);

            //Util.CrearDatosAleatorios();

            DateTime fechaActual = DateTime.Now;
            fechaInicioDtp.Value = new DateTime(fechaActual.Year, fechaActual.Month, 1);
            fechaFinDtp.Value = new DateTime(fechaActual.Year, fechaActual.Month + 1, 1).AddDays(-1);
        }

        private void Buscar()
        {
            try
            {
                Fuente.DataSource = dataTable = ConexionBD.GetData("GET_REPORTE_COMPRAS", null).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                EnumerableRowCollection<DataRow> dataRows = dataTable.AsEnumerable();

                if (rangoFechasCheckBox.Checked)
                {
                    dataRows = dataRows
                        .Where(x => Convert.ToDateTime(x["FECHA_COMPRA"].ToString()) >= fechaInicioDtp.Value &&
                                    Convert.ToDateTime(x["FECHA_COMPRA"].ToString()) <= fechaFinDtp.Value);
                }

                if (datosCheckBox.Checked)
                {
                    if (clienteRadioButton.Checked)
                    {
                        switch (filtroComboBox.SelectedIndex)
                        {
                            case 0:
                                dataRows = dataRows.Where(x => x["CODIGO_CLIENTE"].ToString().Contains(txtBuscar.Text));
                                break;
                            case 1:
                                dataRows = dataRows.Where(x => x["CLIENTE"].ToString().Contains(txtBuscar.Text));
                                break;
                            case 2:
                                dataRows = dataRows.Where(x => x["DNI_CLIENTE"].ToString().Contains(txtBuscar.Text));
                                break;
                        }
                    }
                    else if (colaboradorRadioButton.Checked)
                    {
                        switch (filtroComboBox.SelectedIndex)
                        {
                            case 0:
                                dataRows = dataRows.Where(x => x["CODIGO_COLABORADOR"].ToString().Contains(txtBuscar.Text));
                                break;
                            case 1:
                                dataRows = dataRows.Where(x => x["CARGO_COLABORADOR"].ToString().Contains(txtBuscar.Text));
                                break;
                            case 2:
                                dataRows = dataRows.Where(x => x["TURNO"].ToString().Contains(txtBuscar.Text));
                                break;
                        }
                    }
                }

                Fuente.DataSource = dataRows.Count() > 0 ? dataRows.CopyToDataTable() : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void FiltroComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Select();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Buscar();
            BtnLimpiar_Click(sender, e);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            rangoFechasCheckBox.Checked = datosCheckBox.Checked = false;
            txtBuscar.Text = "";
            clienteRadioButton.Checked = true;
            filtroComboBox.Items.Clear();

            Fuente.DataSource = dataTable;
        }

        #region Eventos de los CheckBoxes
        private void DatosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gboDatosUsuario.Enabled = datosCheckBox.Checked;
        }

        private void RangoFechasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gboRangoFechas.Enabled = rangoFechasCheckBox.Checked;
        }
        #endregion

        private void GboDatosUsuario_EnabledChanged(object sender, EventArgs e)
        {
            clienteRadioButton.Checked = true;
            filtroComboBox.Items.Clear();
            if (gboDatosUsuario.Enabled)
            {
                filtroComboBox.Items.Add("Código de cliente");
                filtroComboBox.Items.Add("Cliente");
                filtroComboBox.Items.Add("DNI");
                filtroComboBox.SelectedIndex = 0;
                txtBuscar.Select();
            }
        }

        #region Eventos de los RaddioButtons
        private void ColaboradorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (colaboradorRadioButton.Checked)
            {
                filtroComboBox.Items.Clear();
                filtroComboBox.Items.Add("Código de colaborador");
                filtroComboBox.Items.Add("Cargo");
                filtroComboBox.Items.Add("Turno");
                filtroComboBox.SelectedIndex = 0;
            }
        }
        #endregion

        private void GrdConsulta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblTotalRegistros.Text = string.Format("Se encontró {0} registro(s).", grdConsulta.Rows.Count);
        }
    }
}
