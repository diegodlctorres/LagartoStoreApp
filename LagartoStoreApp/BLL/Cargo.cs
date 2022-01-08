using System;

namespace LagartoStoreApp.BLL
{
    public class Cargo : Entidad
    {
        #region Propiedades
        public decimal Salario { get; set; }
        #endregion

        //POSIBILIDAD DE AGREGAR UN ATRIBUTO QUE ESPECIFIQUE LA MODALIDAD DE EMPLEO
        //PART TIME - FULL TIME
        public Cargo(int id, string nombre, decimal salario) : base(id, nombre)
        {
            Salario = salario > 0 ? decimal.Round(salario, 2) : 
                throw new ArgumentOutOfRangeException(nameof(salario), "Salario es menor al salario mínimo.");
        }

        public override string ToString()
        {
            return base.ToString() + " - S/. " + decimal.Round(Salario, 2);
        }
    }
}
