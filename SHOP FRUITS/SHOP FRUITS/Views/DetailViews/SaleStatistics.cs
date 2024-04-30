using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.BO;
using CoffeeManagement.DTOs.ViewModels;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.Views.DetailViews
{
	public partial class SaleStatistics : UserControl, IDetailView
	{
		private BillBo _billBo = new BillBo();
		List<StatsByItems> _statsItemList = new List<StatsByItems>();
		public SaleStatistics()
		{
			InitializeComponent();
		}
		public string ScreenName
		{
			get { return "Thống kê bán hàng"; }
		}

		private void _btnShow_Click(object sender, EventArgs e)
		{
			_backgroundShowStats.RunWorkerAsync();
		}

		private void _dpickerFrom_ValueChanged(object sender, EventArgs e)
		{
			_dpickerTo.MinDate = _dpickerFrom.Value;
		}

		private void _backgroundShowStats_DoWork(object sender, DoWorkEventArgs e)
		{
			DateTime fromDate = _dpickerFrom.Value;
			DateTime toDate = _dpickerTo.Value;

			List<Bill> bills = _billBo.GetBills(fromDate, toDate);

			if (bills != null)
			{
				foreach (Bill b in bills)
				{
					foreach (Item i in b.Items)
					{
						using (StatsByItems statItem = _statsItemList.FirstOrDefault(x => x.Item.Id == i.Id))
						{
							if (statItem != null)
							{
								statItem.Quantity++;
								statItem.Total += (int)(i.SalingPrice * (100 - b.DiscountRate) / 100.0);
							}
							else
							{
								_statsItemList.Add(new StatsByItems { Item = i, Quantity = 1, Total = i.SalingPrice});
							}
						}
					}
				}
			}
		}

		private void _backgroundShowStats_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			_gvStats.DataSource = _statsItemList.Select(i => new
			{
				ItemName = i.Item.Name,
				Quantity = i.Quantity,
				UnitName = i.Item.Unit.Name,
				UnitPrice = i.Item.SalingPrice,
				UnitOriginPrice = i.Item.OriginalPrice,
				Total = i.Total,
				OriginTotal = i.Item.OriginalPrice * i.Quantity,
				Profits = i.Total - (i.Item.OriginalPrice * i.Quantity)
			}).ToList();


			_gvStats.Columns["ItemName"].HeaderText = "Tên mặt hàng";
			_gvStats.Columns["Quantity"].HeaderText = "Số lượng";
			_gvStats.Columns["UnitName"].HeaderText = "Đơn vị tính";
			_gvStats.Columns["UnitPrice"].HeaderText = "Đơn giá";
			_gvStats.Columns["UnitOriginPrice"].HeaderText = "Đơn giá gốc";
			_gvStats.Columns["Total"].HeaderText = "Tổng tiền";
			_gvStats.Columns["OriginTotal"].HeaderText = "Chi phí";
			_gvStats.Columns["Profits"].HeaderText = "Lợi nhuận";

			var total = _statsItemList.Sum(i => i.Total);
			_lbIncome.Text = total + " VNĐ";
			_lbProfits.Text = (total - _statsItemList.Sum(i => i.Item.OriginalPrice * i.Quantity)) + " VNĐ";
		}

	}
}
