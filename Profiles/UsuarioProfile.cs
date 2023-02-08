using AutoMapper;
using UsuarioAPI.DTO;
using UsuarioAPI.Entities;

namespace UsuarioAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDTO, Usuario>();
        }
    }
}
