using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CoffeeManagement.DTOs
{
	[DataContract]
	[Table("Unit")]
	public class Unit
	{
		[DataMember]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		public virtual ICollection<Item> Items { get; set; }
	}
}
