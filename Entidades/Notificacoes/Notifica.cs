using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Notificacoes;

public class Notifica
{
    [NotMapped]
    public string NomePropriedade { get; set; }
    
    [NotMapped]
    public string Mensagem { get; set; }

    [NotMapped]
    public List<Notifica> Notificacoes;


    public Notifica()
    {
        Notificacoes=new List<Notifica>();
    }


    public bool ValidarPropriedadeString(string valor, string nomePropriedade)
    {
        if (string.IsNullOrWhiteSpace (valor) || string.IsNullOrWhiteSpace(nomePropriedade))
        {
            Notificacoes.Add(new Notifica
            {
                Mensagem = "Campo obrigatório.",
                NomePropriedade = nomePropriedade
            });
            return false;
        }

        return true;
    }


    public bool ValidarPropriedadeDecimal(decimal valor, string nomePropriedade)
    {
        if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
        {
            Notificacoes.Add(new Notifica
            {
                Mensagem = "Valor deve ser maior que zero.",
                NomePropriedade = nomePropriedade
            });
            return false;
        }

        return true;
    }
}
