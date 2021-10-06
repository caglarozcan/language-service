using API.Core.Base;
using API.Core.DTO;
using API.Core.Services.Abstract;
using API.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Services
{
	public class LanguageService : ILanguageService
	{
		private readonly ILanguageRepository _languageRepository;
		private readonly ITranslationRepository _translationRepository;

		public LanguageService(ILanguageRepository languageRepository, ITranslationRepository translationRepository)
		{
			this._languageRepository = languageRepository;
			this._translationRepository = translationRepository;
		}

		public async Task<ServiceResult<LanguageDTO>> getLanguage(string lang, string key)
		{
			var language = await _translationRepository.GetAsync(t => t.Key.Equals(key) && t.Language.Key.Equals(lang), p => p.Language);

			if (language == null)
			{
				return new ServiceResult<LanguageDTO>
				{
					Message = "İstenen dil bilgisi sistemde bulunamadı.",
					StatusCode = 404
				};
			}
			else
			{
				return new ServiceResult<LanguageDTO>
				{
					Data = new LanguageDTO
					{
						Language = language.Language.Title,
						TranslationText = language.TranslationText
					},
					StatusCode = 200
				};
			}
		}

		public async Task<ServiceResult> InsertLanguage(LanguageInsertDTO data)
		{
			await _languageRepository.InsertAsync(new Data.Entities.Languages { Key = data.Key, Title = data.Title });

			return new ServiceResult
			{
				StatusCode = 200,
				Message = "Dil ekleme işlemi başarılı."
			};
		}

		public async Task<ServiceResult> InsertTranslations(TranslationInsertDTO data)
		{
			await _translationRepository.InsertAsync(new Data.Entities.Translations { LanguageId = data.LanguageId, Key = data.Key, TranslationText = data.TranslationText });

			return new ServiceResult
			{
				StatusCode = 200,
				Message = "Dil içeriği ekleme işlemi başarılı."
			};
		}
	}
}
