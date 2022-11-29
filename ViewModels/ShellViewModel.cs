using ATMApp.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
		private int _username;
		private string _password;
		private UserModel _selectedUser;
		private BindableCollection<UserModel> _users = new BindableCollection<UserModel>();

		public ShellViewModel()
		{
			Users.Add(new UserModel { username = "admin", password = "password" });
			Users.Add(new UserModel { username = "latti", password = "test123" });
		}

		public int Username
		{
			get 
			{ 
				return _username; 
			}
			set 
			{ 
				_username = value; 
				NotifyOfPropertyChange(() => Username);
			}
		}

		public string Password
		{
			get 
			{ 
				return _password; 
			}
			set 
			{ 
				_password = value; 
				NotifyOfPropertyChange(() => Password);
			}
		}

		public BindableCollection<UserModel> Users
		{
			get { return _users; }
			set { _users = value; }
		}

		public UserModel SelectedUser
		{
			get { return _selectedUser; }
			set 
			{ 
				_selectedUser = value; 
				NotifyOfPropertyChange(() => SelectedUser);
			}
		}

		//public bool CanLogin(string username, string password) => 
		//	!String.IsNullOrWhiteSpace(username) || !String.IsNullOrWhiteSpace(password);

		public void LoadLoggedIn()
		{
			ActivateItem(new LoggedInViewModel());
		}
		
		public void LoadDeposit()
		{
			ActivateItem(new DepositViewModel());
		}

		public void LoadWithdraw()
		{
			ActivateItem(new WithdrawViewModel());
		}
	}
}
