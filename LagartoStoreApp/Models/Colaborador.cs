using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagartoStoreApp.Models
{
    public class Colaborador : Usuario
    {
        #region Atributos
        private readonly Cargo cargo;
        private readonly Turno turno;
        private DateTime? fechaIngreso;
        private DateTime? fechaCese;
        private int codigo;
        #endregion

        public Colaborador(int id, string nombre, int telefono, char sexo, string correo, int dni, string apellido,
                           Cargo cargo, Turno turno, DateTime? fechaIngreso, DateTime? fechaCese, int codigo)
            : base(id, nombre, apellido, telefono, sexo, correo, dni)
        {
            this.cargo = cargo ?? throw new ArgumentNullException(nameof(cargo));
            this.turno = turno ?? throw new ArgumentNullException(nameof(turno));
            FechaIngreso = fechaIngreso ?? throw new ArgumentNullException(nameof(FechaIngreso));
            if (fechaCese != null)
            {
                FechaCese = fechaIngreso <= fechaCese ? fechaCese : throw new ArgumentException("La fecha de cese es incorrecta."); 
            }
            Codigo = codigo;
        }

        #region Propiedades
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public DateTime? FechaCese
        {
            get { return fechaCese; }
            set { fechaCese = value; } 
        }

        public DateTime? FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        public Turno Turno
        {
            get { return turno; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
        } 
        #endregion

    }
}
