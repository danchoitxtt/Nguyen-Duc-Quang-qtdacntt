
using CoffeeManagement.DAO;
using CoffeeManagement.DTOs;
using System.Collections.Generic;
namespace CoffeeManagement.BO
{
	public class TableBo
	{
		private TableDao _tbDao = new TableDao();
		public List<Table> GetTables()
		{
			return _tbDao.GetTables();
		}
	}
}
