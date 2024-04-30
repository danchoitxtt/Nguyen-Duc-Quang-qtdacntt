using CoffeeManagement.BO;
using CoffeeManagement.Utilities;
using CoffeeManagement.Views.Popups;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using CoffeeManagement.Properties;

namespace CoffeeManagement.Views
{
	public partial class Login : Form
	{
		private bool _isAuthorized;
		private Indicator _indicator = new Indicator();
		public Login()
		{
			InitializeComponent();
			_lbAppName.Text = Resources.AppName;

			_backgroundWorker.DoWork += DoLogin;
			_backgroundWorker.RunWorkerCompleted += OnLoginCompleled;
		}

		private void OnLoginCompleled(object sender, RunWorkerCompletedEventArgs e)
		{
			_indicator.Close();
			if (_isAuthorized)
			{
				MasterView masterView = new MasterView(this);
				masterView.Show();
			}
		}

		private void DoLogin(object sender, DoWorkEventArgs e)
		{
			if (IsInputValid())
			{
				var userBo = new UserBo();

				if (userBo.CheckLogin(_tbUsername.Text, _tbPassword.Text))
				{
					_isAuthorized = true;
				}
				else
				{
					MessageHelper.CreateErrorMessage(Resources.LoginError);
				}
			}
			else
			{
				MessageHelper.CreateErrorMessage(Resources.FieldsAreRequired);
			}
		}

		private void Login_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void _btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void _btnLogin_Click(object sender, EventArgs e)
		{
			_backgroundWorker.RunWorkerAsync();
			_indicator.ShowDialog();
		}

		private bool IsInputValid()
		{
			return ! (string.IsNullOrEmpty(_tbUsername.Text) || string.IsNullOrEmpty(_tbPassword.Text));
		}


		public void ClearText()
		{
			_tbPassword.Text = "";
		}

		private void Login_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnLogin.PerformClick();
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			_lbAppName.Text = Resources.AppName.ToUpper();
		}

		private void _btnLogin_VisibleChanged(object sender, EventArgs e)
		{
			if (Visible = true)
			{
				_isAuthorized = false;
			}
		}

	}
}
