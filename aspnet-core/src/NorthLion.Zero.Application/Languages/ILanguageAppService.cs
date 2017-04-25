using System.Threading.Tasks;
using Abp.Application.Services;
using NorthLion.Zero.Languages.Dto;
using NorthLion.Zero.PaginatedModel;

namespace NorthLion.Zero.Languages
{
    public interface ILanguageAppService : IApplicationService
    {
        Task UpdateLanguageFromXml(string languageName, string source, bool updateExistingValues = false);
    
        Task CreateLanguage(LanguageInput input);
        Task<LanguagesOutput> GetLanguagesForTable(PaginatedInputDto input);
        LocalizationTextsOutput GetLocalizationTexts(GetLocalizationTextInput input);
        LanguageTextEditView GetLanguageTextsForEditView(string selectedTargetLanguage,
            string selectedSourceLanguage);
        Task EditLocalizationText(LanguageTextEditInput input);
        Task DeleteLanguage(string code);

    }
}
