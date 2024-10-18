namespace Namespace;
public class Filme
{
    public int FilmeId { get; set; }
    public string? Nome { get; set; }
    public int? Nota { get; set; }
    public DateTime CriadoEm { get; set;} = DateTime.Now;

}
