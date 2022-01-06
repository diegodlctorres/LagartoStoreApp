using LagartoStoreApp.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LagartoStoreApp.PL
{
    public partial class FrmNuevoUsuario : Form
    {
        private readonly Usuario usuario;

        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        public FrmNuevoUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            lblTitulo.Text = "ACTUALIZAR USUARIO";
            lblTitulo.Location = new Point(45, lblTitulo.Location.Y);

            nombreTextBox.Text = usuario.Nombre;
            apellidoTextBox.Text = usuario.Apellido;
            telefonoTextBox.Text = usuario.Telefono.ToString();
            correoTextBox.Text = usuario.Correo;
            dniTextBox.Text = usuario.Dni.ToString();
            rdoMasculino.Checked = usuario.Sexo == 'M';
            rdoFemenino.Checked = usuario.Sexo == 'F';
        }

        #region Eventos KeyPress
        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }

        private void ApellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }

        private void DniTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }

        private void CorreoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        } 
        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario is null)
                {
                    AppEngine.usuarioDAL.Create(new Usuario(1,
                        nombreTextBox.Text,
                        apellidoTextBox.Text,
                        Convert.ToInt32(!string.IsNullOrEmpty(telefonoTextBox.Text) ? telefonoTextBox.Text : "0"),
                        rdoMasculino.Checked ? 'M' : 'F',
                        correoTextBox.Text,
                        Convert.ToInt32(!string.IsNullOrEmpty(dniTextBox.Text) ? dniTextBox.Text : "0")));

                    MessageBox.Show("Se agregó al usuario exitosamente.", "Registrar nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    usuario.Nombre = nombreTextBox.Text;
                    usuario.Apellido = apellidoTextBox.Text;
                    usuario.Telefono = Convert.ToInt32(!string.IsNullOrEmpty(telefonoTextBox.Text) ? telefonoTextBox.Text : "0");
                    usuario.Sexo = rdoMasculino.Checked ? 'M' : 'F';
                    usuario.Correo = correoTextBox.Text;
                    usuario.Dni = Convert.ToInt32(!string.IsNullOrEmpty(dniTextBox.Text) ? dniTextBox.Text : "0");
                    AppEngine.usuarioDAL.Update(usuario);

                    MessageBox.Show("Se actualizó al usuario exitosamente.", "Actualizar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
