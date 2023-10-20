namespace HackatonInovaUniEGov.Models;

public class ServicoPublico
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string ImageUrl { get; set; }
    public int PontosPorAvaliar { get; set; }
    public int CategoriaId { get; set; }
    public CategoriaServicoPublico Categoria { get; set; }
    public List<Questionario> Questionarios { get; set; }
}