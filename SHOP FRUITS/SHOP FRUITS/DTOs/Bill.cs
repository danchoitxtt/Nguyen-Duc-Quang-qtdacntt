using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CoffeeManagement.DTOs
{
	[DataContract]
	[Table("Bill")]
	public class Bill
	{
		[DataMember]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[DataMember]
		public DateTime CreatedDateTime { get; set; }

		[DataMember]
		public DateTime PaidDateTime { get; set; }
		[DataMember]
		public int CurrentUserId { get; set; }
		[DataMember]
		public virtual User CurrentUser { get; set; }
		[DataMember]
		public virtual ICollection<Item> Items { get; set; }

		[DataMember]
		public virtual ICollection<Table> Tables { get; set; }

		[DataMember]
		public int PreTotal { get; set; }
		[DataMember]
		public bool IsClosed { get; set; }
		[DataMember]
		public float DiscountRate { get; set; }
		[DataMember]
		public int Total { get; set; }

		public Bill()
		{
			Items = new List<Item>();
			Tables = new List<Table>();
		}
	}
}
