using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagartoStoreApp.ConexionBD
{
    public class DBParametro
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }

        public DBParametro(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
