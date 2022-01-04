using System;

namespace LagartoStoreApp.BLL
{
    public class Cargo : Entidad
    {
        private decimal salario;

        public Cargo(int id, string nombre, decimal salario) : base(id, nombre)
        {
            Salario = salario > 930 ? salario : 
                throw new ArgumentOutOfRangeException(nameof(salario), "Salario es menor al salario mínimo.");
        }

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " - S/. " + decimal.Round(Salario, 2);
        }
    }
}
