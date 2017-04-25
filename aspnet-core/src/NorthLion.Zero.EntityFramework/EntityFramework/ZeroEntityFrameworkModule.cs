using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;

namespace NorthLion.Zero.EntityFramework
{
    [DependsOn(
        typeof(ZeroCoreModule), 
        typeof(AbpZeroEntityFrameworkModule))]
    public class ZeroEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ZeroDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}