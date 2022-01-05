using LagartoStoreApp.BLL;
using LagartoStoreApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagartoStoreApp.PL
{
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        #region Eventos KeyPress
        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnNuevoUsuario_Click(sender, e);
        }

        private void ApellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnNuevoUsuario_Click(sender, e);
        }

        private void DniTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnNuevoUsuario_Click(sender, e);
        }

        private void CorreoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnNuevoUsuario_Click(sender, e);
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnNuevoUsuario_Click(sender, e);
        } 
        #endregion

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAL.CreateUsuario(new Usuario(1,
                    nombreTextBox.Text,
                    apellidoTextBox.Text,
                    Convert.ToInt32(!string.IsNullOrEmpty(telefonoTextBox.Text) ? telefonoTextBox.Text : "0"),
                    rdoMasculino.Checked ? 'M' : 'F',
                    correoTextBox.Text,
                    Convert.ToInt32(!string.IsNullOrEmpty(dniTextBox.Text) ? dniTextBox.Text : "0")));

                MessageBox.Show("Se agregó al usuario exitosamente.", "Crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
