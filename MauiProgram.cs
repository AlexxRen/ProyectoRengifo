using Microsoft.Extensions.Logging;
using ProyectoRengifo.ViewModels.Agente;
using ProyectoRengifo.ViewModels.Camara;
using ProyectoRengifo.ViewModels.Logics;
using ProyectoRengifo.ViewModels.Persona;
using ProyectoRengifo.ViewModels.Rol;
using ProyectoRengifo.ViewModels.Siniestro;
using ProyectoRengifo.ViewModels.Zona;
using ProyectoRengifo.Views.Agente;
using ProyectoRengifo.Views.Camara;
using ProyectoRengifo.Views.Main;
using ProyectoRengifo.Views.Persona;
using ProyectoRengifo.Views.Role;
using ProyectoRengifo.Views.Siniestro;
using ProyectoRengifo.Views.Zona;


namespace ProyectoRengifo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FAsomeSolid.otf", "AwesomeSolid");
                });
            /*carga paginas-funcionalidad*/
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<ContactPage>();
            builder.Services.AddSingleton<AboutPage>();
            /*carga paginas-vista-persona*/
            builder.Services.AddSingleton<PersonaViewModel>();
            builder.Services.AddSingleton<AddPersonsaPage>();
            /*carga paginas-vista-roles*/
            builder.Services.AddSingleton<RolViewModel>();
            builder.Services.AddSingleton<AddRolePage>();
            /*carga paginas-vista-zona*/
            builder.Services.AddSingleton<ZonaViewModel>();
            builder.Services.AddSingleton<AddZonaPage>();
            /*carga paginas-vista-camaras-ecu911*/
            builder.Services.AddSingleton<CamaraViewModel>();
            builder.Services.AddSingleton<AddCamaraPage>();
            /*carga paginas-vista-agente*/
            builder.Services.AddSingleton<AgenteViewModel>();
            builder.Services.AddSingleton<AddAgentePage>();
            /*carga paginas-vista-siniestro*/
            builder.Services.AddSingleton<SiniestroViewModel>();
            builder.Services.AddSingleton<AddSiniestroPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
