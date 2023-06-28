// Ignore Spelling: Categoria

using backend_upc_5_2023.Connection;
using backend_upc_5_2023.Dominio;
using Dapper;
using System.Data;

namespace backend_upc_5_2023.Servicios
{
    /// <summary>
    /// Clase de servicios para la entidad: <see cref="Habitaciones"/>
    /// </summary>
    public static class HabitacionesServicios
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        public static IEnumerable<T> Get<T>()
        {
            const string sql = "SELECT * FROM HABITACION WHERE ESTADO_REGISTRO = 1";

            return DBManager.Instance.GetData<T>(sql);
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static T GetById<T>(int id)
        {
            const string sql = "SELECT * FROM HABITACION WHERE ID = @Id AND ESTADO_REGISTRO = 1";

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
        public static int Insert(Habitaciones habitaciones)
        {
            const string sql = "INSERT INTO HABITACION([NOMBRE], [Area], [CAPACIDAD],[DESCRIPCION]) VALUES (@Nombre, @Area, @Capacidad,@Descripcion) ";

            var parameters = new DynamicParameters();
            parameters.Add("Nombre", habitaciones.Nombre, DbType.String);
            parameters.Add("Area", habitaciones.Area, DbType.String);
            parameters.Add("Capacidad", habitaciones.Capacidad, DbType.String);
            parameters.Add("Descripcion", habitaciones.Descripcion, DbType.String);

            var result = DBManager.Instance.SetData(sql, parameters);

            return result;
        }
    }
}
