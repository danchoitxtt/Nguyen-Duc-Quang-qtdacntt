using CoffeeManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeManagement.DAO
{
	public class ShiftDao
	{
		private CoffeeDbContext _dbContext = new CoffeeDbContext();

		public List<Shift> GetAll()
		{
			_dbContext = new CoffeeDbContext();
			return _dbContext.Shifts.ToList();
		}

		public List<Shift> GetShifts(DateTime date)
		{
			_dbContext = new CoffeeDbContext();
			return _dbContext.Shifts.ToList().Where(s => s.Date.Date.Equals(date.Date)).ToList();
		}

		public Shift Add(Shift shift)
		{
			var shiftToSave = new Shift
			{
				Date = shift.Date,
				UserId = shift.User.Id,
				DidWorkShift1 = shift.DidWorkShift1,
				DidWorkShift2 = shift.DidWorkShift2,
				DidWorkShift3 = shift.DidWorkShift3,
				Note = shift.Note
			};
			_dbContext.Shifts.Add(shiftToSave);
			var result = _dbContext.SaveChanges();
			return result > 0 ? shiftToSave : null;
		}

		public Shift UpdateShift(Shift shift)
		{
			var savedShift = _dbContext.Shifts.FirstOrDefault(s => s.Id == shift.Id);
			if (savedShift != null) {
				savedShift.Note = shift.Note;
				savedShift.DidWorkShift1 = shift.DidWorkShift1;
				savedShift.DidWorkShift2 = shift.DidWorkShift2;
				savedShift.DidWorkShift3 = shift.DidWorkShift3;

				if (_dbContext.SaveChanges() > 0)
				{
					return savedShift;
				}
				else {
					return null;
				}
			}
			else {
				return Add(shift);
			}
		}

		internal Shift GetShift(int userId)
		{
			return _dbContext.Shifts.FirstOrDefault(s => s.User.Id == userId);
		}
	}
}
