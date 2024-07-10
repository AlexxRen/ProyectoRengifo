using ProyectoRengifo.Models;
using ProyectoRengifo.ViewModels.Person;

namespace ProyectoRengifo.Views.Persona;

public partial class AddPersonsaPage : ContentPage
{
    public AddPersonsaPage()
    {
        InitializeComponent();
        this.BindingContext = new AddPersonaViewModel();
    }

    public AddPersonsaPage(AddPersonaViewModel viewModel)
    {
        InitializeComponent();
    }
}
