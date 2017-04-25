using System.Threading.Tasks;
using Abp.Application.Services;
using NorthLion.Zero.Sessions.Dto;

namespace NorthLion.Zero.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
