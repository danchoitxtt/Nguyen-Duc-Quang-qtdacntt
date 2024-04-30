using System.Collections.Generic;
using System.Linq;
using CoffeeManagement.DAO;
using CoffeeManagement.DTOs;
using CoffeeManagement.Utilities;

namespace CoffeeManagement.BO
{
	public class ItemBo
	{
		private ItemDao _itemDao = new ItemDao();
		public List<Item> GetAll()
		{
			return _itemDao.GetAll().Where(i => !i.IsDeleted).ToList();
		}

		public Item GetItem(int id)
		{
			return _itemDao.GetItem(id);
		}

		public void Add(Item item)
		{
			_itemDao.Add(item);
		}

		public bool CheckExist(string itemName)
		{
			return _itemDao.GetAll().Any(x => x.Name.ToLower().Equals(itemName.ToLower()));
		}
		public void AddRange(List<Item> items)
		{
			var unitBo = new UnitBo();
			List<Item> alreadyExistItems = new List<Item>();
			foreach (Item item in items)
			{
				if (!CheckExist(item.Name))
				{
					Unit unit = !unitBo.CheckExist(item.Unit.Name) ? unitBo.Add(item.Unit) : unitBo.GetUnitByName(item.Unit.Name);

					item.Unit = null; // avoid adding 2 Unit into database
					item.UnitId = unit.Id;
					Add(item);
				}
				else
				{
					alreadyExistItems.Add(item);
				}
			}
			if (alreadyExistItems.Count > 0)
			{
				MessageHelper.CreateMessage(string.Join("\n", alreadyExistItems.Select(x => x.Name)) + "\n" + Properties.Resources.AlreadyExist);
			}
		}

		public void DeleteItem(int id)
		{
			_itemDao.DeleteItem(id);
		}

		public void Update(Item item)
		{
			_itemDao.Update(item);
		}
	}
}
