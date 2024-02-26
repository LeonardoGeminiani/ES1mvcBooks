#nullable disable

namespace ES1.Models;

public class Farmaco
{
    public int FarmacoId { get; set; }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public string PrincipioAttivo { get; set; }
    public int QuantitaScatole { get; set; }
    public DateOnly Scadenza { get; set; }

    public string CF {get; set;}
    public Terapia Terapia {get; set;}

}