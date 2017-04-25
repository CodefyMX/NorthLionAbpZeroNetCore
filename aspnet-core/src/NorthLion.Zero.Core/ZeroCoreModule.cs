using System.Reflection;
using Abp.Modules;
using Abp.Timing;
using Abp.Zero;
using NorthLion.Zero.Localization;
using Abp.Zero.Configuration;
using NorthLion.Zero.MultiTenancy;
using NorthLion.Zero.Authorization.Roles;
using NorthLion.Zero.Authorization.Users;
using NorthLion.Zero.Timing;

namespace NorthLion.Zero
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ZeroCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            ZeroLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = ZeroConsts.MultiTenancyEnabled;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}