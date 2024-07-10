using ProyectoRengifo.Models.Mod_Logic;
using ProyectoRengifo.Service.Models;

namespace ProyectoRengifo;

public partial class App : Application
{
    public static UserFZT? fZT;
    private static PersonaService? _perService;

    public static PersonaService PersonaService
    {
        get
        {
            if (_perService == null)
            {
                _perService = new PersonaService(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalDatabase.db3"));
            }
            return _perService;
        }
    }

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}