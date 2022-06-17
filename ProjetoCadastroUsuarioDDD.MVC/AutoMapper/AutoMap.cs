


using AutoMapper;

namespace ProjetoCadastroUsuarioDDD.MVC.AutoMapper
{
    public static class AutoMap 
    {


        public static IMapper Mapper { get; set; }

        public static void RegisterMappings()
        {
            var mapperConfiguration = new MapperConfiguration(config => { config.AddProfile<DomainToViewModelMappingProfile>(); });

            Mapper = mapperConfiguration.CreateMapper();
        }


    }
}