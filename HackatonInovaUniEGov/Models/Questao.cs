using System.ComponentModel.DataAnnotations.Schema;
using HackatonInovaUniEGov.Models.Enums;

namespace HackatonInovaUniEGov.Models;

public class Questao
{
    public int Id { get; set; }
    public string Texto { get; set; }
    public CategoriaServicoPublico CategoriaServicoPublico;
    public int CategoriaServicoPublicoId;
    public string slug { get; set; }
    public ETipoPergunta TipoPergunta { get; set; }
    public string TituloParaOPortal { get; set; }
    public bool MostarMediaNoPortal { get; set; }
    public List<RespostaPergunta> RespostasPerguntas { get; set; }
    
    
}