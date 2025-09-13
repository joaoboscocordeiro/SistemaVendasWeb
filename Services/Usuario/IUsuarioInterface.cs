using SistemaVendasWeb.Models;

namespace SistemaVendasWeb.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<UsuarioModel>> Login();
    }
}
