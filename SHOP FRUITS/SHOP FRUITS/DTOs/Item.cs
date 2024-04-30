using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CoffeeManagement.DTOs
{
	[DataContract]
	[Table("Item")]
	public class Item
	{
		[DataMember]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public int OriginalPrice { get; set; }
		[DataMember]
		public int SalingPrice { get; set; }
		public bool IsDeleted { get; set; }
		[DataMember]
		public int UnitId { get; set; }
		[ForeignKey("UnitId")]
		[DataMember]
		public virtual Unit Unit { get; set; }
		public virtual ICollection<Bill> Bills { get; set; }
	}
}
