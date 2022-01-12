namespace LagartoStoreApp.BLL
{
    public class Cliente : Usuario
    {
        #region Propiedades
        public int Codigo { get; private set; } 
        #endregion

        public Cliente(int id, string nombre, string apellido, int telefono, char sexo, string correo, int dni, int codigo) : base(id, nombre, apellido, telefono, sexo, correo, dni)
        {
            Codigo = codigo;
        }

    }
}
