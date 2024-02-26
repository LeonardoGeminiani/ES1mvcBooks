#nullable disable

namespace ES1.Models;

public class Paziente
{
    public string CF { get; set; } //Codice fiscale (key)
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int DataNascita { get; set; }
    public string LuogoNascita { get; set; }
    public string Patologia { get; set; }
    public string Indirizzo { get; set; }
    public string Cap { get; set; }
    public string Citta { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }

    public virtual ICollection<Visita> Visite {get; set;}
    public virtual ICollection<Terapia> Terapie {get; set;}

    public int RepartoId {get; set;}
    public Reparto reparto {get; set;}
}
