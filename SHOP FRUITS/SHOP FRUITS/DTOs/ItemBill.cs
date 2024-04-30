using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeManagement.DTOs
{
	[Table("ItemBill")]
	public class ItemBill
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public Bill Bill { get; set; }
		public Item Item { get; set; }
		public int Quantity { get; set; }
		public int OriginalPrice { get; set; }
		public int SalingPrice { get; set; }
	}
}
