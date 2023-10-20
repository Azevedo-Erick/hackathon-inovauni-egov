namespace HackatonInovaUniEGov.Models;

public class Questionario
{
    public int Id { get; set; }
    public Usuario Usuario { get; set; }
    public int AvaliacaoMedia { get; set; }
    public DateTime Data { get; set; }
    public int ValorPontos { get; set; }
    public List<RespostaPergunta> RespostasPergunta { get; set; }
    public ServicoPublico ServicoPublico { get; set; }
    public int ServicoPublicoId { get; set; }
}