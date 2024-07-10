using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoRengifo.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.ViewModels.Zona
{
    public partial class BaseZoneViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Models.Zona? _zona;
    }
}
