//1 - O que é uma classe e qual a sua composição ?
//R: Classe é um modelo ou uma estrutura que define as características e comportamentos de um objeto. Ela é composta por campos, propriedades,
//métodos, construtores e eventos. Os campos armazenam dados, as propriedades permitem o acesso controlado a esses dados, os métodos definem
//ações que podem ser realizadas pelos objetos da classe, os construtores inicializam os objetos e os eventos permitem a comunicação entre objetos.

//2- O que é um objeto e como pode ser criado ?
//R: Um objeto é uma instância de uma classe, representando uma entidade específica com suas próprias características e comportamentos. Ele pode ser
//criado utilizando o operador "new" seguido do nome da classe e dos parênteses, que podem conter argumentos para o construtor da classe. Por exemplo:
//MinhaClasse meuObjeto = new MinhaClasse();

//3- Qual a diferença entre classe e objeto ?
//R: A classe é um modelo ou uma definição que descreve as características e comportamentos de um tipo de objeto, enquanto o objeto é uma instância
//concreta dessa classe.

//4- O que é um método e como pode ser criado e chamado ?
//R: Um método é um bloco de código que realiza uma ação específica e pode ser chamado para executar essa ação. Ele pode ser criado dentro de uma
//classe

//5- O que é um  parâmetro de método ?
//R: Um parâmetro de método é uma variável que é definida na assinatura do método e que permite que valores sejam passados para o método quando ele
//é chamado.

//6- O que é um argumento ?
//R: Um argumento é o valor real que é passado para um método quando ele é chamado, correspondendo aos parâmetros definidos na assinatura do método.

//7- O que é um construtor e qual o seu objetivo ?
//R: Um construtor é um método especial de uma classe que é chamado automaticamente quando um objeto dessa classe é criado. Seu objetivo é inicializar
//o objeto, configurando seus campos e propriedades com valores iniciais.

//8- Quais os usos da palavra chave this ?
//R: A palavra-chave "this" é usada dentro de uma classe para se referir à instância atual do objeto. Ela pode ser utilizada para acessar membros da
//classe, como campos, propriedades e métodos, especialmente quando há ambiguidade entre nomes de variáveis locais e membros da classe. Além disso,
//"this" pode ser usado para chamar outros construtores da mesma classe (construtor de sobrecarga) e para passar a instância atual como argumento para
//outros métodos ou classes.

//9- O que é um método com retorno ? 
//R: Um método com retorno é um método que, ao ser chamado, realiza uma ação e devolve um valor ao chamador. O tipo de retorno do método é especificado
//na assinatura do método.

//10- O que é sobrecarga de método ?
//R: Sobrecarga de método é um recurso da programação orientada a objetos que permite criar múltiplos métodos com o mesmo nome, mas com diferentes
//assinaturas (número e/ou tipo de parâmetros). Isso permite que um método seja chamado de maneiras diferentes, dependendo dos argumentos fornecidos,

//11- Como  é feita  a passagem de parâmetros por valor ?
//R: A passagem de parâmetros por valor é feita quando os argumentos são copiados para os parâmetros do método. Qualquer modificação realizada no
//parâmetro dentro do método não afeta o argumento original.

//12- Como  é feita  a passagem de parâmetros por referência ?
//R: A passagem de parâmetros por referência é feita quando o endereço de memória do argumento é passado para o parâmetro do método. Isso permite que
//o método modifique o valor do argumento original.

//13- Qual a diferença entre os parâmetros out e o parâmetro ref ?
//R: A diferença entre os parâmetros out e ref é que o parâmetro out é usado para retornar um valor do método, enquanto o parâmetro ref é usado para
//passar um valor para o método e também retornar um valor modificado.

//14- O que são argumentos nomeados ?
//R: Argumentos nomeados são argumentos que são passados para um método especificando o nome do parâmetro correspondente. Isso permite que os
//argumentos sejam passados em qualquer ordem, tornando o código mais legível e fácil de manter.

//15- O que são parâmetros opcionais ? 
//R: Parâmetros opcionais são parâmetros que possuem um valor padrão atribuído na assinatura do método. Quando o método é chamado, esses parâmetros
//podem ser omitidos, e o valor padrão será utilizado.

//16- Qual o efeito da palavra-chave static ?
//R: A palavra-chave "static" é usada para criar membros que pertencem à classe em si, e não a instâncias específicas dessa classe. Isso significa
//que não é necessário criar uma instância da classe para acessar membros estáticos.

//17 - O que é método estático e qual o seu comportamento ?
//R: Um método estático é um método que pertence à classe em vez de uma instância específica da classe. Ele pode ser chamado diretamente pela classe,
//sem a necessidade de criar um objeto da classe.

//18- O que  é um campo estático e qual o seu comportamento ?
//R: Um campo estático é um campo que pertence à classe em vez de uma instância específica da classe. Ele é compartilhado por todas as instâncias da
//classe e mantém o mesmo valor para todas elas.


//19- O que são propriedades ?
//R: Propriedades são membros que fornecem um mecanismo flexível para ler, gravar ou calcular o valor de um campo privado. Elas são acessadas como
//se fossem campos, mas na verdade são métodos.

//20- Qual a diferença entre campos e propriedades ?
//R: A principal diferença é que campos são variáveis diretamente acessíveis, enquanto propriedades são membros que controlam o acesso a esses campos,
//permitindo validações e lógica adicional durante a leitura ou escrita.

//21- O que é uma struct ?
//R: Uma struct é um tipo de valor que pode conter dados e métodos, mas não pode ter construtores padrão ou destruidor. Ela é geralmente usada para
//representar objetos simples que não requerem herança.

//22- Qual a diferença entre uma struct e uma classe ?
//R: A principal diferença é que uma struct é um tipo de valor e é alocada na pilha, enquanto uma classe é um tipo de referência e é alocada no heap.
//Além disso, structs não podem ter construtores padrão ou destruidor.

//23- O que é uma Enum ?
//R: Uma enumeração (enum) é um tipo de valor que define um conjunto de constantes nomeadas. Elas são usadas para representar valores discretos e
//melhorar a legibilidade do código.

//24- Quais são e qual o escopo dos modificadores de acesso ?
//R: Os modificadores de acesso em C# são: public, private, protected, internal e protected internal. O escopo de cada um é o seguinte:
//- public: acessível de qualquer lugar.
//- private: acessível apenas dentro da própria classe.
//- protected: acessível dentro da própria classe e em classes derivadas.
//- internal: acessível apenas dentro do mesmo assembly.
//- protected internal: acessível dentro do mesmo assembly e em classes derivadas, mesmo que estejam em outro assembly.

//25- Qual a regra geral para usar os modificadores de acesso ?
//R: A regra geral é usar o modificador de acesso mais restritivo possível para proteger os membros da classe, garantindo encapsulamento e segurança.
