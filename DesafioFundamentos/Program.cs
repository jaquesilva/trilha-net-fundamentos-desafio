using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0; // variável do tipo decimal que inicia com valor "0"
decimal precoPorHora = 0; // variável do tipo decimal que inicia com valor "0"

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + // Cria o menu inicial
                  "Digite o preço inicial:"); // Solicita uma entrada para o usuário

precoInicial = Convert.ToDecimal(Console.ReadLine()); /* tudo que entra através do Console.WriteLine é string, então devemos 
 converter para int (inteiro)*/

Console.WriteLine("Agora digite o preço por hora:"); // Solicita uma entrada para o usuário

precoPorHora = Convert.ToDecimal(Console.ReadLine()); /* tudo que entra através do Console.WriteLine é string, então devemos 
 converter para int (inteiro)*/

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

/* NÃO ENTENDI QUAL A FUNÇÃO DESSA LINHA a princípio, depois resolvi comentá-la e executar o código novamente, funcionou normalmente,
então acredito que essa linha não tem utilidade no código*/
// string opcao = string.Empty; 
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear(); // Essa linha limpa o console, para aparecer somente esse menu, e não as linhas 9, 10 e 15 juntas
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine()) /* Entrada de um valor, digitado pelo usuário conforme menu acima, linhas 31 a 34, e de acordo 
    com o número digitado, entrará em um respectivo case */
    {
        case "1": // Caso o usuário escolha a opção 1
            es.AdicionarVeiculo(); // Chama o método "AdicionarVeiculo" da classe "Estacionamento"
            break; // Encerra o switch e pula para a linha 60

        case "2": // Caso o usuário escolha a opção 2
            es.RemoverVeiculo(); // Chama o método "RemoverVeiculo" da classe "Estacionamento"
            break; // Encerra o switch e pula para a linha 60

        case "3": // Caso o usuário escolha a opção 3
            es.ListarVeiculos(); // Chama o método "ListarVeiculos" da classe "Estacionamento"
            break; // Encerra o switch e pula para a linha 60

        case "4": // Caso o usuário escolha a opção 4
            exibirMenu = false; // Para de exibir o menu
            break; // Encerra o switch e pula para a linha 60

        default:
            Console.WriteLine("Opção inválida"); // Caso o usuário escolha um número diferente de 1, 2, 3 ou 4, aparecerá essa msg.
            break; // Encerra o switch e pula para a linha 60
    }

    Console.WriteLine("Pressione uma tecla para continuar"); /* Qualquer tecla que o usuário digitar o programa será encerrado e 
    aparecerá a linha 64 */
    Console.ReadLine(); /* Por que o que foi digitado na linha 60 como entrada do usuário não precisou ser convertido aqui na 
    linha 62? Resposta: Acredito que por não usar esse valor para um fim específico, qualquer valor que entrasse, serviria */
}

Console.WriteLine("O programa se encerrou"); // Mensagem indicando que o programa encerrou.
