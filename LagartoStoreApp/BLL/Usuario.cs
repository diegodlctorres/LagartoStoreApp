using System;

namespace LagartoStoreApp.BLL
{
    public class Usuario : Entidad
    {
        #region Propiedades
        public char Sexo { get; set; }
        public int Dni { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        #endregion

        public Usuario(int id, string nombre, string apellido, int telefono, char sexo, string correo, int dni) : base(id, nombre)
        {
            Apellido = !string.IsNullOrEmpty(apellido) || apellido.Length > 0 ? 
                apellido.ToUpper() : throw new ArgumentNullException(nameof(apellido));
            Correo = correo.Contains("@") && (correo.Contains(".edu") || correo.Contains(".com")) ?
                correo.Replace(" ", string.Empty).ToLower() : throw new ArgumentException("Correo incorrecto.");
            Sexo = sexo == 'M' || sexo == 'F' ? 
                sexo : throw new ArgumentException("Sexo incorrecto.");
            Telefono = telefono.ToString().Length == 9 && telefono > 900000000 ? 
                telefono : throw new ArgumentException("Teléfono incorrecto.");
            Dni = dni.ToString().Length == 8 && dni > 10000000 ? 
                dni : throw new ArgumentException("DNI incorrecto.");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Apellido;
        }
    }
}
