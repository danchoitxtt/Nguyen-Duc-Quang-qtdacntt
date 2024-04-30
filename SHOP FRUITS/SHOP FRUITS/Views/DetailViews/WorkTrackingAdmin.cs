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
using CoffeeManagement.DTOs;

namespace CoffeeManagement.Views.DetailViews
{
	public partial class WorkTrackingAdmin : UserControl
	{
			private UserBo _userBo = new UserBo();
		private List<User> _users = new List<User>();
		private ShiftBo _shiftBo = new ShiftBo();
		private List<Shift> _todayShifts = new List<Shift>();
		private List<Shift> _allShifts = new List<Shift>();

		private Shift _currentShift;

		private List<Shift> _userShifts;
		private User _selectedUser;
		public WorkTrackingAdmin()
		{
			InitializeComponent();
			_lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			_backgroundUserLoadder.RunWorkerAsync();
		}

		private void _backgroundUserLoadder_DoWork(object sender, DoWorkEventArgs e)
		{
			_users = _userBo.GetAll().Where(u => u.Level != Utilities.AppEnum.UserLevel.Admin).ToList();
			_todayShifts = _shiftBo.GetShifts(DateTime.Now);
			_allShifts = _shiftBo.GetAll();
		}

		private void _backgroundUserLoadder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			_listUsers.DataSource = _users.Select(u => u.FullName).ToList();
		}

		private void _listUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedUser = GetSelectedUser();
			if (selectedUser != null)
			{
				var shift = _todayShifts.FirstOrDefault(s => s.UserId == selectedUser.Id);
				if (shift != null)
				{
					_currentShift = shift;
					UpdateUI(shift);
				}
				else
				{
					_currentShift = new Shift()
					{
						User = GetSelectedUser(),
						Date = DateTime.Now,
					};
					UpdateUI(_currentShift);
				}
				_gvShifts.DataSource = null;
				_lbSalary.Text = "";
				_lbWorkCount.Text = "";
			}
		}

		private void UpdateUI(Shift shift)
		{
			_lbUsername.Text = shift.User.FullName;
			_lbUserRole.Text = shift.User.Level.ToString();
			_cb1.Checked = shift.DidWorkShift1;
			_cb2.Checked = shift.DidWorkShift2;
			_cb3.Checked = shift.DidWorkShift3;
			_tbNote.Text = shift.Note;
		}

		private void CalculateSalary()
		{
			if (_userShifts.Count > 0) {
				var workCount = 0;
				foreach (Shift s in _userShifts)
				{
					if (s.DidWorkShift1)
					{
						workCount++;
					}
					if (s.DidWorkShift2)
					{
						workCount++;
					}
					if (s.DidWorkShift3)
					{
						workCount++;
					}
				} 
				
				_lbWorkCount.Text = workCount.ToString();
				_lbSalary.Text = (workCount * 80000).ToString();
			}
		}

		private User GetSelectedUser()
		{
			if (_listUsers.SelectedIndex != -1)
			{
				return _users[_listUsers.SelectedIndex];
			}
			return null;			
		}

		private void _btnSave_Click(object sender, EventArgs e)
		{
			_currentShift.DidWorkShift1 = _cb1.Checked;
			_currentShift.DidWorkShift2 = _cb2.Checked;
			_currentShift.DidWorkShift3 = _cb3.Checked;
			_currentShift.Note = _tbNote.Text;

			_currentShift = _shiftBo.Update(_currentShift);
			if (_currentShift != null)
			{
				UpdateShifts();
			}

		}

		private void UpdateShifts()
		{
			_todayShifts = _shiftBo.GetShifts(DateTime.Now);
		}

		public string ScreenName
		{
			get { return "Chấm công"; }
		}

		private void _dpickerFrom_ValueChanged(object sender, EventArgs e)
		{
			_dpickerTo.MinDate = _dpickerFrom.Value;
		}

		private void _btnStats_Click(object sender, EventArgs e)
		{
			_selectedUser = GetSelectedUser();
			if (_selectedUser != null)
			{
				_backgroundStats.RunWorkerAsync();
			}
			
		}

		private void _backgroundStats_DoWork(object sender, DoWorkEventArgs e)
		{
			_userShifts = _shiftBo.GetShift(_dpickerFrom.Value, _dpickerTo.Value, _selectedUser.Id);
		}

		private void _backgroundStats_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			_gvShifts.DataSource = _userShifts.Select(s => new { Date = s.Date, s.DidWorkShift1, s.DidWorkShift2, s.DidWorkShift3, s.Note }).ToList();

			CalculateSalary();
		}
	}
}
