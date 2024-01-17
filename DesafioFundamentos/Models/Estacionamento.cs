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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); 
        

            veiculos.Add(placa); 

        }

        public void RemoverVeiculo()
        {
            
            // TODO: Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) 
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0; 

                valorTotal = precoInicial + (precoPorHora * horas);

                //AQUI EU POSSO IMPLEMENTAR O MÉTODO DE PAGAMENTO

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos() 
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var item in veiculos)
                {
                    Console.WriteLine($"Os veículos estacionados são: {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        // Método desenvolvido com o apoio da minha colega de bootcamp Adriany Correa
        public void RealizarPagamento()
        {
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear(); 
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cartão de crédito");
                Console.WriteLine("2 - Dinheiro");
                Console.WriteLine("3 - Pix");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine()) 
                {
                    case "1": 
                        Console.WriteLine("Método de pagamento ainda não disponível, favor escolher a opção '3 - Pix'"); 
                        break; 

                    case "2": 
                        Console.WriteLine("Método de pagamento ainda não disponível, favor escolher a opção '3 - Pix'"); 
                        break; 

                    case "3":
                        Console.WriteLine("Pagamento realizado com sucesso"); 
                        break; 

                    case "4": 
                        exibirMenu = false; 
                        break;

                    default:
                        Console.WriteLine("Opção inválida"); 
                        break; 
                }

                Console.WriteLine("Pressione uma tecla para continuar"); 
                Console.ReadLine();
            }   
        }
    }
}
