using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.DTO
{
	public class TranslationInsertDTO
	{
		public int LanguageId { get; set; }

		public string Key { get; set; }

		public string TranslationText { get; set; }
	}
}
