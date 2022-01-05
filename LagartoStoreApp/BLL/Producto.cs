using System;

namespace LagartoStoreApp.BLL
{
    public class Producto : Entidad
    {
        #region Atributos
        private decimal precio;
        private Categoria categoria;
        #endregion

        public Producto(int id, string nombre, decimal precio, Categoria categoria) : base(id, nombre)
        {
            this.precio = precio > 0 ? decimal.Round(precio, 2) : throw new ArgumentException("Precio incorrecto.");
            this.categoria = categoria ?? throw new ArgumentNullException(nameof(categoria));
        }

        #region Propiedades
        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + " - S/. " + Precio;
        }
    }
}
