using LagartoStoreApp.BLL;
using LagartoStoreApp.DAL;

namespace LagartoStoreApp
{
    public abstract class AppEngine
    {
        public static Cuenta cuenta;      

        public static readonly UsuarioDAL usuarioDAL = new UsuarioDAL();
        public static readonly CategoriaDAL categoriaDAL = new CategoriaDAL();
        public static readonly TurnoDAL turnoDAL = new TurnoDAL();
        public static readonly CargoDAL cargoDAL = new CargoDAL();
        public static readonly ProductoDAL productoDAL = new ProductoDAL();
        public static readonly CuentaDAL cuentaDAL = new CuentaDAL();
        public static readonly ClienteDAL clienteDAL = new ClienteDAL();
        public static readonly ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
    }
}
