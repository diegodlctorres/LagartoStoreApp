using BusinessLayer;
using DataAccessLayer;
using System;
using System.Windows.Forms;
using Utilitario;

namespace PresentationLayer
{
    public partial class FrmNuevoColaborador : Form
    {
        private readonly Usuario usuario;

        public FrmNuevoColaborador(Usuario usuario, bool isNuevo)
        {
            InitializeComponent();
            this.usuario = usuario;

            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                turnoComboBox.DataSource = AppEngine.turnoDAL.GetAll();
                turnoComboBox.DisplayMember = "NOMBRE";
                turnoComboBox.ValueMember = "ID";

                cargoComboBox.DataSource = AppEngine.cargoDAL.GetAll();
                cargoComboBox.DisplayMember = "NOMBRE";
                cargoComboBox.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            Util.Centrar(this, lblTitulo);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                //if (usuario is null)
                //{
                //    AppEngine.usuarioDAL.Create(new Usuario(1,
                //        contraseñaTextBox.Text,
                //        apellidoTextBox.Text,
                //        Convert.ToInt32(!string.IsNullOrEmpty(telefonoTextBox.Text) ? telefonoTextBox.Text : "0"),
                //        rdoMasculino.Checked ? 'M' : 'F',
                //        correoTextBox.Text,
                //        Convert.ToInt32(!string.IsNullOrEmpty(dniTextBox.Text) ? dniTextBox.Text : "0")));

                //    MessageBox.Show("Se agregó al usuario exitosamente.", "Registrar nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                //}
                //else
                //{
                //    usuario.Nombre = contraseñaTextBox.Text;
                //    usuario.Apellido = apellidoTextBox.Text;
                //    usuario.Telefono = Convert.ToInt32(!string.IsNullOrEmpty(telefonoTextBox.Text) ? telefonoTextBox.Text : "0");
                //    usuario.Sexo = rdoMasculino.Checked ? 'M' : 'F';
                //    usuario.Correo = correoTextBox.Text;
                //    usuario.Dni = Convert.ToInt32(!string.IsNullOrEmpty(dniTextBox.Text) ? dniTextBox.Text : "0");
                //    AppEngine.usuarioDAL.Update(usuario);

                //    MessageBox.Show("Se actualizó al usuario exitosamente.", "Actualizar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                //}
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

        #region Eventos del ícono de contraseña
        private void IconoContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            contraseñaTextBox.UseSystemPasswordChar = true;
        }

        private void IconoContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            contraseñaTextBox.UseSystemPasswordChar = true;
        } 
        #endregion

        private void CuentaAutomaticaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            contraseñaTextBox.Enabled = iconoContraseña.Enabled = !cuentaAutomaticaCheckBox.Checked;
        }
    }
}
