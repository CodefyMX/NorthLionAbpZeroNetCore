using System.Threading.Tasks;
using Abp.Application.Services;
using NorthLion.Zero.Authorization.Accounts.Dto;

namespace NorthLion.Zero.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
