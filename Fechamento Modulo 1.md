# Adventure Game

Vamos tornar o nosso desenvolvimento um pouco mais divertido.

Vamos criar um Adventure Game, imagino que 90% de vocês nunca viram esse tipo de jogo, mas há muito tempo em 1900 e guaraná com rolha, existiam jogos que eram jogados somente pelo console, através de inputs de opções para realizar as ações.

Vamos criar um jogo desse tipo, utilizando tudo o que vimos até agora.

Vamos explicar a história/fluxo do jogo:

No inicio da aventura (Menu Inicial) será disponibilizado para o jogador 3 ações:

1. Visitar loja - Comprar itens para auxiliar a aventura.

2. Dormir - Recupera todos os pontos de vida e pontos de magia

3. Explorar masmorra - Possibilita entrar na masmorra e enfrentar monstros para evoluir seu personagem e conseguir dinheiro.

   

Detalhamento das opções de aventura:

### Visitar a loja

​	Apresentar a mensagem: "Olá estranho! O que você está comprando?"
​	Apresentar a quantidade total de moedas de ouro que o jogador possui. (Total de Moedas : X)

​	Ao entrar na loja serão disponibilizados dois itens para o aventureiro comprar:

1. Poção - Recupera 500 pontos de vida - Preço 100 moedas de ouro

2. Elixir - Recupera 50 pontos de magia - Preço 100 moedas de ouro

   Após a escolha do item, escolher a quantidade comprada.

   O aventureiro só pode comprar um total de itens menor ou igual a quantidade de moedas de ouro na sua bolsa.

   A quantidade de itens comprados devem ser somadas ao total de itens desse tipo que o aventureiro possui.

   Ativa a função VisitarLoja() novamente

### Dormir

​	Apresentar a mensagem: "Recepcionista: Bem-vindo a nossa taverna aventureiro. Tenha ótimos sonhos"

​	Apresentar a mensagem: "Dormindo"

​	Recupera todos os pontos de vida e pontos de magia do aventureiro, ou seja, a quantidade atual de pontos de vida e de magia do aventureiro 	recebem os valores máximos de pontos de vida e magia respectivamente.

​	Fazer o sistema aguardar dois segundos  ([System.Threading.Thread.Sleep(2000)](https://www.c-sharpcorner.com/forums/systemthreadingthreadsleep))

​	Apresentar a mensagem: "Recepcionista: Boas Aventuras"

​	Voltar para o menu inicial

## Explorar masmorra

​	Ao entrar na masmorra serão apresentadas duas opções

1. Entrar em uma sala de monstro
2. Entrar na sala do chefe
3. Voltar ao Menu Inicial

### Sala de monstro

​	Ao entrar na sala de monstro o aventureiro enfrentará um monstro normal, iniciando o sistema de batalha.

### Sala do chefe

​	Ao entrar na sala do chefe, o aventureiro enfrentará o monstro mais forte do andar (que possui mais pontos de vida e ataque que um monstro normal) iniciando o sistema de batalha.

#### Sistema de Batalha

​	A batalha entre o aventureiro e algum monstro ocorre por turnos, ou seja, o aventureiro executa uma ação e o monstro executa outra. A batalha só encerrará quando os pontos de vida do monstro ou do aventureiro chegarem a 0.

​	**Turno Aventureiro**

​	Exibir o menu de combate

​	O aventureiro a cada turno pode realizar uma das 3 ações do menu de combate:

1. ​		Atacar
2. ​		Disparar Energia
3. ​		Usar Item

#### Detalhamento das ações do sistema de batalha 

##### 	Atacar

​		Subtrai X pontos de vida do monstro, onde X é igual ao ataque do aventureiro.

##### 	Disparar Energia

​		Subtrai X pontos de vida do monstro, onde X é igual ao ataque do aventureiro multiplicado por 2.

​		Ao disparar energia o aventureiro consome pontos de magia, cada magia disparada reduz em 50 pontos os pontos de magia do aventureiro.

​		O aventureiro só pode disparar energia se tiver pontos de magia suficientes para gastar ao disparar. Se por um acaso o jogador não puder disparar a energia, exibir novamente menu de combate.

##### 	Usar item

​		Exibe os itens do aventureiro no seguinte formato:

1. ​		Poção (quantidade de poções do jogador)

2. ​		Elixir (quantidade de elixires do jogador)

   Após o jogador escolher uma opção utiliza o item selecionado pelo jogador, obedecendo o efeito do item escolhido e subtraindo 1 do total de itens daquele tipo.

**Turno do Monstro**

​	Após a ação do jogador se os pontos de vida do monstro não forem 0, o monstro ataca o jogador.

​	Subtrai X pontos de vida do Aventureiro, onde X é igual ao ataque do monstro.

**Resolução do turno**

​	Após o jogador e o monstro realizarem as suas ações imprimir os pontos de vida e magia do aventureiro e os pontos de vida do monstro, no formato:

​	Jogador

​		Pontos de Vida: Pontos de vida atual/ pontos de vida máximo

​		Pontos de Magia: Pontos de magia atual/ pontos de magia máximo

​	Monstro

​		Pontos de Vida: Pontos de vida atual/ pontos de vida máximo

**Resolução da Batalha**

###### Pontos de vida do monstro chegam a zero - Jogador vence

1. Apresentar a mensagem "Parabéns jogador você derrotou o monstro em X turnos" , onde X é a quantidade de turnos que foram utilizados na batalha.
2. Recompensar o jogador com:
   1. Aumento de 10 pontos de vida a quantidade máxima de pontos de vida
   2. X moedas de ouro, onde X é um número randomico entra a faixa minima e máxima de ouro configurado para o monstro
3. Apresentar a mensagem: "Vida máxima aumentada para X", onde X é a quantidade máxima de vida do aventureiro
4. Apresentar a mensagem: "X moedas de ouro recebidas", onde X é a quantidade de moedas recompensadas pelo monstro
5. Apresentar a mensagem: "Retornado a sala anterior"
6. Executar a função ExplorarMasmorra() do menu inicial

###### Pontos de vida do jogador chegam a zero - monstro vence

1. Apresentar a mensagem "Monstro: HAHAHA! Fraco, muito fraco! Mandei mais aventureiros para me entreter mais"
2. Apresentar a mensagem "O jogador foi derrotado e foi encaminhado para a taverna na cidade"
3. Executar a função Dormir() do menu inicial.

Dados personagens para a implantação:

**Jogador**

- Pontos de Vida Máximo = 500
- Pontos de Magia Máximo= 100
- Ataque = 100
- Ouro Inicial: 300

**Monstro Normal**

- Pontos de Vida = 500
- Ataque = 100
- Faixa de recompensa de ouro: 50 a 100

**Chefe**

- Pontos de Vida = 5000
- Ataque = 250
- Faixa de recompensa de ouro: 500 a 1000

Agora é com você, implemente esse jogo utilizando os conceitos apresentados até o momento (no módulo 1), por enquanto não quebre nada por classes

Pontos de Atenção:

Os parâmetros dos personagens, preço de itens e quantidade de itens e dinheiro não serão input.

Lembre-se estamos publicando um jogo e o jogador não controla essa parte do sistema, somente as ações do aventureiro.