using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoRengifo.Models;

public partial class CamaraEcu911 : INotifyPropertyChanged
{
    /*eventos*/
    public event PropertyChangedEventHandler? PropertyChanged;
    /*datos*/
    [PrimaryKey,AutoIncrement]public int IdCamara { get; set; }

    [ForeignKey("Zona")]public string IdZona { get; set; } = null!;

    public virtual Zona Zona { get; set; } = null!;

    
}
