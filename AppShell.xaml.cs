using ProyectoRengifo.Views.Main;
using ProyectoRengifo.Views.Persona;
using ProyectoRengifo.Service.ServiciosMain;
using ProyectoRengifo.Views.Agente;
using ProyectoRengifo.Views.Camara;
using ProyectoRengifo.Views.Zona;
using ProyectoRengifo.Views.Role;
using ProyectoRengifo.Views.Siniestro;

namespace ProyectoRengifo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(AddPersonsaPage), typeof(AddPersonsaPage));
            Routing.RegisterRoute(nameof(AddAgentePage), typeof(AddAgentePage));
            Routing.RegisterRoute(nameof(AddCamaraPage), typeof(AddCamaraPage));
            Routing.RegisterRoute(nameof(AddZonaPage), typeof(AddZonaPage));
            Routing.RegisterRoute(nameof(AddSiniestroPage), typeof(AddSiniestroPage));
            Routing.RegisterRoute(nameof(AddRolePage), typeof(AddRolePage));

        }


    }
}
