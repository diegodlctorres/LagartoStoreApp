using System;

namespace LagartoStoreApp.BLL
{
    public class Turno : Entidad
    {
        #region Atributos
        private readonly DateTime horaInicio;
        private readonly DateTime horaFin;

        public Turno(int id, string nombre, DateTime horaInicio, DateTime horaFin) : base(id, nombre)
        {
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }
        #endregion

        #region Propiedades
        public DateTime HoraFin
        {
            get { return horaFin; }
        }

        public DateTime HoraInicio
        {
            get { return horaInicio; }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("Turno {0}: {1:HH:mm} - {2:HH:mm}", Nombre.ToLower(), HoraInicio, HoraFin);
        }
    }
}
