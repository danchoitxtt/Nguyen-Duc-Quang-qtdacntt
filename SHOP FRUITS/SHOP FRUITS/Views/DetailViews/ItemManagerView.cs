using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CoffeeManagement.BO;
using CoffeeManagement.DTOs;
using CoffeeManagement.Utilities;
using CoffeeManagement.Views.Popups;

namespace CoffeeManagement.Views.DetailViews
{
	public partial class ItemManagerView : UserControl, IDetailView
	{
		private ItemBo _itemBo = new ItemBo();
		private List<Item> _itemsSource = new List<Item>();
		private Indicator _indiator = new Indicator();
		public ItemManagerView()
		{
			InitializeComponent();
		}

		public string ScreenName
		{
			get { return Properties.Resources.ItemManagerView; }
		}


		private void ItemManagerView_Load(object sender, System.EventArgs e)
		{
			_reloadDataBackgroundWorker.DoWork += OnLoadInReloadDataBackground;
			_reloadDataBackgroundWorker.RunWorkerCompleted += OnLoadCompleted;

			_reloadDataBackgroundWorker.RunWorkerAsync();
			_indiator.ShowDialog();
		}

		private void OnLoadInReloadDataBackground(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			ReloadData();
		}

		private void OnLoadCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			_indiator.Close();
			_gvItems.DataSource = _itemsSource.Select(x => new { ItemName = x.Name, UnitName = x.Unit.Name, x.OriginalPrice, x.SalingPrice }).ToList();
			UpdateDataGridViewColumnNames();
		}

		private void _btnImport_Click(object sender, System.EventArgs e)
		{
			if (MasterView.Instance.ShowPopup(new ImportItemsFromFile()) == DialogResult.OK)
			{
				_reloadDataBackgroundWorker.RunWorkerAsync();
			}
		}

		private void ReloadData()
		{
			_itemsSource = _itemBo.GetAll();
		}

		private void UpdateDataGridViewColumnNames()
		{
			try
			{
				_gvItems.Columns["ItemName"].HeaderText = Properties.Resources.ItemName;
				_gvItems.Columns["UnitName"].HeaderText = Properties.Resources.UnitName;
				_gvItems.Columns["OriginalPrice"].HeaderText = Properties.Resources.OriginalPrice;
				_gvItems.Columns["SalingPrice"].HeaderText = Properties.Resources.SalingPrice;
			}
			catch
			{
				// ignored
			}
		}

		private void ItemManagerView_Leave(object sender, System.EventArgs e)
		{
			ExcelHelper.CleanAndClose();
		}

		private void _btnDelete_Click(object sender, System.EventArgs e)
		{
			Item selectedItem;
			if ((selectedItem = GetSelectedItem()) != null)
			{
				if (MessageHelper.CreateYesNoQuestion("Xóa '" + selectedItem.Name + "' ?") == DialogResult.Yes)
				{
					_itemBo.DeleteItem(selectedItem.Id);
					_reloadDataBackgroundWorker.RunWorkerAsync();
				}
			}
		}

		private Item GetSelectedItem()
		{
			Item item = null;
			try
			{
				item = _itemsSource[_gvItems.CurrentRow.Index];
			}
			catch { }

			return item;
		}

		private void _gvItems_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void _btnEdit_Click(object sender, System.EventArgs e)
		{
			if (MasterView.Instance.ShowPopup(new ProcessItem(GetSelectedItem())) == DialogResult.OK)
			{
				_reloadDataBackgroundWorker.RunWorkerAsync();
			}
		}
		private void _btnAdd_Click(object sender, System.EventArgs e)
		{
			if (MasterView.Instance.ShowPopup(new ProcessItem()) == DialogResult.OK)
			{
				_reloadDataBackgroundWorker.RunWorkerAsync();
			}
		}
	}
}
