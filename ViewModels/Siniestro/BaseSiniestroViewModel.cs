using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoRengifo.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.ViewModels.Siniestro
{
    public partial class BaseSiniestroViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Models.Siniestro ?_siniestro;
    }
}
