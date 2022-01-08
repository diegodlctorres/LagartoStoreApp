using System;

namespace LagartoStoreApp.BLL
{
    public class Colaborador : Usuario
    {
        #region Propiedades
        public Cargo Cargo { get; set; }
        public Turno Turno { get; set; }
        private DateTime? FechaIngreso { get; set; }
        public DateTime? FechaCese { get; set; }
        public int Codigo { get; set; }
        #endregion

        public Colaborador(int id, string nombre, int telefono, char sexo, string correo, int dni, string apellido,
                           Cargo cargo, Turno turno, DateTime? fechaIngreso, DateTime? fechaCese, int codigo)
            : base(id, nombre, apellido, telefono, sexo, correo, dni)
        {
            Cargo = cargo ?? throw new ArgumentNullException(nameof(cargo));
            Turno = turno ?? throw new ArgumentNullException(nameof(turno));
            FechaIngreso = fechaIngreso ?? throw new ArgumentNullException(nameof(FechaIngreso));
            if (fechaCese != null)
            {
                FechaCese = fechaIngreso <= fechaCese ? fechaCese : throw new ArgumentException("La fecha de cese es incorrecta."); 
            }
            Codigo = codigo;
        }
    }
}
