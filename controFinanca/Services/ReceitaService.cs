using controFinanca.Data.Models;

namespace controFinanca.Services;

public class ReceitaService
{

    public List<Receita> GetReceitas(int skip, int take)
    {
        var receitas = new List<Receita>();
        var receita = new Receita();
        receita.Id = 1;
        receita.valor = 5000;
        receita.Categoria = "Creche";

        receitas.Add(receita);
        return receitas;
    }
}
