using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CoffeeManagement.BO;
using CoffeeManagement.DTOs;
using CoffeeManagement.Utilities;

namespace CoffeeManagement.Views.Popups
{
	public partial class ImportItemsFromFile : Form
	{
		private List<Item> _itemsSource = new List<Item>();
		private Indicator _indicator = new Indicator();
		public ImportItemsFromFile()
		{
			InitializeComponent();
			_backgroundWorker.DoWork += OnDoWork;
			_backgroundWorker.RunWorkerCompleted += OnRunWorkerCompleted;
		}

		private void _btnBrowse_Click(object sender, EventArgs e)
		{
			if (_openFileDialog.ShowDialog() == DialogResult.OK)
			{
				_tbFilePath.Text = string.Join("; ", _openFileDialog.FileNames);
				_backgroundWorker.RunWorkerAsync();
				_indicator.ShowDialog();
			}
		}

		private void OnRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			_indicator.Close(); 
			_gvItems.DataSource = _itemsSource.Select(x => new { ItemName = x.Name, UnitName = x.Unit.Name, x.OriginalPrice, x.SalingPrice }).ToList();
			UpdateDataGridViewColumnNames();
			_lbTotal.Text = _itemsSource.Count + " " + Properties.Resources.Item;
		}

		private void OnDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			ImportFromFiles(_openFileDialog.FileNames);
		}

		private void ImportFromFiles(string[] filePaths)
		{
			UnitBo unitBo = new UnitBo();
			foreach (string filePath in filePaths)
			{
				ExcelHelper.LoadFile(filePath);
				int i = 2;
				foreach (var line in ExcelHelper.ReadLine(i))
				{
					try
					{
						var item = new Item
						{
							Name = line[0].ToString(),
							Unit = new Unit{Name = line[1].ToString()},
							OriginalPrice = Convert.ToInt32(line[2].ToString()),
							SalingPrice = Convert.ToInt32(line[3].ToString())
						};
						_itemsSource.Add(item);
					}
					catch (Exception ex)
					{
						MessageHelper.CreateErrorMessage("Lỗi định dạng ở số không đúng tại dòng " + i);
					}
					i++;
				}
			}
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

		private void _btnImport_Click(object sender, EventArgs e)
		{
			_backgroundWorker = new BackgroundWorker();
			_backgroundWorker.DoWork += OnImportBackgroundWork;
			_backgroundWorker.RunWorkerCompleted += OnImportCompleted;

			_backgroundWorker.RunWorkerAsync();
			_indicator.ShowDialog();
		}

		private void OnImportCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			_indicator.Close();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void OnImportBackgroundWork(object sender, DoWorkEventArgs e)
		{
			var itemBo = new ItemBo();
			itemBo.AddRange(_itemsSource);
		}
	}
}
