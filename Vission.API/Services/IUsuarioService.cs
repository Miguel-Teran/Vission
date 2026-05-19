using Vission.API.Models;

namespace Vission.API.Services
{
    public interface IUsuarioService
    {
        List<Usuario> ObtenerTodo();
        Usuario ObtenerPorId(int id);
        void Agregar(Usuario usuario);
        void Actualizar(Usuario usuario);
        void Eliminar(int id);

    }
}
