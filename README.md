# blackjack


Objetivo: Black Jack

Desenvolver um jogo (versão simplificada) utilizando as regras básicas do Black Jack

• Cartas presentes no jogo: A, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K (contemplando os 4 naipes);

• Cartas de 2 a 10: possuem o valor equivalente ao número da carta;

• Cartas J, Q e K: valem 10 pontos cada um;

• Carta A, pode valer 1 ou 11, se combinada com uma carta de valor 10;

Regras:

Criar um conjunto de APIs que permita:

1. Iniciar um novo jogo;
2. Ao iniciar o jogo, o jogador deve começar com duas cartas;
3. O Dealer (controlado pelo servidor), também deve iniciar o jogo com duas cartas, porém apenas uma deve ter o valor revelado inicialmente;
4. Se o jogador iniciar já com o total de 21 somado na pontuação das duas cartas, o Dealer poderá no máximo empatar, dependendo do valor da segunda carta;
5. Caso o Dealer tenha a primeira carta aberta com um A ou uma carta de valor 10, o mesmo deve abrir a segunda carta, para garantir que não é um Black Jack;
6. Se o Dealer tiver um Black Jack inicial (21 pontos) e o jogador não iniciou da mesma forma, o jogador perde.
7. Caso nenhum dos dois jogadores possua o total de 21 pontos, o jogo segue;
8. O Dealer pode ter o máximo de 5 cartas abertas ou até que a pontuação exceda os 17 pontos;
9. Permitir ao jogador optar por receber novas cartas, ou encerrar a sua mão como está;
10. O jogador vence sempre que conseguir um total de pontos de 21, ou quando o Dealer exceder os 21 pontos antes do jogador, ou conseguir obter mais pontos que o Dealer, caso o mesmo já tenha virado as 5 cartas ou totalizado qualquer valor superior a 17 pontos.

Tecnologias mínimas necessárias:

• WebAPI;
• ASP.NET Core;
• Utilização de TDD (fique à vontade para escolher o Framework de testes, mocks e fixture. Não é necessário validar todas as possibilidades, apenas o suficiente para validar o conhecimento e utilização do padrão);
