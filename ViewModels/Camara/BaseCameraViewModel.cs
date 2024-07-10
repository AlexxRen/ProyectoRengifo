using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoRengifo.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.ViewModels.Camara
{
    public partial class BaseCameraViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Models.CamaraEcu911 ?_camara;
    }
}
