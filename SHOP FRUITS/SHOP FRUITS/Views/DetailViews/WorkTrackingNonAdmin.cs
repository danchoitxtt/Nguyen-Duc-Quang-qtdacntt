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
	public partial class WorkTrackingNonAdmin : UserControl, IDetailView
	{
		private UserBo _userBo = new UserBo();
		private List<User> _users = new List<User>();
		private ShiftBo _shiftBo = new ShiftBo();
		private List<Shift> _shifts = new List<Shift>();

		private Shift _currentShift;
		public WorkTrackingNonAdmin()
		{
			InitializeComponent();
			_lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			_backgroundUserLoadder.RunWorkerAsync();
		}

		private void _backgroundUserLoadder_DoWork(object sender, DoWorkEventArgs e)
		{
			_users = _userBo.GetAll().Where(u => u.Level != Utilities.AppEnum.UserLevel.Admin).ToList();
			_shifts = _shiftBo.GetShifts(DateTime.Now);
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
				var shift = _shifts.FirstOrDefault(s => s.UserId == selectedUser.Id);
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
			_shifts = _shiftBo.GetShifts(DateTime.Now);
		}

		public string ScreenName
		{
			get { return "Chấm công"; }
		}
	}
}
