using LagartoStoreApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagartoStoreApp
{
    public abstract class AppEngine
    {
        public static readonly UsuarioDAL usuarioDAL = new UsuarioDAL();
        public static readonly CategoriaDAL categoriaDAL = new CategoriaDAL();
        public static readonly TurnoDAL turnoDAL = new TurnoDAL();
    }
}
