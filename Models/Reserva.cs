namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public readonly int DaysToApplyDiscout = 10;
        public readonly decimal Discout = 0.1M;

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool overLimitRoom = hospedes.Count > Suite.Capacidade;

            if (!overLimitRoom) Hospedes = hospedes;
            else throw new Exception("The number of guests is greater than the suite's capacity ❌");
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            // --- TOTAL PRICE FOR THIS SUITE
            decimal totalValue = DiasReservados * Suite.ValorDiaria;

            // --- DISCOUT ROLE
            if (DiasReservados >= DaysToApplyDiscout)
            {
                totalValue -= totalValue* Discout;
            }

            return totalValue;
        }
    }
}