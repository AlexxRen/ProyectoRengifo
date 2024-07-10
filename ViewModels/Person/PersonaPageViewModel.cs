using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using ProyectoRengifo.Views.Persona;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoRengifo.Models;

namespace ProyectoRengifo.ViewModels.Person
{
    public partial class PersonaPageViewModel : BasePersonsaViewModel
    {
        public ObservableCollection<ProyectoRengifo.Models.Persona> PersonaList { get; }

        public PersonaPageViewModel(INavigation navigation)
        {
            PersonaList = new ObservableCollection<ProyectoRengifo.Models.Persona>();
            Navigation = navigation;
        }

        [RelayCommand]
        private async void OnAddPersona()
        {
            await Shell.Current.GoToAsync(nameof(AddPersonsaPage));
        }

        [RelayCommand]
        public void OnAppearing()
        {
            base.isbusy = true;
        }

        [RelayCommand]
        private async Task LoadPersona()
        {
            base.Isbusy = true;

            try
            {
                PersonaList.Clear();
                var prodList = await App.PersonaService.GetPersonaAsync();
                foreach (var item in prodList)
                {
                    PersonaList.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading products: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", "No hemos podido agregar a la persona :c", "OK");
            }
            finally
            {
                base.isbusy = false;
            }
        }

        [RelayCommand]
        private async void PersonaTappedDelete(ProyectoRengifo.Models.Persona persona)
        {
            if (persona == null)
                return;

            await App.PersonaService.DeLetePersonaAsync(persona.IdPersona);
            await LoadPersona();
            OnAppearing();
        }

        [RelayCommand]
        private async void PersonaTappedEdit(ProyectoRengifo.Models.Persona persona)
        {
            if (persona == null)
                return;
            var addPersonaPage = new AddPersonsaPage();
            addPersonaPage.BindingContext = new AddPersonaViewModel(persona);
            await Navigation.PushAsync(addPersonaPage);
        }
    }
}
