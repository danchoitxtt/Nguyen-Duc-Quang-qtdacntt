using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeManagement.Views.CustomControls
{
	public partial class SearchBox : UserControl
	{
		public EventHandler SearchClicked;
		public EventHandler ClearClicked;
		public EventHandler SearchContentChanged;

		public string SearchContent
		{ 
			get { return SearchTextBox.Text; }
			set { SearchTextBox.Text = value; }
		}
		public SearchBox()
		{
			InitializeComponent();
		}

		private void SearchButton_MouseDown(object sender, MouseEventArgs e)
		{
			SearchButton.BackColor = Color.Gainsboro;
		}

		private void SearchButton_MouseUp(object sender, MouseEventArgs e)
		{
			SearchButton.BackColor = Color.White;
		}

		private void SearchButton_MouseHover(object sender, EventArgs e)
		{
			SearchButton.BackColor = Color.WhiteSmoke;
		}

		private void SearchButton_MouseLeave(object sender, EventArgs e)
		{
			SearchButton.BackColor = Color.White;
		}

		private void ClearButton_MouseHover(object sender, EventArgs e)
		{
			ClearButton.BackColor = Color.WhiteSmoke;
		}

		private void ClearButton_MouseLeave(object sender, EventArgs e)
		{
			ClearButton.BackColor = Color.White;
		}

		private void ClearButton_MouseDown(object sender, MouseEventArgs e)
		{
			ClearButton.BackColor = Color.Gainsboro;
		}

		private void ClearButton_MouseUp(object sender, MouseEventArgs e)
		{
			ClearButton.BackColor = Color.White;
		}

		private void SearchTextBox_TextChanged(object sender, EventArgs e)
		{
			ClearButton.Visible = SearchTextBox.Text.Length > 0;
			if (SearchContentChanged != null)
			{
				SearchContentChanged(this, EventArgs.Empty);
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			if (SearchClicked != null)
			{
				SearchClicked(this, EventArgs.Empty);	
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			if (ClearClicked != null)
			{
				ClearClicked(this, EventArgs.Empty);
			}
			SearchContent = string.Empty;
		}
	}
}
