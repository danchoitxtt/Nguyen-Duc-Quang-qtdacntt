using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CoffeeManagement.BO;
using CoffeeManagement.DTOs;
using CoffeeManagement.Properties;
using CoffeeManagement.Utilities;

namespace CoffeeManagement.Views.Popups
{
	public partial class ProcessItem : Form
	{
		private Item _item;
		List<Unit> _units = new List<Unit>();
		private UnitBo _unitBo = new UnitBo();
		public ProcessItem(Item item = null)
		{
			InitializeComponent();
			_item = item;
		}

		private void ProcessItem_Load(object sender, EventArgs e)
		{
			_units = _unitBo.GetAll();

			_cbUnits.DataSource = _units.Select(u => u.Name).ToList();

			if (_item != null)
			{
				Text = Resources.EditItem;
				_tbName.Text = _item.Name;
				_tbOriginalPrice.Text = _item.OriginalPrice.ToString();
				_tbSalingPrice.Text = _item.SalingPrice.ToString();
				_cbUnits.Text = _item.Unit.Name;
			}
		}

		private void _btnSave_Click(object sender, EventArgs e)
		{
			if (CheckInput())
			{
				var itemBo = new ItemBo();
				int unitId;
				if (!_units.Any(x => x.Name.ToLower().Equals(_cbUnits.Text.ToLower())))
				{
					unitId = _unitBo.Add(new Unit {Name = _cbUnits.Text}).Id;
				}
				else
				{
					unitId = _units[_cbUnits.SelectedIndex].Id;
				}

				var item = new Item
				{
					Name = _tbName.Text,
					UnitId = unitId,
					OriginalPrice = Convert.ToInt32(_tbOriginalPrice.Text),
					SalingPrice = Convert.ToInt32(_tbSalingPrice.Text),
				};

				if (_item != null)
				{
					// save edited item
					item.Id = _item.Id;
					itemBo.Update(item);
				}
				else
				{
					// save created item
					itemBo.Add(item);
				}

				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private bool CheckInput()
		{

			if (string.IsNullOrEmpty(_tbName.Text))
			{
				MessageHelper.CreateErrorMessage("Điền đầy đủ thông tin!");
				return false;
			}

			try
			{
				Convert.ToInt32(_tbOriginalPrice.Text);
				Convert.ToInt32(_tbSalingPrice.Text);
			}
			catch (FormatException)
			{
				MessageHelper.CreateErrorMessage("Nhập sai định dạng số!");
				return false;
			}
			return true;
		}

	}
}
