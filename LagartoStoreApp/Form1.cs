using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagartoStoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DBParametro> parametros = new List<DBParametro>();
            parametros.Add(new DBParametro("P_ID_USUARIO", 0));
            var a = ConexionBD.GetData("GET_COLABORADORES", parametros);
        }
    }
}
