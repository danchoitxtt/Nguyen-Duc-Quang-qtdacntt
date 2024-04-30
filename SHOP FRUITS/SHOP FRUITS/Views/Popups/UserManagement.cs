using CoffeeManagement.BO;
using CoffeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.Views.Popups
{
    public partial class UserManagement : Form
    {
        private UserBo _userBo = new UserBo();
        private BindingSource _bindingSource;
        private List<User> _users;
        public UserManagement()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            _users = _userBo.GetAll();

            _bindingSource.DataSource = _users.Select(u => u.UserName).ToList();
            _listUsers.DataSource = _bindingSource;

            _cbLevel.DataSource = Enum.GetNames(typeof(CoffeeManagement.Utilities.AppEnum.UserLevel));
        }

        private void _listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            var selectedUser = _users[_listUsers.SelectedIndex];
            _tbFullName.Text = selectedUser.FullName;
            _tbUsername.Text = selectedUser.UserName;
            _tbDescription.Text = selectedUser.Description;
            _cbLevel.Text = selectedUser.Level.ToString();
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnSave_Click(object sender, EventArgs e)
        {
            var newUser = _users[_listUsers.SelectedIndex];
            newUser.FullName = _tbFullName.Text;
            newUser.UserName = _tbUsername.Text;
            newUser.Description = _tbDescription.Text;
            newUser.Level = (AppEnum.UserLevel) Enum.Parse(typeof(AppEnum.UserLevel), _cbLevel.Text, true);
            _userBo.Update(newUser);

            Reload();
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageHelper.CreateYesNoQuestion("Xóa tài khoản \"" + _users[_listUsers.SelectedIndex].UserName + "\"?") == System.Windows.Forms.DialogResult.Yes)
            {
                _userBo.Delete(_users[_listUsers.SelectedIndex]);
                Reload();
            }
        }

        private void Reload()
        {
            _users = _userBo.GetAll();
            _bindingSource.DataSource = _users.Select(u => u.UserName).ToList();
            _bindingSource.ResetBindings(true);
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddUser().ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Reload();
            }
        }
    }
}
