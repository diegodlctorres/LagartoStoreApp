using LagartoStoreApp.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LagartoStoreApp.PL
{
    public partial class FrmNuevoTurno : Form
    {
        private readonly Turno turno;

        public FrmNuevoTurno()
        {
            InitializeComponent();
        }

        public FrmNuevoTurno(Turno turno)
        {
            InitializeComponent();
            this.turno = turno;

            lblTitulo.Text = "ACTUALIZAR TURNO";
            lblTitulo.Location = new Point(58, lblTitulo.Location.Y);

            nombreTextBox.Text = turno.Nombre;
            horaInicioDateTimePicker.Value = turno.HoraInicio;
            horaFinDateTimePicker.Value = turno.HoraFin;
        }

        #region Eventos KeyPress
        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }
        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (turno is null)
                {
                    AppEngine.turnoDAL.Create(new Turno(1,
                        nombreTextBox.Text,
                        horaInicioDateTimePicker.Value,
                        horaFinDateTimePicker.Value));

                    MessageBox.Show("Se agregó el turno exitosamente.", "Registrar nuevo turno", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    turno.Nombre = nombreTextBox.Text;
                    turno.HoraInicio = horaInicioDateTimePicker.Value;
                    turno.HoraFin = horaFinDateTimePicker.Value;
                    AppEngine.turnoDAL.Update(turno);

                    MessageBox.Show("Se actualizó el turno exitosamente.", "Actualizar turno", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                BtnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
