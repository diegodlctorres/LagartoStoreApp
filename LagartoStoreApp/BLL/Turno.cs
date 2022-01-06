using System;

namespace LagartoStoreApp.BLL
{
    public class Turno : Entidad
    {
        #region Atributos
        private DateTime horaInicio;
        private DateTime horaFin;

        public Turno(int id, string nombre, DateTime horaInicio, DateTime horaFin) : base(id, nombre)
        {
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
        #endregion

        #region Propiedades
        public DateTime HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }

        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("Turno {0}: {1:HH:mm} - {2:HH:mm}", Nombre.ToLower(), HoraInicio, HoraFin);
        }
    }
}
