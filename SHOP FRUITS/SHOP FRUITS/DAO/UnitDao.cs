using System.Collections.Generic;
using System.Linq;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.DAO
{
	public class UnitDao
	{
		private CoffeeDbContext _dbContext;

		public UnitDao()
		{
			_dbContext = new CoffeeDbContext();
		}

		public List<Unit> GetAll()
		{
			return _dbContext.Units.ToList();
		}

		public Unit GetUnit(int id)
		{
			return _dbContext.Units.FirstOrDefault(u => u.Id == id);
		}

		public Unit Add(Unit unit)
		{
			_dbContext.Units.Add(unit);
			_dbContext.SaveChanges();
			return unit;
		}

		public void DeleteUnit(int id)
		{
			_dbContext.Units.Remove(GetUnit(id));
			_dbContext.SaveChanges();
		}
	}
}
