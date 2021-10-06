using API.Core.Base;
using API.Core.DTO;
using API.Core.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.L.Controllers
{
	public class LanguageController : ControllerBase
	{
		private readonly ILanguageService _languageService;

		public LanguageController(ILanguageService languageService)
		{
			this._languageService = languageService;
		}

		/// <summary>
		/// Dil ve key bilgisine göre içerik metnini verir.
		/// </summary>
		/// <param name="lang"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		[HttpGet("{lang}/{key}")]
		[Route("Language/{lang}/{key}")]
		public async Task<ServiceResult<LanguageDTO>> Get(string lang, string key)
		{
			var result = await _languageService.getLanguage(lang, key);

			return result;
		}

		/// <summary>
		/// Yeni bir dil oluşturur.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("Language/insertLanguage")]
		public async Task<ServiceResult> InsertLanguage(LanguageInsertDTO data)
		{
			var result = await _languageService.InsertLanguage(data);

			return result;
		}

		/// <summary>
		/// Dile yeni bir içerik ekler.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("Language/insertTranslation")]
		public async Task<ServiceResult> InsertTranslation(TranslationInsertDTO data)
		{
			var result = await _languageService.InsertTranslations(data);

			return result;
		}
	}
}
