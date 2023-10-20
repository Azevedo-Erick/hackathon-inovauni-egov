namespace HackatonInovaUniEGov.Models;

public class Questionario
{
    public int Id { get; set; }
    public Usuario Usuario { get; set; }
    public int AvaliacaoMedia { get; set; }
    public DateTime Data { get; set; }
    public int ValorPontos { get; set; }
    public List<PerguntaNumerica> PerguntasNumericas { get; set; }
    public List<PerguntaTextual> PerguntasTextuais { get; set; }
    public ServicoPublico ServicoPublico { get; set; }
}