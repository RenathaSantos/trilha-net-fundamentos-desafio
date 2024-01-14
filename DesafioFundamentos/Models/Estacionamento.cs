namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Solicita ao usuario a placa do veiculo, e adiciona na lista de veiculos
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            // Solicita ao usuario a placa do veiculo
            Console.WriteLine("Digite a placa para remover seu veículo: ");
            string placa = Console.ReadLine();

            Boolean validaRemocao = false;
            do{
                // Verifica se o veículo existe, e remove ele da lista
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {

                Console.WriteLine(" Informe a quantidade de horas que o veículo permaneceu estacionado: ");
                
                decimal custoTotal = 0;
                int horasEstacionadas = 0;
                // Converte a hora digitada para int
                horasEstacionadas= Convert.ToInt32(Console.ReadLine());
                // Realiza o cálculo de custo total
                custoTotal = precoInicial + (precoPorHora * horasEstacionadas); 
                // Remove o veículo cuja placa foi digitada
                veiculos.Remove(placa);
                // flag verdadeira para sair do looping
                validaRemocao = true;
                Console.WriteLine($"O veículo {placa} foi removido com sucesso, e o custo total foi de: R$ {custoTotal}");
                }
                else
                {
                // Caso digite a placa errada, ou o veículo não existe no estacionamento
                Console.WriteLine("Desculpe, não existe nenhum carro estacionado com a placa informada");
                Console.WriteLine("Tente digitar a placa do veículo novamente: ");
                placa = Console.ReadLine();
                }
          
            }while(validaRemocao == false);
              
        }
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento, e exibe a lista de veículos estacionados
            if (veiculos.Any())
            {
                Console.WriteLine($"Os veículos estacionados são:{string.Join(", ", veiculos)}");
               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
