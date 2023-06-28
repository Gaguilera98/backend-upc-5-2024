using System;

namespace backend_upc_5_2023.Dominio
{
    /// <summary>
    /// Dominio de la tabla Usuarios
    /// </summary>
    public class Habitaciones
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
       

        /// <summary>
        /// Gets or sets the nombre completo.
        /// </summary>
        /// <value>
        /// The nombre completo.
        /// </value>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string Area { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Capacidad { get; set; }
        public string Descripcion { get; set; }
        //public string FechaRegistro { get; set;}
       // public int EstadoRegristro { get; set; }

        ////Email
    }
}
