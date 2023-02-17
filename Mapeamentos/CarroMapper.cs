using AutoMapper;
using AutoMapper.Modelo;

namespace APIAutoMapper.Mapeamentos
{
    public class CarroMapper : Profile
    {
        public CarroMapper() 
        {
            CreateMap<SaidaDeDadosCarro, Carro>();
            CreateMap<EntradaDadosCarro, Carro>();

            CreateMap<Carro, SaidaDeDadosCarro>()
                .ForMember(sc => sc.TipoDoCarro,
                options => options.MapFrom(m => m.TipoDoCarro.ToString()));

            CreateMap<Carro, SaidaDeDadosCarro>()
                .ForMember(sc => sc.CorDoCarro,
                options => options.MapFrom(m => m.CorDoCarro.ToString()));

            CreateMap<Carro, SaidaDeDadosCarro>()
                .ForMember(sc => sc.Marca,
                options => options.MapFrom(m => m.Marca.ToString()));

        }
    }
}
