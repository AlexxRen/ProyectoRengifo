using CommunityToolkit.Mvvm.Input;
using ProyectoRengifo.ViewModels.Logics;
using ProyectoRengifo.Views.Main;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosMain
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [RelayCommand]
        async Task SignOutAsync()
        {
            if (Preferences.ContainsKey(nameof(App.PersonaService)))
            {
                Preferences.Remove(nameof(App.PersonaService));
            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
