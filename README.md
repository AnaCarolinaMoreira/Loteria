#Desafio loteria

• 1 - Desenvolva uma classe que possua 4 atributos privados que dever˜ao conter os
seguintes dados:
- Quantidade de dezenas, que dever´a permitir apenas as seguintes op¸c˜oes: 6, 7, 8,
9 ou 10.
- Resultado
- Total jogos
- Jogos
• 2 - Desenvolver na classe anterior 2 m´etodos p´ublicos GET e SET para definir os
valores dos atributos.
• 3 - Desenvolver m´etodo de constru¸c˜ao onde 2 parˆametros ser˜ao recebidos os atributos
e consequentemente suas defini¸c˜oes de valor:
- Quantidade de dezenas
- Total de jogos.
• 4 - Desenvolver um m´etodo privado que retorne um array com dezenas entre 01 e 60
que respeite a cardinalidade definida pelo atributo “Quantidade de dezenas” onde as
dezenas nunca se repitam e estejam na ordem crescente.
• 5 - Desenvolver um m´etodo p´ublico que selecione a quantidade de jogos que est´a
setado no atributo “Total jogos” obtendo assim um array multidimensional onde cada
posi¸c˜ao deste array dever´a conter outro array com um jogo. Use o m´etodo anterior
para gerar cada jogo e salve este array multidimensional no atributo “Jogos”.
• 6 - Desenvolver um m´etodo p´ublico que realize o sorteio de 6 dezenas aleat´orias entre
01 e 60. Os n´umeros n˜ao podem se repetir e devem estar em ordem crescente. O
array resultante dever´a ser armazenado no atributo “Resultado”.
• 7 - Desenvolver um m´etodo que confere todos os jogos e retorna uma tabela HTML
que contem os jogos e quantas dezenas foram sorteadas em cada jogo
