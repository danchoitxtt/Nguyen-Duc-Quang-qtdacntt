using System.Linq;
using CoffeeManagement.DAO;
using System.Collections.Generic;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.BO
{
	public class UnitBo
	{
		private UnitDao _unitDao;

		public UnitBo()
		{
			_unitDao = new UnitDao();
		}

		public bool CheckExist(string unitName)
		{
			var test = _unitDao.GetAll();
			var test2 = _unitDao.GetAll().Any(u => u.Name.ToLower().Equals(unitName.ToLower()));
			return _unitDao.GetAll().Any(u => u.Name.ToLower().Equals(unitName.ToLower()));
		}

		public List<Unit> GetAll()
		{
			return _unitDao.GetAll();
		}

		public Unit GetUnit(int id)
		{
			return _unitDao.GetUnit(id);
		}

		public Unit Add(Unit unit)
		{
			return _unitDao.Add(unit);
		}

		public Unit GetUnitByName(string unitName)
		{
			return _unitDao.GetAll().FirstOrDefault(u => u.Name.ToLower().Equals(unitName.ToLower()));
		}
	}
}
