using DesafioProjetoHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>(); // Inicializa a lista
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        int capacidadeSuite = Suite.Capacidade; //2
        int quantHospedes = hospedes.Count; // Remove o método Count() e usa a propriedade

        if (quantHospedes > capacidadeSuite) // Corrigido para ">"
        {
            throw new InvalidOperationException("Quantidade de hóspedes é maior que a capacidade permitida da suíte.");
        }
        else
        {
            Hospedes.AddRange(hospedes); // Adiciona os hóspedes à lista
            Console.WriteLine("Hospedes cadastrados com sucesso");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count; // Agora deve funcionar sem erro
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10)
        {
            valor *= 0.90m; // Aplica desconto
        }

        return valor;
    }
}
