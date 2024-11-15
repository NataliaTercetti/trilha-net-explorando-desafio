namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            if (string.IsNullOrEmpty(tipoSuite))
            {
                throw new ArgumentException("O tipo da suíte não pode ser vazio.", nameof(tipoSuite));
            }

            if (capacidade <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacidade), "A capacidade deve ser maior que zero.");
            }

            if (valorDiaria <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valorDiaria), "O valor da diária deve ser maior que zero.");
            }

            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; }
        public int Capacidade { get; }
        public decimal ValorDiaria { get; }

        public override string ToString()
        {
            return $"{TipoSuite} - {Capacidade} pessoas - R${ValorDiaria:F2} por dia";
        }
    }
}