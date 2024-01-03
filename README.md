# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

========================================

Em 2021, 13,2 milhões de pessoas trabalhavam como MEIs (Microempreendedores individuais), o que representa 69,7% do total de empresas no Brasil, é um número bastante expressivo.
Fonte: https://encurtador.com.br/dyAV2

Diante desse cenário, faz-se necessário termos um olhar mais atento para esse segmento da economia, que não está inserido com tanta frequência, ao contexto dos avanços que a tecnologia tem proporcionado em todos os setores econômicos.



(VER ONDE ENCAIXAR)
A Família Silva, tem um terreno bem grande, em uma cidade do interior, próximo a um centro de eventos, com várias possibilidades de empreender, mas sem recursos financeiros para colocar as ideias em prática, após muitos anos que o espaço estava apenas crescendo mato, eles tiveram a ideia de fazer daquele lugar, um estacionamento.

Limparam toda a extensão, colocaram britas e demarcaram os pontos para estacionar, registraram o negócio como MEI, tudo parecia estar caminhando conforme o desejado, porém, eles se viram presos a questão de como controlar o fluxo de veículos (entrada e saída) e realizar a cobrança.

Umas das pessoas pertencente a família, teve a ideia de criar um aplicativo que fizesse esse trabalho, integrando o software ao sistema do portão, tornando dessa forma, desnecessário a presença de uma pessoa, tudo poderia ser feito pelo celular, e um membro da família poderia acompanhar tudo de forma remota.

Com essa ideia em mente, o próximo passo, foi pesquisar uma empresa que pudesse realizar esse trabalho, e através da internet e de ótimas indicações de amigos e outras empresas clientes, a família Silva chegou até a Avanade.

Na Avanade, o maior objetivo é impactar genuinamente a vida das pessoas, é fazer o que importa (Do what matters), em parceria com profissionais altamente capacitados para atender as necessidades dos clientes através da tecnologia, juntos fazemos o que importa (Together We do what matters)

Dito isso, o time de experts da Avanade foi contatado para realizar o desenvolvimento do sistema de estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como: Adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

Por de tratar de um MEI, foi solicitado que o método de pagamento inicial foi apenas pix, e que na sequência, conforme o negócio fosse se desenvolvendo e após pesquisar com bastante calma sobre quais bandeiras de cartão seria mais interessante para o empreendimento inicial, então inserir outras formas de pagamento.

Outro requisito essencial, foi a responsividade, pois os clientes irão realizar as transações exclusivamente via celular.






## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
