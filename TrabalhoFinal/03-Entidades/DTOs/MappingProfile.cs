using AutoMapper;

namespace TrabalhoFinal._03_Entidades.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreatePessoaDTO, Pessoa>().ReverseMap();
            CreateMap<Rotina, ReadRotinaDTO>().ReverseMap();
        }
    }
}
