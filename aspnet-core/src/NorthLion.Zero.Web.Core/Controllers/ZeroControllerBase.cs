using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNet.Identity;

namespace NorthLion.Zero.Controllers
{
    public abstract class ZeroControllerBase: AbpController
    {
        protected ZeroControllerBase()
        {
            LocalizationSourceName = ZeroConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}