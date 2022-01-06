using System;

namespace LagartoStoreApp.BLL
{
    public class Cargo : Entidad
    {
        #region Atributos
        private decimal salario; 
        #endregion

        public Cargo(int id, string nombre, decimal salario) : base(id, nombre)
        {
            Salario = salario > 930 ? decimal.Round(salario, 2) : 
                throw new ArgumentOutOfRangeException(nameof(salario), "Salario es menor al salario mínimo.");
        }

        #region Propiedades
        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        } 
        #endregion

        public override string ToString()
        {
            return base.ToString() + " - S/. " + decimal.Round(Salario, 2);
        }
    }
}
