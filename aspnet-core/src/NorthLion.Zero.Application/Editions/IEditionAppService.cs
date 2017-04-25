using System.Threading.Tasks;
using Abp.Application.Services;
using NorthLion.Zero.Editions.Dto;
using NorthLion.Zero.PaginatedModel;
namespace NorthLion.Zero.Editions
{
    public interface IEditionAppService : IApplicationService
    {
        EditionOutput GetEditions(PaginatedInputDto input);
        Task CreateEdition(CreateEditionInput input);
        Task UpdateEdition(EditEditionInput input);
        Task DeleteEdition(int id);
        CreateEditionInput GetEditionModelForCreation();
        Task<EditEditionInput> GetEditionModelForEdit(int id);
    }
}
