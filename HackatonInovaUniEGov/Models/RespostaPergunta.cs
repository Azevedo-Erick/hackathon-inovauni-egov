using System.ComponentModel.DataAnnotations.Schema;

namespace HackatonInovaUniEGov.Models;

public class RespostaPergunta
{
    public int Id { get; set; }
    public Questao Questao { get; set; }
    public int QuestaoId { get; set; }
    public int? Nota { get; set; }
    public string? Resposta { get; set; }

    public int QuestionarioId { get; set; }
    public Questionario Questionario { get; set; }
}