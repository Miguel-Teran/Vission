using Microsoft.Data.SqlClient;
using System.Data;
using Vission.API.Models;

namespace Vission.API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly string _connection;

        public UsuarioService(IConfiguration config)
        {
            _connection = config.GetConnectionString("DefaultConnection");
        }

        public List<Usuario> ObtenerTodo()
        {
            var usuarios = new List<Usuario>();
            
            using SqlConnection conn = new SqlConnection(_connection);
            using SqlCommand cmd = new SqlCommand("ObtenerTodo", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usuarios.Add(new Usuario
                {
                    UsuId = reader.GetInt32("UsuId"),
                    UsuNombre = reader.GetString("UsuNombre"),
                    UsuTelefono = reader.GetString("UsuTelefono"),
                    UsuDireccion = reader.GetString("UsuDireccion"),
                    UsuCorreo = reader.GetString("UsuCorreo"),
                    UsuContraseña = reader.GetString("UsuContraseña"),
                    UsuRol = reader.GetInt32("UsuRol")
                });
            }

            return usuarios;
        }
        public Usuario ObtenerPorId(int id)
        {
            Usuario usuario = null;

            using SqlConnection conn = new SqlConnection(_connection);
            using SqlCommand cmd = new SqlCommand("ObtenerPorId", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UsuId", id);
            conn.Open();

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                usuario = new Usuario
                {
                    UsuId = reader.GetInt32("UsuId"),
                    UsuNombre = reader.GetString("UsuNombre"),
                    UsuTelefono = reader.GetString("UsuTelefono"),
                    UsuDireccion = reader.GetString("UsuDireccion"),
                    UsuCorreo = reader.GetString("UsuCorreo"),
                    UsuContraseña = reader.GetString("UsuContraseña"),
                    UsuRol = reader.GetInt32("UsuRol")
                };
            }
            return usuario;
        }
        public void Agregar(Usuario usuario)
        {

        }
        public void Actualizar(Usuario usuario)
        {
        }
        public void Eliminar(int id)
        {
        }
    }
}
