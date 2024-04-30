using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeManagement.DTOs
{
	[Table("Shift")]
	public class Shift
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public bool DidWorkShift1 { get; set; }
		public bool DidWorkShift2 { get; set; }
		public bool DidWorkShift3 { get; set; }
		public DateTime Date { get; set; }

		public int UserId { get; set; }
		[ForeignKey("UserId")]
		public virtual User User { get; set; }
		public string Note { get; set; }
	}
}
