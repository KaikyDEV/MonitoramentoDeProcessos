#Monitoramento de Processos Suspeitos em C#

Este projeto contém uma aplicação simples em C# que monitora os processos em execução em um sistema e verifica se há processos suspeitos. Ele compara os processos em execução com uma lista predefinida de processos confiáveis e alerta sobre quaisquer processos que não estejam na lista. O objetivo é ajudar a identificar, de forma básica, a presença de software malicioso, como keyloggers, em sistemas Windows.

#Funcionalidade

Monitoramento de Processos: O programa verifica todos os processos em execução no sistema.
Lista de Processos Confiáveis: É possível configurar uma lista de processos considerados confiáveis, como o Windows Explorer, navegadores como Chrome e Firefox, e outros aplicativos do sistema.
Alerta de Processos Suspeitos: O código alerta sobre qualquer processo que não esteja na lista de confiáveis e imprime o nome e o ID do processo.
Monitoramento Contínuo: O programa roda em um loop contínuo para monitorar constantemente os processos em execução.

#Como Funciona

O código usa a classe System.Diagnostics.Process para listar todos os processos em execução no sistema.
O programa compara o nome de cada processo com uma lista de processos confiáveis.
Se encontrar um processo que não esteja na lista de confiáveis, ele é considerado suspeito, e o programa exibe um alerta com o nome e o ID do processo.
O monitoramento pode ser configurado para rodar em intervalos regulares, permitindo uma verificação contínua dos processos.

#Pré-requisitos

.NET Framework ou .NET Core/5+: Este código é compatível com versões do C# que suportam a biblioteca System.Diagnostics, que é parte do .NET.
Sistema Operacional: Windows (pode ser adaptado para outras plataformas com algumas modificações).
Visual Studio ou IDE compatível: Para rodar este código, é recomendável usar o Visual Studio ou outra IDE C# que suporte a criação de projetos de Console.

#Como Usar

Clone o repositório ou baixe o código.
Abra o projeto em Visual Studio ou em outra IDE C#.
Adapte a lista de processos confiáveis, conforme necessário, no arquivo Program.cs.
Compile e execute o projeto.
O programa começará a monitorar os processos em execução e alertará sobre qualquer processo não confiável.
(Opcional) Adapte o intervalo de tempo entre as verificações alterando o valor do Thread.Sleep(10000) (10 segundos) no código.
Personalização

#Lista de Processos Confiáveis: 

Você pode adicionar ou remover processos da lista processosConfiaveis conforme necessário para o seu ambiente.
Intervalo de Monitoramento: A verificação de processos pode ser ajustada para rodar com mais ou menos frequência, alterando o valor de Thread.Sleep.
