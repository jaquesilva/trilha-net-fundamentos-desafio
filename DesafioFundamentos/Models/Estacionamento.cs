namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0; /* declara e inicializa uma variável PRIVATE do tipo decimal, 
        iniciando com o valor 0. O modificador "private" indica que essa variável só é acessível dentra da classe */
        private decimal precoPorHora = 0; /* declara e inicializa uma variável PRIVATE do tipo decimal, 
        iniciando com o valor 0. O modificador "private" indica que essa variável só é acessível dentra da classe */
        private List<string> veiculos = new List<string>(); /* declara e inicializa uma lista chamada veículos, 
        A lista é do tipo 'List<string>', significa que conterá elementos do tipo 'string'. A lista é 
        inicializada como uma nova instância de 'List<string>(), é uma variável PRIVATE. O modificador "private" 
        indica que essa variável só é acessível dentra da classe */

        // Construtor
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); // valor armazenado como string

            veiculos.Add(placa);

        }

        public void RemoverVeiculo()
        {
            
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            
            // IMPLEMENTADO!!!
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*

                // IMPLEMENTADO!!!
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0; 

                valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                // IMPLEMENTADO!!!
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
                // *IMPLEMENTE AQUI*

                // IMPLEMENTADO
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
    }
}
