using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoffeeManagement.Utilities;

namespace CoffeeManagement.DTOs
{
	[Table("BasicSalary")]
	public class BasicSalary
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public AppEnum.UserLevel UserLevel { get; set; }
		public int Salary { get; set; }
	}
}
