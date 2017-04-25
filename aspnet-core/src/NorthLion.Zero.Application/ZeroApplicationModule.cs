using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using NorthLion.Zero.Authorization;

namespace NorthLion.Zero
{
    [DependsOn(
        typeof(ZeroCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZeroApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ZeroAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}