using System.Drawing;
using System.Windows.Forms;

namespace Utilitario
{
    public class Util
    {
        public static void Centrar(Control contenedor, Control control)
        {
            control.Location = new Point((contenedor.Width / 2) - (control.Width / 2), control.Location.Y);
        }
    }
}
