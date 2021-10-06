using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entities
{
	[Table("Languages")]
	public class Languages
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(3)]
		[Column(TypeName = "varchar(3)")]
		public string Key { get; set; }

		[Required]
		[MaxLength(30)]
		[Column(TypeName = "varchar(30)")]
		public string Title { get; set; }
	}
}
