using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTOs.ViewModels
{
	public class StatsByItems : IDisposable
	{
		public Item Item { get; set; }
		public int Quantity { get; set; }
		public int Total { get; set; }

		public void Dispose()
		{
			GC.Collect();
		}
	}
}
