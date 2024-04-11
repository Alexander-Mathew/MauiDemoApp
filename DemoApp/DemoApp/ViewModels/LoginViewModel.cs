using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoApp.Views;

namespace DemoApp.ViewModels
{
	public partial class LoginViewModel : ViewModelBase
	{
		public LoginViewModel()
		{
		}

		[ObservableProperty]
		string userName;

        [ObservableProperty]
        string password;

        [ObservableProperty]
        bool isTermsChecked;

        [RelayCommand]
        async void Login()
        {
            await Shell.Current.GoToAsync(nameof(HomeView));
        }
    }
}

