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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //UsuarioDAL.GetUsuarioById(1);
                //UsuarioDAL.DeleteUsuario(202);
                //Usuario usuario = new Usuario(1, "", "", 0, ' ', "", 0);
                //UsuarioDAL.CreateUsuario(null);

                grdConsulta.DataSource = UsuarioDAL.GetUsuarios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario(this);
            frmNuevoUsuario.ShowDialog();
        }
    }
}
