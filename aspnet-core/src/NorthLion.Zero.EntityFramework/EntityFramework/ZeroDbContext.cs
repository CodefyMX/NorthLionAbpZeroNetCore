using System.Data.Common;
using System.Data.Entity;
using Abp.Notifications;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using NorthLion.Zero.Authorization.Roles;
using NorthLion.Zero.Authorization.Users;
using NorthLion.Zero.Configuration;
using NorthLion.Zero.MultiTenancy;
using NorthLion.Zero.Web;

namespace NorthLion.Zero.EntityFramework
{
    [DbConfigurationType(typeof(ZeroDbConfiguration))]
    public class ZeroDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public ZeroDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                ZeroConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of ZeroDbContext since ABP automatically handles it.
         */
        public ZeroDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public ZeroDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public ZeroDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class ZeroDbConfiguration : DbConfiguration
    {
        public ZeroDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
