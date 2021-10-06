using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entities
{
	[Table("Translations")]
	public class Translations
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public int LanguageId { get; set; }

		[Required]
		[MaxLength(20)]
		[Column(TypeName = "varchar(20)")]
		public string Key { get; set; }

		[Required]
		[MaxLength(1000)]
		[Column(TypeName = "varchar(1000)")]
		public string TranslationText { get; set; }

		[ForeignKey("LanguageId")]
		public virtual Languages Language { get; set; }
	}
}
