# Cronômetro Simples

O código apresentado implementa um cronômetro simples em C# que permite ao usuário contar o tempo em segundos ou minutos. Abaixo estão as análises detalhadas de cada método e classe.

## O que as classes e os métodos implementados fazem

Método Main

> - Este método é a entrada principal do programa.
> - Invoca o método **Menu** para iniciar a interação com o usuário.

Método Menu

> - Exibe um menu que permite ao usuário escolher entre contar em segundos, contar em minutos ou sair.
> - Converte a entrada do usuário para determinar o tipo (segundos ou minutos) e a quantidade de tempo a ser contado.
> - Invoca o método **PreStart** com o tempo convertido.

Método PreStart

> - Exibe mensagens de preparação ("Preparar...", "Apontar...", "Fogo...") com intervalos de 1 segundo entre elas.
> - Invoca o método **Start** com o tempo informado pelo usuário.

Método Start

> - Utiliza um loop **while** para contar o tempo até atingir o tempo definido pelo usuário.
> - Exibe o tempo atual no console a cada segundo.
> - Ao atingir o tempo especificado, exibe a mensagem "Stop watch finalizado" e retorna ao menu principal após uma pausa de 2,5 segundos.

Conclusão

Este código implementa um cronômetro básico em console, permitindo que o usuário conte o tempo em segundos ou minutos. O projeto reflete conceitos fundamentais de manipulação de tempo, entrada/saída de console e estruturas de controle em C#.
