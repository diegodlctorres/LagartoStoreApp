using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Utilitario
{
    public class Util
    {
        public static void Centrar(Control contenedor, Control control)
        {
            control.Location = new Point((contenedor.Width / 2) - (control.Width / 2), control.Location.Y);
        }

        public static void AjustarDataGridView(Control contenedor, DataGridView dataGridView)
        {
            //var b = dataGridView.VerticalScrollBar;

            //foreach(var a  in dataGridView.Controls.OfType<ScrollBar>())
            //{
            //    var b = a.Width;
            //}

            //var c = dataGridView.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width);           

            var a = dataGridView.Rows.Count > 19 ? 17 : 0;

            contenedor.Width = dataGridView.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + 23 + a;
            // 1 a cada lado y ¿21?
        }
    }
}
