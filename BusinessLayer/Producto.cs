using System;

namespace BusinessLayer
{
    public class Producto : Entidad
    {
        #region Propiedades
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        #endregion

        public Producto(int id, string nombre, decimal precio, Categoria categoria) : base(id, nombre)
        {
            Precio = precio > 0 ? decimal.Round(precio, 2) : throw new ArgumentException("Precio incorrecto.");
            Categoria = categoria ?? throw new ArgumentNullException(nameof(categoria));
        }

        public override string ToString()
        {
            return base.ToString() + " - S/. " + Precio;
        }
    }
}
