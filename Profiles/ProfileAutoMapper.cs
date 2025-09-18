using AutoMapper;
using SistemaVendasWeb.Dtos.Usuario;
using SistemaVendasWeb.Models;

namespace SistemaVendasWeb.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper()
        {
            CreateMap<UsuarioCriacaoDto, UsuarioModel>().ReverseMap();
        }
    }
}
