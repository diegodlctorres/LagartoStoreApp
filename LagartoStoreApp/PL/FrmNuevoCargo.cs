using LagartoStoreApp.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LagartoStoreApp.PL
{
    public partial class FrmNuevoCargo : Form
    {
        private readonly Cargo cargo;

        public FrmNuevoCargo()
        {
            InitializeComponent();
        }

        public FrmNuevoCargo(Cargo cargo)
        {
            InitializeComponent();
            this.cargo = cargo;

            lblTitulo.Text = "ACTUALIZAR CARGO";
            lblTitulo.Location = new Point(63, lblTitulo.Location.Y);

            nombreTextBox.Text = cargo.Nombre;
            salarioTextBox.Text = cargo.Salario.ToString();
        }

        #region Eventos KeyPress
        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }

        private void SalarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }
        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cargo is null)
                {
                    AppEngine.cargoDAL.Create(new Cargo(1, nombreTextBox.Text, Convert.ToDecimal(salarioTextBox.Text)));

                    MessageBox.Show("Se agregó el cargo exitosamente.", "Registrar nuevo cargo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    cargo.Nombre = nombreTextBox.Text;
                    cargo.Salario = Convert.ToDecimal(salarioTextBox.Text);
                    AppEngine.cargoDAL.Update(cargo);

                    MessageBox.Show("Se actualizó el cargo exitosamente.", "Actualizar cargo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
