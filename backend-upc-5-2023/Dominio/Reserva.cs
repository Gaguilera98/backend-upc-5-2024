using System;

namespace backend_upc_5_2023.Dominio
{
    /// <summary>
    /// Dominio de la tabla Usuarios
    /// </summary>
    public class Reserva
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        /// 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the nombre completo.
        /// </summary>
        /// <value>
        /// The nombre completo.
        /// </value>
        public int IdHabitacion { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public int IdUsuario { get; set; }
                public Usuarios? Usuario { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string EstadoReserva { get; set; }
        //public string FechaRegistro { get; set;}
        // public int EstadoRegristro { get; set; }

        ////Email
      
    }
}
