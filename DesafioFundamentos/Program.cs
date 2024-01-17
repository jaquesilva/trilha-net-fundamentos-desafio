using DesafioFundamentos.Models; 

// Coloca o encoding para UTF8 para exibir acentuação (PESQUISAR)
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0; 
decimal precoPorHora = 0; 
string nome = "";
string cpf = "";
string telefone = "";

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + 
                  "Digite o preço inicial:"); 

precoInicial = Convert.ToDecimal(Console.ReadLine()); 

Console.WriteLine("Agora digite o preço por hora:"); 

precoPorHora = Convert.ToDecimal(Console.ReadLine()); 

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
Pessoa pessoa = new Pessoa(nome, cpf, telefone);

// string opcao = string.Empty; 
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear(); 
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar usuário");
    Console.WriteLine("2 - Cadastrar veículo");
    Console.WriteLine("3 - Remover veículo");
    Console.WriteLine("4 - Listar veículos");
    Console.WriteLine("5 - Realizar pagamento");
    Console.WriteLine("6 - Encerrar");

    switch (Console.ReadLine()) 
    {
        case "1": 
            pessoa.CriarPessoa(); 
            break;
        
        case "2": 
            es.AdicionarVeiculo(); 
            break; 

        case "3": 
            es.RemoverVeiculo(); 
            break; 

        case "4":
            es.ListarVeiculos(); 
            break; 
        
        case "5":
            es.RealizarPagamento(); 
            break; 

        case "6": 
            exibirMenu = false; 
            break;

        default:
            Console.WriteLine("Opção inválida"); 
            break; 
    }

    Console.WriteLine("Pressione uma tecla para continuar"); 
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
