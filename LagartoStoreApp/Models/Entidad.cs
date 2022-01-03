using System;

namespace LagartoStoreApp.Models
{
    public abstract class Entidad
    {
        #region Atributos
        private readonly int id;
        private string nombre;
        #endregion

        protected Entidad(int id, string nombre)
        {
            this.id = id;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
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
