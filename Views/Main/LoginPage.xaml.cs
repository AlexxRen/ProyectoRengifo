using ProyectoRengifo.ViewModels.Logics;
using Microsoft.Maui.Controls;

namespace ProyectoRengifo.Views.Main;

public partial class LoginPage : ContentPage
{
    private LoginPageViewModel _viewModel;

    public LoginPage(LoginPageViewModel loginPageViewModel)
    {
        InitializeComponent();
        BindingContext = loginPageViewModel;

        _viewModel = loginPageViewModel;
        _viewModel.PropertyChanged += ViewModel_PropertyChanged;
    }

    // Nuevo m�todo para manejar la navegaci�n
    private async void OnLoginSuccess()
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Suscribirse al evento PropertyChanged del ViewModel
        _viewModel.PropertyChanged += ViewModel_PropertyChanged;
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        // Desuscribirse del evento al salir de la p�gina
        _viewModel.PropertyChanged -= ViewModel_PropertyChanged;
    }

    private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        // Verificar si la propiedad que cambi� es IsBusy
        if (e.PropertyName == nameof(_viewModel.IsBusy) && !_viewModel.IsBusy)
        {
            // Si IsBusy es falso (el inicio de sesi�n termin�) y fue exitoso, navegar
            if (_viewModel.LoginSuccess)
            {
                OnLoginSuccess();
            }
        }
    }
}
