using System;

namespace LagartoStoreApp.BLL
{
    public abstract class Entidad
    {
        #region Atributos
        private readonly int id;
        private string nombre;
        #endregion

        protected Entidad(int id, string nombre)
        {
            this.id = id > 0 ? id : throw new ArgumentException("El Id es incorrecto.");
            Nombre = !string.IsNullOrEmpty(nombre) || nombre.Length > 0 ? 
                nombre.ToUpper() : throw new ArgumentNullException(nameof(nombre));
        }

        #region Propiedades
        public int Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        } 
        #endregion

        public override string ToString()
        {
            return Id + " - " + Nombre;
        }
    }
}
