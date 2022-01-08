using System;

namespace LagartoStoreApp.BLL
{
    public class Turno : Entidad
    {
        #region Propiedades
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        #endregion

        public Turno(int id, string nombre, DateTime horaInicio, DateTime horaFin) : base(id, nombre)
        {
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }

        public override string ToString()
        {
            return string.Format("Turno {0}: {1:HH:mm} - {2:HH:mm}", Nombre.ToLower(), HoraInicio, HoraFin);
        }
    }
}
