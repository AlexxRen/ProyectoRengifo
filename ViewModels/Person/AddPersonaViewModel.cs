using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProyectoRengifo.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoRengifo.ViewModels.Person
{
    public partial class AddPersonaViewModel : ObservableObject
    {
        [ObservableProperty]
        private ProyectoRengifo.Models.Persona _persona = new();

        // Propiedades para errores de validación
        [ObservableProperty]
        private string nombreError;

        [ObservableProperty]
        private string cedulaError;

        [ObservableProperty]
        private string fechaNacimientoError;

        [ObservableProperty]
        private bool showNombreError;

        [ObservableProperty]
        private bool showCedulaError;

        [ObservableProperty]
        private bool showFechaNacimientoError;

        // Comandos
        public ICommand SavePersonaCommand { get; }
        public ICommand CancelCommand { get; }

        public AddPersonaViewModel(ProyectoRengifo.Models.Persona persona = null)
        {
            SavePersonaCommand = new AsyncRelayCommand(SavePersonaAsync);
            CancelCommand = new AsyncRelayCommand(CancelAsync);

            if (persona != null)
            {
                _persona.Nombre = persona.Nombre;
                _persona.Cedula = persona.Cedula;
                _persona.FechaNacimiento = persona.FechaNacimiento;
            }
        }


        private async Task SavePersonaAsync()
        {

            if (!ValidatePersona())
                return;

            // Guardar la persona
            await App.PersonaService.AddUpdatePersonaAsync(_persona);
            await Shell.Current.GoToAsync(".."); 
        }

        private bool ValidatePersona()
        {
            // Validación simple (puedes agregar más reglas según sea necesario)
            ShowNombreError = string.IsNullOrEmpty(_persona.Nombre);
            ShowCedulaError = string.IsNullOrEmpty(_persona.Cedula);
            ShowFechaNacimientoError = _persona.FechaNacimiento == default;

            NombreError = ShowNombreError ? "El nombre es obligatorio." : null;
            CedulaError = ShowCedulaError ? "La cédula es obligatoria." : null;
            FechaNacimientoError = ShowFechaNacimientoError ? "La fecha de nacimiento es obligatoria." : null;

            return !ShowNombreError && !ShowCedulaError && !ShowFechaNacimientoError;
        }

        private async Task CancelAsync()
        {
            // Lógica para cancelar (por ejemplo, navegar de regreso)
            await Shell.Current.GoToAsync("..");
        }
    }
}
