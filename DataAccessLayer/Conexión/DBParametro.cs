namespace DataAccessLayer
{
    public sealed class DBParametro
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
