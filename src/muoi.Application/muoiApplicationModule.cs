using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using muoi.Authorization;

namespace muoi
{
    [DependsOn(
        typeof(muoiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class muoiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<muoiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(muoiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
