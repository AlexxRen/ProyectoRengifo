using ProyectoRengifo.Service.ServiciosMain;
using ProyectoRengifo.Views.Main;
using ProyectoRengifo.UsserControl;
using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoRengifo;
using Newtonsoft.Json;
using ProyectoRengifo.Models.Mod_Logic;
using System.Diagnostics;

namespace ProyectoRengifo.ViewModels.Logics
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string? _userName;
        [ObservableProperty]
        private string? _password;
        [ObservableProperty]
        private bool _loginSuccess = false;
        [ObservableProperty]
        private bool isBusy;

        readonly ILogin InterfaceLogin = new LoginService();

        public Command LoginCommand { get; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () => await LoginAsync());
        }
        //login check
        public async Task LoginAsync()
        {
            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                IsBusy = true; 
                UserFZT userFZT = await InterfaceLogin.Login(UserName, Password);

                if (userFZT != null)
                {
                    LoginSuccess = true; 
                }
                string userDetails = JsonConvert.SerializeObject(userFZT);
                Preferences.Set(nameof(App.fZT), userDetails);
                App.fZT = userFZT;

                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");

                IsBusy = false; 
            }
        }

    }

}