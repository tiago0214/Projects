# Editor de Texto Simples

O código apresentado implementa um editor de texto simples em C# com funcionalidades básicas, como abrir, criar e salvar arquivos. Abaixo estão as análises detalhadas de cada método e classe.

## O que as classes implementadas fazem

Método Main

> - Este método é a entrada principal do programa.
> - Invoca o método **Menu** para iniciar a interação com o usuário.

Método Menu

> - Exibe um menu simples com opções para o usuário: Abrir arquivo, Criar novo arquivo e Sair.
> - Utiliza um switch para direcionar o programa com base na escolha do usuário.
>   > - Caso 0: Encerra o programa.
>   > - Caso 1: Invoca o método **Open**.
>   > - Caso 2: Invoca o método **Editor**.

Método Open

> - Solicita ao usuário o caminho do arquivo a ser aberto.
> - Utiliza a classe **StreamReader** para ler o conteúdo do arquivo.
> - Exibe o conteúdo do arquivo no console.
> - Retorna ao menu principal após a conclusão da operação.

Método Editor

> - Permite ao usuário digitar um texto até pressionar a tecla "ESC".
> - Utiliza um loop **do-while** para continuar a leitura do console até que a tecla "ESC" seja pressionada.
> - Invoca o método **Salvar** passando o texto inserido.

Método Salvar

> - Solicita ao usuário o caminho para salvar o arquivo.
> - Utiliza a classe **StreamWriter** para escrever o texto no arquivo especificado.
> - Exibe uma mensagem indicando o sucesso da operação.
> - Retorna ao menu principal após a conclusão da operação.

Conclusão

Este código representa um editor de texto básico em console, implementado em C#. Ele oferece funcionalidades essenciais, como abrir, criar e salvar arquivos, proporcionando uma experiência simples para o usuário. Este projeto reflete conceitos fundamentais de manipulação de arquivos, entrada/saída de console e estruturas de controle em C#.
