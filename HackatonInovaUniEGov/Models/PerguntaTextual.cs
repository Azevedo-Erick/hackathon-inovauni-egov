namespace HackatonInovaUniEGov.Models;

public class PerguntaTextual
{
    public int Id { get; set; }
    public string Questao { get; set; }
    public string Responsta { get; set; }
    
    public int QuestionarioId { get; set; }
    public Questionario Questionario { get; set; }
}