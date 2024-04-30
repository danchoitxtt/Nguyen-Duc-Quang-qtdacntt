using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoffeeManagement.Utilities;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;

namespace CoffeeManagement.DTOs
{
	[DataContract]
	[Table("User")]
	public class User
	{
		[DataMember]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[DataMember]
		public string FullName { get; set; }
		[DataMember]
		public string UserName { get; set; }
		[DataMember]
		public string Password { get; set; }
		public AppEnum.UserLevel Level { get; set; }
		public string Description { get; set; }
		public bool IsDeleted { get; set; }

		public virtual ICollection<Bill> Bills { get; set; }
		public virtual ICollection<Shift> Shifts { get; set; }
	}
}
