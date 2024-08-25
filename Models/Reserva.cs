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

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Console.WriteLine("Hóspedes cadastrados com sucesso!");
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade máxima de hóspedes excedida.");
            }
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
            decimal valor = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                valor = valor * 0.9m;
                return valor;
            }
            else if(DiasReservados <= 0)
            {
                throw new Exception("A quantidade de dias reservados deve ser maior que zero.");
            }
            else
            {
                return valor;
            }
        }
    }
}