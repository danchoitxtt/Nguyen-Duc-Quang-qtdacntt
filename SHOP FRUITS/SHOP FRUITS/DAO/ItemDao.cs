using System.Collections.Generic;
using System.Linq;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.DAO
{
	public class ItemDao
	{
		private CoffeeDbContext _dbContext = new CoffeeDbContext();

		public List<Item> GetAll()
		{
			_dbContext = new CoffeeDbContext();
			return _dbContext.Items.ToList();
		}

		public Item GetItem(int id)
		{
			return _dbContext.Items.FirstOrDefault(i => i.Id == id);
		}

		public void Add(Item item)
		{
			_dbContext.Items.Add(item);
			_dbContext.SaveChanges();
			//return item;
		}

		public void AddRange(List<Item> items)
		{
			_dbContext.Items.AddRange(items);
			_dbContext.SaveChanges();
		}

		internal void DeleteItem(int id)
		{
			_dbContext.Items.Remove(_dbContext.Items.FirstOrDefault(i => i.Id == id));
			_dbContext.SaveChanges();
		}

		internal void Update(Item item)
		{
			var it = _dbContext.Items.FirstOrDefault(i => i.Id == item.Id);
			it.Name = item.Name;
			it.OriginalPrice = item.OriginalPrice;
			it.SalingPrice = item.SalingPrice;
			it.UnitId = item.UnitId;
			it.IsDeleted = item.IsDeleted;

			_dbContext.SaveChanges();
		}
	}
}
