using System;
using System.Data;
using System.Data.SqlClient;

namespace Parcial2_1
{
    class Conexion_base_datos
    {
        private const string CADENA_CONEXION =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_parcial2_1;Integrated Security=True";

        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Conexion_base_datos()
        {
            miConexion.ConnectionString = CADENA_CONEXION;
            miComando.Connection = miConexion;
        }

        public DataSet crearDs()
        {
            ds.Clear();
            miComando.Parameters.Clear();
            miAdaptador.SelectCommand = miComando;

            miComando.CommandText = "SELECT idUsuario, usuario, clave, nombre, direccion, telefono FROM usuarios_usis018804 ORDER BY idUsuario";
            miAdaptador.Fill(ds, "usuarios");

            miComando.CommandText = "SELECT idAlumno, codigo, nombre, direccion, telefono FROM alumnos ORDER BY idAlumno";
            miAdaptador.Fill(ds, "alumnos");

            miComando.CommandText = "SELECT idMateria, codigo, nombre, uv FROM materias ORDER BY idMateria";
            miAdaptador.Fill(ds, "materias");

            miComando.CommandText = "SELECT idPeriodo, periodo, fecha FROM periodos ORDER BY fecha";
            miAdaptador.Fill(ds, "periodos");

            return ds;
        }

        public string mantenimiento_usuarios_usis018804(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "nuevo")
                sql = "INSERT INTO usuarios_usis018804 (usuario, clave, nombre, direccion, telefono) " +
                      "VALUES (@usuario, @clave, @nombre, @direccion, @telefono)";
            else if (accion == "modificar")
                sql = "UPDATE usuarios_usis018804 SET usuario = @usuario, clave = @clave, nombre = @nombre, " +
                      "direccion = @direccion, telefono = @telefono WHERE idUsuario = @idUsuario";
            else if (accion == "eliminar")
                sql = "DELETE FROM usuarios_usis018804 WHERE idUsuario = @idUsuario";
            else
                return "Accion no reconocida: " + accion;

            SqlParameter[] parametros =
            {
                new SqlParameter("@idUsuario", SqlDbType.Int)         { Value = aEntero(datos[0]) },
                new SqlParameter("@usuario",   SqlDbType.VarChar, 35) { Value = datos[1] },
                new SqlParameter("@clave",     SqlDbType.VarChar, 35) { Value = datos[2] },
                new SqlParameter("@nombre",    SqlDbType.VarChar, 65) { Value = datos[3] },
                new SqlParameter("@direccion", SqlDbType.VarChar, 85) { Value = datos[4] },
                new SqlParameter("@telefono",  SqlDbType.VarChar, 9)  { Value = datos[5] }
            };
            return procesar(sql, parametros);
        }

        public string administrarDatosAlumnos(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "nuevo")
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            else if (accion == "modificar")
                sql = "UPDATE alumnos SET codigo = @codigo, nombre = @nombre, direccion = @direccion, telefono = @telefono WHERE idAlumno = @id";
            else if (accion == "eliminar")
                sql = "DELETE FROM alumnos WHERE idAlumno = @id";

