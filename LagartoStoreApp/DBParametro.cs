using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagartoStoreApp
{
    public class DBParametro
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }

        public DBParametro(string nombre, object valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
        }
    }
}
