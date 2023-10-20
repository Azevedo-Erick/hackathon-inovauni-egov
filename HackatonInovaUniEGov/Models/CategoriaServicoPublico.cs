namespace HackatonInovaUniEGov.Models;

public class CategoriaServicoPublico
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<ServicoPublico> ServicosPublicos { get; set; }
    public List<Questao>? Questoes { get; set; }
}