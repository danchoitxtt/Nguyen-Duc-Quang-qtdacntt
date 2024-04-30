using CoffeeManagement.DAO;
using CoffeeManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CoffeeManagement.BO
{
	public class BillBo
	{
		private BillDao _billDao = new BillDao();
		internal void SaveBill(Bill bill)
		{
			_billDao.Add(bill);
		}

		internal List<Bill> GetAll()
		{
			return _billDao.GetAll();
		}

		internal List<Bill> GetBills(int userId, DateTime date)
		{			
			var bills = _billDao.GetAll().Where(b => b.CurrentUser.Id == userId && b.CreatedDateTime.Date == date.Date).ToList();
			return bills.ToList();
		}

		internal List<Bill> GetBills(DateTime fromDate, DateTime toDate)
		{
			var bills = _billDao.GetAll().Where(b => b.CreatedDateTime.Date >= fromDate.Date && b.CreatedDateTime.Date <= toDate.Date).ToList();
			return bills.ToList();
		}
	}
}
