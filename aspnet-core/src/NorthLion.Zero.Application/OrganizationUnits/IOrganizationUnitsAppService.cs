using System.Threading.Tasks;
using Abp.Application.Services;
using NorthLion.Zero.OrganizationUnits.Dto;

namespace NorthLion.Zero.OrganizationUnits
{
    public interface IOrganizationUnitsAppService : IApplicationService
    {
        Task CreateOrganizationUnit(OrganizationUnitInput input);
        Task MoveOrganizationUnit(MoveOrganizationUnitInput input);
        Task AddUserToOrganizationUnit(long userId, int organizationUnitId);
        Task UpdateOrganizationUnit(UpdateOrganizationUnitInput input);
        Task<OrganizationUnitsTreeModel> GetOrganizationUnitsTree();
        UpdateOrganizationUnitInput GetOrganizationUnitForEdit(long id);
        Task DeleteOrganizationUnit(long id);
        Task DeleteUserFromOrganizationUnit(long userId, int organizationUnitId);
    }
}
