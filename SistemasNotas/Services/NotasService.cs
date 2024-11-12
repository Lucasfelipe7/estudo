using SistemasNotas.Entities;

namespace SistemasNotas.Services;

public class NotasService
{
    public Aluno CalcularConceito(Aluno aluno)
    {
        var conceito = string.Empty;
        foreach (var materia in aluno.Materias)
        {
            Console.WriteLine(materia);
            var media = materia.Notas.Average();
            Console.WriteLine(media);
            switch (media)
            {
                case <= 10 and >= 9 :
                    materia.Conceito = "A";
                    break;
                case < 9 and >= 8 :
                    materia.Conceito = "B";
                    break;
            }
        }
        return aluno;
    }
    
}