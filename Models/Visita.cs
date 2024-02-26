#nullable disable

namespace ES1.Models;

public class Visita
{
    public int VisitaId { get; set; }
    public DateTime Data { get; set; }
    public TimeOnly Ora { get; set; }
    public string Descrizione { get; set; }
    public string StatoSalute { get; set; }
    public int PressioneMinima { get; set; }
    public int PressioneMassima { get; set; }
    public float Temperatura { get; set; }
    public int FrequenzaCardiaca { get; set; }

    public int MedicoId {get; set;}
    public Medico Medico {get; set;}
    public string CF {get; set;}
    public Paziente Paziente {get; set;}
}