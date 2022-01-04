using System;

namespace LagartoStoreApp.BLL
{
    public class Usuario : Entidad
    {
        #region Atributos
        private int telefono;
        private char sexo;
        private string correo;
        private int dni;
        private string apellido; 
        #endregion

        public Usuario(int id, string nombre, string apellido, int telefono, char sexo, string correo, int dni) : base(id, nombre)
        {
            Apellido = !string.IsNullOrEmpty(apellido) || apellido.Length > 0 ? 
                apellido.ToUpper() : throw new ArgumentNullException(nameof(apellido));
            Correo = correo.Contains("@") && (correo.Contains(".edu") || correo.Contains(".com")) ?
                correo : throw new ArgumentException("Correo incorrecto.");
            Sexo = sexo == 'M' || sexo == 'F' ? 
                sexo : throw new ArgumentException("Sexo incorrecto.");
            Telefono = telefono.ToString().Length == 9 && telefono > 900000000 ? 
                telefono : throw new ArgumentException("Teléfono incorrecto.");
            Dni = dni.ToString().Length == 8 && dni > 10000000 ? 
                dni : throw new ArgumentException("DNI incorrecto.");
        }

        #region Propiedades
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " " + Apellido;
        }
        #endregion

    }
}
