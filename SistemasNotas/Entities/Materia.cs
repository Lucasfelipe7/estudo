namespace SistemasNotas.Entities;

public class Materia
{
    public string Nome{ get; set; }
    public List<double> Notas { get; set; }
    
    public string? Conceito { get; set; }
}