using System.Linq;
using CoffeeManagement.DTOs;
using System.Collections.Generic;
namespace CoffeeManagement.DAO
{
	public class TableDao
	{
		CoffeeDbContext db = new CoffeeDbContext();

		public List<Table> GetTables()
		{
			db = new CoffeeDbContext();
			return db.Tables.ToList();
		}
	}
}
