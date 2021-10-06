using API.Core.Base;
using API.Core.DTO;
using System.Threading.Tasks;

namespace API.Core.Services.Abstract
{
	public interface ILanguageService
	{
		Task<ServiceResult<LanguageDTO>> getLanguage(string lang, string key);

		Task<ServiceResult> InsertLanguage(LanguageInsertDTO data);

		Task<ServiceResult> InsertTranslations(TranslationInsertDTO data);
	}
}
