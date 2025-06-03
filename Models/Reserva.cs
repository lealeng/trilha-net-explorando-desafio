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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new Exception("Capacidade da suite é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            int quantidadeHospedes = Hospedes.Count;

            if (quantidadeHospedes > 0)
            {
                return quantidadeHospedes;
            }
            else
            {
                throw new Exception("Nenhum hóspede cadastrado.");
            }
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            decimal valor = 0;
            if (Suite != null)
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }
            if (DiasReservados >= 10)
            {
                // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
                valor -= valor * 0.1m; // Aplicando desconto de 10%
            }
            else if (Suite == null)
            {
                throw new Exception("Nenhuma suíte cadastrada.");
            }


            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            return valor;
        }
    }
}