using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using NorthLion.Zero.Configuration;
using NorthLion.Zero.EntityFramework;

namespace NorthLion.Zero.Migrator
{
    [DependsOn(typeof(ZeroEntityFrameworkModule))]
    public class ZeroMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ZeroMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(ZeroMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<ZeroDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ZeroConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}