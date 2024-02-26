#nullable disable

namespace ES1.Models;

public class Medico
{
    public int MedicoId { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Specializzazione { get; set; }
    public string Password { get; set; }

}