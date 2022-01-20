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
        private readonly Colaborador colaborador;
        private Cuenta cuenta;

        public FrmNuevoColaborador(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            LoadComboBoxes(false);
        }

        public FrmNuevoColaborador(Colaborador colaborador)
        {
            InitializeComponent();
            lblTitulo.Text = "ACTUALIZAR COLABORADOR";
            this.colaborador = colaborador;

            LoadComboBoxes(true);
            cargoComboBox.SelectedValue = colaborador.Cargo.Id;
            turnoComboBox.SelectedValue = colaborador.Turno.Id;

            contraseñaTextBox.Text = cuenta.Contraseña;
        }

        private void LoadComboBoxes(bool isUpdate)
        {
            try
            {
                turnoComboBox.DataSource = AppEngine.turnoDAL.GetAll();
                turnoComboBox.DisplayMember = "NOMBRE";
                turnoComboBox.ValueMember = "ID";

                cargoComboBox.DataSource = AppEngine.cargoDAL.GetAll();
                cargoComboBox.DisplayMember = "NOMBRE";
                cargoComboBox.ValueMember = "ID";

                if (isUpdate)
                    cuenta = AppEngine.cuentaDAL.GetByID(0, colaborador.Id);
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
                if (colaborador is null)
                {
                    AppEngine.colaboradorDAL.Create(
                        new Colaborador(usuario,
                        cargoComboBox.SelectedItem as Cargo,
                        turnoComboBox.SelectedItem as Turno,
                        DateTime.Now, new DateTime(), 0));

                    AppEngine.cuentaDAL.Create(new Cuenta(1, usuario, "", contraseñaTextBox.Text, true));

                    cuenta = AppEngine.cuentaDAL.GetByID(0, usuario.Id);

                    MessageBox.Show("Se agregó al colaborador exitosamente.\n\n" +
                        "USUARIO:\n" + cuenta.NombreDeUsuario + "\n\n" +
                        "¡Bienvenido a la familia Lagarto!", "Registrar nuevo colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else if (usuario is null)
                {
                    colaborador.Cargo = cargoComboBox.SelectedItem as Cargo;
                    colaborador.Turno = turnoComboBox.SelectedItem as Turno;
                    AppEngine.colaboradorDAL.Update(colaborador);

                    cuenta.Contraseña = contraseñaTextBox.Text;
                    AppEngine.cuentaDAL.Update(cuenta);
                    MessageBox.Show("Se actualizó el colaborador exitosamente.", "Actualizar colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

        #region Eventos del ícono de contraseña
        private void IconoContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            contraseñaTextBox.UseSystemPasswordChar = false;
        }

        private void IconoContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            contraseñaTextBox.UseSystemPasswordChar = true;
        }
        #endregion
    }
}
