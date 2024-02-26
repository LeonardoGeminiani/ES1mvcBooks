#nullable disable

namespace ES1.Models;

public class Reparto
{
    public int RepartoId { get; set; }
    public string Descrizione { get; set; }
    public string Piano { get; set; }
    public int NumeroLetti { get; set; }
    public string Primario { get; set; }

    public virtual ICollection<Paziente> Pazienti {get; set;}
}
