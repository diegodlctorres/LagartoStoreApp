using DataAccessLayer;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            txtVersion.Text = "Versión: " + version;

            if (Properties.Settings.Default.Recuerdame)
            {
                txtUsuario.Text = Properties.Settings.Default.Usuario;
                txtContraseña.Text = Properties.Settings.Default.Contraseña;
                recuerdameCheckBox.Checked = Properties.Settings.Default.Recuerdame;
            }

            txtUsuario.Select();
            ActiveControl = txtUsuario;
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Usuario = recuerdameCheckBox.Checked ? txtUsuario.Text : "";
                Properties.Settings.Default.Contraseña = recuerdameCheckBox.Checked ? txtContraseña.Text : "";
                Properties.Settings.Default.Recuerdame = recuerdameCheckBox.Checked;

                Properties.Settings.Default.Save();

                AppEngine.Cuenta = AppEngine.cuentaDAL.GetByCredenciales(txtUsuario.Text, txtContraseña.Text);
                AppEngine.Colaborador = AppEngine.colaboradorDAL.GetByID(AppEngine.Cuenta.Usuario.Id);

                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(this);
                frmMenuPrincipal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        #region Eventos de los textboxes
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnAcceder_Click(sender, e);
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnAcceder_Click(sender, e);
        }
        #endregion

        #region Eventos de los páneles de usuario  y contraseña
        private void PanelUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Select();
            ActiveControl = txtUsuario;
        }

        private void PanelUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = panelUsuario.BackColor = Color.White;
            txtContraseña.BackColor = panelContraseña.BackColor = SystemColors.Control;
        }

        private void PanelContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Select();
            ActiveControl = txtContraseña;
        }

        private void PanelContraseña_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = panelUsuario.BackColor = SystemColors.Control;
            txtContraseña.BackColor = panelContraseña.BackColor = Color.White;
        }
        #endregion

        #region Eventos del ícono de contraseña
        private void IconoContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void IconoContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }

        #endregion

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
