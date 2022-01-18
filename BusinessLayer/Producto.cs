using System;

namespace BusinessLayer
{
    public class Producto : Entidad
    {
        #region Propiedades
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        #endregion

        public Producto(int id, string nombre, decimal precio, int stock, Categoria categoria) : base(id, nombre)
        {
            Precio = precio > 0 ? decimal.Round(precio, 2) : throw new ArgumentException("Precio incorrecto.");
            Stock = stock > 0 ? stock : throw new ArgumentException("Sin stock.");
            Categoria = categoria ?? throw new ArgumentNullException(nameof(categoria));
        }

        public override string ToString()
        {
            return base.ToString() + " - S/. " + Precio;
        }
    }
}
