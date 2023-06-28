// Ignore Spelling: Categoria

using backend_upc_5_2023.Connection;
using backend_upc_5_2023.Dominio;
using Dapper;
using System.Data;

namespace backend_upc_5_2023.Servicios
{
    /// <summary>
    /// Clase de servicios para la entidad: <see cref="Reserva"/>
    /// </summary>
    public static class ReservaServicios
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        public static IEnumerable<Reserva> Get()
        {
            const string sql = "SELECT * FROM RESERVA";

            var enummerableReserva = DBManager.Instance.GetData<Reserva>(sql);

            foreach (var item in enummerableReserva)
            {
                item.Usuario = UsuariosServicios.GetById<Usuarios>(item.IdUsuario);
            }

            return enummerableReserva;
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static T GetById<T>(int id)
        {
            const string sql = "SELECT * FROM RESERVA WHERE ID = @Id";

            var parameters = new DynamicParameters();
            parameters.Add("ID", id, DbType.Int64);

            var result = DBManager.Instance.GetDataConParametros<T>(sql, parameters);

            return result.FirstOrDefault();
        }

        /// <summary>
        /// Inserts the specified usuarios.
        /// </summary>
        /// <param name="usuarios">The usuarios.</param>
        /// <returns></returns>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        public static int Insert(Reserva reserva)
        {
            const string sql = "INSERT INTO RESERVA([ID_HABITACION],[ID_USUARIO],[FECHA_ENTRADA],[FECHA_SALIDA],[ESTADO_RESERVA]) VALUES (@IdHabitacion, @IdUsuario, @FechaEntrada,@FechaSalida,@EstadoReserva) ";

            var parameters = new DynamicParameters();
            parameters.Add("IdHabitacion", reserva.IdHabitacion, DbType.Int64);
            parameters.Add("IdUsuario", reserva.IdUsuario, DbType.Int64);
            parameters.Add("FechaEntrada", reserva.FechaEntrada, DbType.DateTime);
            parameters.Add("FechaSalida", reserva.FechaSalida, DbType.DateTime);
            parameters.Add("EstadoReserva", reserva.EstadoReserva, DbType.String);


            var result = DBManager.Instance.SetData(sql, parameters);

            return result;
        }
    }
}
