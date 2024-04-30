using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.Utilities;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.Views.Popups
{
	public partial class JoinTable : Form
	{
		Bill _currentBill;
		List<Table> _occupiedTables;
		List<Bill> _temptBills;

		public JoinTable(Bill currentBill, List<Table> tables, List<Bill> temptBills)
		{
			InitializeComponent();

			_currentBill = currentBill;
			_temptBills = temptBills;

			_occupiedTables = tables.Where(t => t.IsOccupied && !currentBill.Tables.Any(x => x.Id == t.Id)).ToList();

			InitUIValues();
		}

		private void InitUIValues()
		{
			if (_currentBill.Tables.Count > 0)
			{
				_tbOldTable.Text = StringHelper.JoinList(";", _currentBill.Tables.Select(t => t.Name).ToList());
			}
						
			// Danh sách bàn có thể ghép
			// TODO: bỏ bàn chứa trong bill hiện tại
			_cbNewTable.DataSource = _occupiedTables.Select(t => t.Name).ToList();
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Close();
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			if (MessageHelper.CreateYesNoQuestion("Xác nhận gộp bàn?") == DialogResult.Yes)
			{
				var fromTable = _occupiedTables[_cbNewTable.SelectedIndex];

				// get the bill to merge from
				var fromBill = _temptBills.FirstOrDefault(b => b.Tables.Any(t => t.Id == fromTable.Id));

				// merge to current bill

				foreach (Item i in fromBill.Items) {
					_currentBill.Items.Add(i);
				}

				foreach (Table t in fromBill.Tables) {
					_currentBill.Tables.Add(t);
				}

				_currentBill.PreTotal += fromBill.PreTotal;

				_temptBills.Remove(fromBill);
				
				fromTable.IsOccupied = false;

				DialogResult = System.Windows.Forms.DialogResult.OK;
				Close();
			}
		}

		private void JoinTable_Load(object sender, EventArgs e)
		{

		}
	}
}
