using CoffeeManagement.BO;
using CoffeeManagement.DTOs;
using CoffeeManagement.DTOs.ViewModels;
using CoffeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.Views.Popups
{
	public partial class EndShiftStatistics : Form
	{
		private BillBo _billBo = new BillBo();
		private List<StatsByItems> _statsByItemsList = new List<StatsByItems>();
		private List<Bill> _bills;

		public EndShiftStatistics()
		{
			InitializeComponent();
		}
		private void EndShiftStatistics_Load(object sender, EventArgs e)
		{
			_lbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy");

			_backgroundBillLoader.RunWorkerAsync();

		}

		private void _btnStats_Click(object sender, EventArgs e)
		{
			GenerateStatsByItems();
			ToggleButtonBackground(_btnStatByItems);
		}

		private void ToggleButtonBackground(Button btn)
		{
			_btnStatByItems.BackColor = Color.Silver;
			_btnStatsByBills.BackColor = Color.Silver;
			btn.BackColor = Color.LightGray;
		}

		private void GenerateStatsByItems()
		{
			_statsByItemsList = new List<StatsByItems>();
			_backgroundStatsByItems.RunWorkerAsync();
		}

		private void loadAllBillBackground_DoWork(object sender, DoWorkEventArgs e)
		{
			_bills = _billBo.GetBills(UserBo.CurrentUser.Id, DateTime.Now);
		}

		private void loadAllBillBackground_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			_lbPreTotal.Text = _bills.Sum(b => b.PreTotal).ToString();
			_lbTotalWithDiscount.Text = _bills.Sum(b => b.Total).ToString();

			ToggleButtonBackground(_btnStatByItems);
			GenerateStatsByItems();
		}

		private void _statsByItemBackground_DoWork(object sender, DoWorkEventArgs e)
		{
			if (_bills != null)
			{
				foreach (Bill b in _bills)
				{
					foreach (Item i in b.Items)
					{
						using (StatsByItems statItem = _statsByItemsList.FirstOrDefault(x => x.Item.Id == i.Id))
						{
							if (statItem != null)
							{
								statItem.Quantity++;
								statItem.Total += (int)(i.SalingPrice * (100 - b.DiscountRate));
							}
							else
							{
								_statsByItemsList.Add(new StatsByItems { Item = i, Quantity = 1, Total = i.SalingPrice });
							}
						}
					}
				}
			}
		}

		private void _statsByItemBackground_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			_gvStats.DataSource = _statsByItemsList.Select(i => new
			{
				ItemName = i.Item.Name,
				Quantity = i.Quantity,
				UnitName = i.Item.Unit.Name,
				UnitPrice = i.Item.SalingPrice,
				Total = i.Total
			}).ToList();

			_gvStats.Columns["ItemName"].HeaderText = "Tên mặt hàng";
			_gvStats.Columns["Quantity"].HeaderText = "Số lượng";
			_gvStats.Columns["UnitName"].HeaderText = "Đơn vị tính";
			_gvStats.Columns["UnitPrice"].HeaderText = "Đơn giá";
			_gvStats.Columns["Total"].HeaderText = "Tổng tiền";
		}

		private void _btnEndShift_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
			Close();
		}

		private void _btnStatsByBills_Click(object sender, EventArgs e)
		{
			ToggleButtonBackground(_btnStatsByBills);
			_gvStats.DataSource = _bills.Select(b => new
			{
				TableNames = StringHelper.JoinList(";", b.Tables.Select(tb => tb.Name).ToList()),
				CreatedTime = b.CreatedDateTime.ToString("hh:mm"),
				PaidTime = b.PaidDateTime.ToString("hh:mm"),
				Discount = b.DiscountRate,
				Total = b.Total
			}).ToList();

			_gvStats.Columns["TableNames"].HeaderText = "Bàn";
			_gvStats.Columns["CreatedTime"].HeaderText = "Thời gian bắt đầu";
			_gvStats.Columns["PaidTime"].HeaderText = "Thời gian kết thúc";
			_gvStats.Columns["Discount"].HeaderText = "Giảm giá (%)";
			_gvStats.Columns["Total"].HeaderText = "Tổng tiền";

		}

	}
}
