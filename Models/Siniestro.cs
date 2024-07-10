using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoRengifo.Models;

public partial class Siniestro : INotifyPropertyChanged
{
    /*eventos*/
    public event PropertyChangedEventHandler? PropertyChanged;

    /*datos*/
    [PrimaryKey]public int IdSiniestro { get; set; }

    [ForeignKey("Zona")]public int IdZona { get; set; }

    public DateTime FechaSiniestro { get; set; }

    public string NivelUrgencia { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdAgente { get; set; }

    /*relaciones entre modelos*/
    public virtual Agente IdAgenteNavigation { get; set; } = null!;

    public virtual Zona IdZonaNavigation { get; set; } = null!;

    
}
