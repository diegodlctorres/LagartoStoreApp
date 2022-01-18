using System;

namespace BusinessLayer
{
    public class Cuenta
    {
        #region Propiedades
        public int Id { get; private set; }
        public Usuario Usuario { get; private set; }
        public string NombreDeUsuario { get; private set; } 
        public string Contraseña { get; set; }
        public bool IsActivo { get; set; } 
        #endregion

        public Cuenta(int id, Usuario usuario, string nombreDeUsuario, string contraseña, bool isActivo)
        {
            Id = id > 0 ? id : throw new ArgumentException("El Id es incorrecto.");
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            NombreDeUsuario = nombreDeUsuario;
            Contraseña = !string.IsNullOrEmpty(contraseña) || contraseña.Length > 0 ?
                contraseña : throw new ArgumentNullException(nameof(contraseña));
            IsActivo = isActivo;
        }
    }
}
