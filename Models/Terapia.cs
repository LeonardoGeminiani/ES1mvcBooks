#nullable disable

namespace ES1.Models;

public class Terapia
{
    public string CF {get; set;}
    public int FarmacoId {get; set;}
    public DateTime DataInizio { get; set; }
    public DateTime DataFine { get; set; }
    public string Posologia { get; set; }

    public Paziente Paziente {get; set;}
    public Farmaco Farmaco {get; set;}
}