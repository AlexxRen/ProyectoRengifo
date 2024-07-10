using ProyectoRengifo.ViewModels;
using ProyectoRengifo.ViewModels.Person;
using ProyectoRengifo.ViewModels.Persona;

namespace ProyectoRengifo.Views.Persona;

public partial class PersonaPage : ContentPage
{
	PersonaPageViewModel viewModel;
    public PersonaPage()
	{
		InitializeComponent();
        //BindingContext = viewModel;
        this.BindingContext = viewModel = new PersonaPageViewModel(Navigation);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing();
    }

}