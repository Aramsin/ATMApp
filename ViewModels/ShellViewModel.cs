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
		private string _username;
		private string _password;
		private UserModel _selectedUser;
		private BindableCollection<UserModel> _users = new BindableCollection<UserModel>();

		public ShellViewModel()
		{
			Users.Add(new UserModel { Username = "admin", Password = "password" });
			Users.Add(new UserModel { Username = "latti", Password = "test123" });
		}

		public string Username
		{
			get 
			{ 
				return _username; 
			}
			set 
			{ 
				_username = value; 
				NotifyOfPropertyChange(() => Username);
                NotifyOfPropertyChange(() => CanLogin);
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
				NotifyOfPropertyChange(() => CanLogin);
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

		public bool CanLogin
		{
			get
			{
				bool output = false;
				// Username? is a not null check
				if (Username?.Length > 0 && Password?.Length > 0)
				{
					output = true;
				}

				return output;
			}
		}

		public void LoadLoggedIn()
		{
			foreach (var user in Users)
			{
				if (user.Username == Username && user.Password == Password)
				{
                    ActivateItem(new LoggedInViewModel());
                }
			}
            
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
