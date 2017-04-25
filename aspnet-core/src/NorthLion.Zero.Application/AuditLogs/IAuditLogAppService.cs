using System.Threading.Tasks;
using Abp.Application.Services;
using NorthLion.Zero.AuditLogs.Dto;
using NorthLion.Zero.PaginatedModel;

namespace NorthLion.Zero.AuditLogs
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<AuditLogOutput> GetLatestAuditLogOutput();
        Task<AuditLogOutput> GetAuditLogTable(AuditLogPaginableInput input);
        Task<AuditLogDto> GetAuditLogDetails(long id);
        AuditLogTimeOutput GetAuditLogTimes(AuditLogTimesInput input);
        Task<AuditLogOutput> GetLatestAuditLogOutputForTenant(long tenantId);
        Task<AuditLogOutput> GetAuditLogTableForTenant(PaginatedInputDto input, int tenantId);
        Task<AuditLogDto> GetAuditLogDetailsForTenant(long id, int tenantId);
    }
}
