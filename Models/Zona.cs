using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProyectoRengifo.Models;

public partial class Zona : INotifyPropertyChanged
{
    /*eventos*/
    public event PropertyChangedEventHandler? PropertyChanged;
    /*datos*/


    public int IdZona { get; set; }

    public string DescripcionZona { get; set; } = null!;

    public string Ubicacion { get; set; } = null!;

    /*relaciones entre modelos*/
    public virtual ICollection<CamaraEcu911> CamaraEcu911s { get; set; } = new List<CamaraEcu911>();

    public virtual ICollection<Siniestro> Siniestros { get; set; } = new List<Siniestro>();

    
}
