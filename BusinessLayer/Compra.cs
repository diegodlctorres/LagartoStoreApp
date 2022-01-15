using System;

namespace BusinessLayer
{
    public class Compra
    {
        #region Propiedades
        public int Id { get; private set; }
        public DateTime Fecha { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public Cliente Cliente { get; private set; } 
        #endregion

        public Compra(int id, DateTime fecha, Colaborador colaborador, Cliente cliente)
        {
            Id = id;
            Fecha = fecha;
            Colaborador = colaborador ?? throw new ArgumentNullException(nameof(colaborador));
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        }
    }
}
