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

        public Cliente(Usuario usuario) : base(usuario.Id, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Sexo, usuario.Correo, usuario.Dni) { }        

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}", Codigo, Nombre, Apellido);
        }
    }
}
