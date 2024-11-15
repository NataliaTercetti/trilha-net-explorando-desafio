namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        // Cadastrar os hóspedes
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade é maior ou igual ao número de hóspedes
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new InvalidOperationException("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        // Cadastrar a suíte
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        // Obter a quantidade de hóspedes
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        // Calcular o valor da diária com possível desconto
        public decimal CalcularValorDiaria()
        {
            // Calcular o valor base da diária
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Se a reserva for maior ou igual a 10 dias, aplicar 10% de desconto
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m; // Aplicar desconto de 10%
            }

            return valor;
        }
    }
}
