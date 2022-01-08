using System;

namespace LagartoStoreApp.BLL
{
    public abstract class Entidad
    {
        #region Propiedades
        public int Id { get; private set; }
        public string Nombre { get; set; }
        #endregion

        protected Entidad(int id, string nombre)
        {
            Id = id > 0 ? id : throw new ArgumentException("El Id es incorrecto.");
            Nombre = !string.IsNullOrEmpty(nombre) || nombre.Length > 0 ?
                nombre.Trim().ToUpper() : throw new ArgumentNullException(nameof(nombre));
        }

        public override string ToString()
        {
            return Id + " - " + Nombre;
        }
    }
}
