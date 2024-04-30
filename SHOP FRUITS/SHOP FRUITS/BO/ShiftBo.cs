using CoffeeManagement.DAO;
using CoffeeManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.BO
{
	public class ShiftBo
	{
		private ShiftDao _shiftDao = new ShiftDao();

		public List<Shift> GetAll()
		{
			return _shiftDao.GetAll();
		}

		public List<Shift> GetShifts(DateTime date)
		{
			return _shiftDao.GetShifts(date);
		}

		public Shift Add(Shift shift)
		{
			return _shiftDao.Add(shift);
		}

		public Shift Update(Shift shift)
		{
			return _shiftDao.UpdateShift(shift);
		}

		internal Shift GetShift(int userId)
		{
			return _shiftDao.GetShift(userId);
		}

		internal List<Shift> GetShift(DateTime dateTime1, DateTime dateTime2, int userId)
		{
			return GetAll().Where(s => s.UserId == userId && s.Date.Date >= dateTime1.Date && s.Date.Date <= dateTime2.Date).ToList();
		}
	}
}