            SqlParameter[] parametros =
            {
                new SqlParameter("@id",        SqlDbType.Int)         { Value = aEntero(datos[0]) },
                new SqlParameter("@codigo",    SqlDbType.VarChar, 10) { Value = datos[1] },
                new SqlParameter("@nombre",    SqlDbType.VarChar, 65) { Value = datos[2] },
                new SqlParameter("@direccion", SqlDbType.VarChar, 85) { Value = datos[3] },
                new SqlParameter("@telefono",  SqlDbType.VarChar, 9)  { Value = datos[4] }
            };
            return procesar(sql, parametros);
        }

        public string administrarDatosMaterias(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "nuevo")
                sql = "INSERT INTO materias (codigo, nombre, uv) VALUES (@codigo, @nombre, @uv)";
            else if (accion == "modificar")
                sql = "UPDATE materias SET codigo = @codigo, nombre = @nombre, uv = @uv WHERE idMateria = @id";
            else if (accion == "eliminar")
                sql = "DELETE FROM materias WHERE idMateria = @id";

            SqlParameter[] parametros =
            {
                new SqlParameter("@id",     SqlDbType.Int)         { Value = aEntero(datos[0]) },
                new SqlParameter("@codigo", SqlDbType.Int)         { Value = aEntero(datos[1]) },
                new SqlParameter("@nombre", SqlDbType.VarChar, 65) { Value = datos[2] },
                new SqlParameter("@uv",     SqlDbType.Int)         { Value = aEntero(datos[3]) }
            };
            return procesar(sql, parametros);
        }

        public string guardarPeriodos(DataTable periodos)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.InsertCommand = new SqlCommand("INSERT INTO periodos (periodo, fecha) VALUES (@periodo, @fecha)", miConexion);
            adaptador.InsertCommand.Parameters.Add("@periodo", SqlDbType.VarChar, 30, "periodo");
            adaptador.InsertCommand.Parameters.Add("@fecha", SqlDbType.Date, 0, "fecha");

            adaptador.UpdateCommand = new SqlCommand("UPDATE periodos SET periodo = @periodo, fecha = @fecha WHERE idPeriodo = @idPeriodo", miConexion);
            adaptador.UpdateCommand.Parameters.Add("@periodo", SqlDbType.VarChar, 30, "periodo");
            adaptador.UpdateCommand.Parameters.Add("@fecha", SqlDbType.Date, 0, "fecha");
            adaptador.UpdateCommand.Parameters.Add("@idPeriodo", SqlDbType.Int, 0, "idPeriodo");

            adaptador.DeleteCommand = new SqlCommand("DELETE FROM periodos WHERE idPeriodo = @idPeriodo", miConexion);
            SqlParameter pId = adaptador.DeleteCommand.Parameters.Add("@idPeriodo", SqlDbType.Int, 0, "idPeriodo");
            pId.SourceVersion = DataRowVersion.Original;

            try
            {
                adaptador.Update(periodos);
                return "1";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    return "No se puede eliminar un período que ya tiene notas registradas.";
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable obtenerNotas(int idMateria, int idPeriodo)
        {
            DataTable notas = new DataTable("notasAlumnos");
            miComando.Parameters.Clear();
            miComando.CommandText =
                "SELECT alumnos.nombre, dnotas.idDetalle, dnotas.idNota, dnotas.idMateria, " +
                "dnotas.lab1, dnotas.lab2, dnotas.parcial, " +
                "CAST(dnotas.lab1 * 0.3 + dnotas.lab2 * 0.3 + dnotas.parcial * 0.4 AS DECIMAL(5,2)) AS nf " +
                "FROM dnotas " +
                "INNER JOIN notas ON notas.idNota = dnotas.idNota " +
                "INNER JOIN alumnos ON alumnos.idAlumno = notas.idAlumno " +
                "WHERE notas.idPeriodo = @idPeriodo AND dnotas.idMateria = @idMateria " +
                "ORDER BY alumnos.nombre";
            miComando.Parameters.Add("@idPeriodo", SqlDbType.Int).Value = idPeriodo;
            miComando.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMateria;
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(notas);
            miComando.Parameters.Clear();
            return notas;
        }

        public string actualizarNota(int idDetalle, decimal lab1, decimal lab2, decimal parcial)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@lab1", SqlDbType.Decimal)    { Value = lab1, Precision = 4, Scale = 2 },
                new SqlParameter("@lab2", SqlDbType.Decimal)    { Value = lab2, Precision = 4, Scale = 2 },
                new SqlParameter("@parcial", SqlDbType.Decimal) { Value = parcial, Precision = 4, Scale = 2 },
                new SqlParameter("@idDetalle", SqlDbType.Int)   { Value = idDetalle }
            };
            return procesar("UPDATE dnotas SET lab1 = @lab1, lab2 = @lab2, parcial = @parcial WHERE idDetalle = @idDetalle", parametros);
        }

        public string procesar(string sql, SqlParameter[] parametros)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Parameters.Clear();
                miComando.Parameters.AddRange(parametros);
                miConexion.Open();
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un registro con ese código o nombre de usuario.";
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                miComando.Parameters.Clear();
                if (miConexion.State == ConnectionState.Open) miConexion.Close();
            }
        }

        public bool validarUsuario(string usuario, string clave)
        {
            try
            {
                miComando.CommandText =
                    "SELECT COUNT(*) FROM usuarios_usis018804 " +
                    "WHERE usuario = @usuario AND clave = @clave COLLATE Latin1_General_CS_AS";
                miComando.Parameters.Clear();
                miComando.Parameters.Add("@usuario", SqlDbType.VarChar, 35).Value = usuario;
                miComando.Parameters.Add("@clave", SqlDbType.VarChar, 35).Value = clave;
                miConexion.Open();
                return Convert.ToInt32(miComando.ExecuteScalar()) > 0;
            }
            finally
            {
                miComando.Parameters.Clear();
                if (miConexion.State == ConnectionState.Open) miConexion.Close();
            }
        }

        private static int aEntero(string texto)
        {
            int numero;
            return int.TryParse(texto, out numero) ? numero : 0;
        }
    }
}
