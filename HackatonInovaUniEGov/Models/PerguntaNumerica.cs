namespace HackatonInovaUniEGov.Models;

public class PerguntaNumerica
{
    public int Id { get; set; }
    public string Questao { get; set; }
    public int Nota { get; set; }
    public int QuestionarioId { get; set; }
    public Questionario Questionario { get; set; }
}