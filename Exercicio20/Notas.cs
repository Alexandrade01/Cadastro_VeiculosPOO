using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    class Notas
    { /*
Crie as classes em C# (modo Windows forms) que melhor representem as necessidades abaixo. Será analisada a capacidade do aluno de abstrair e utilizar da melhor forma os conceitos de orientação a objetos. 

O modelo abaixo tem por objetivo representar automóveis, que podem ser carros, caminhões, ônibus e até motos.

Independentemente do tipo de veículo automotor, todos eles devem possuir os seguintes atributos e  métodos:

Atributos:
string  descricao
double  capacidadeMaximaEmKg 
double  velocidadeAtualEmKM   (atributo apenas leitura)
double  capacidadeCarregadaemKg  (atributo apenas leitura)

Métodos:
double Carregar (double peso)// -> gerar exceção (personalizada) se exceder a capacidadeMaximaEmKg//.  Exibir em vídeo a capacidade informada após carregar.
double  Acelerar() ; // aumenta em 1 km a velocidade atual do veículo e exibe no console a nova velocidade
double PagarPedagio(); // seu cálculo depende de características do tipo de veículo. Todo veículo deve pagar pedágio.
o método ToString()// deverá exibir todos os atributos da classe, concatenados.

Obs:  um veículo automotor  não deve ser instanciado. Apenas os seus descendentes podem ser instanciados.


Segue abaixo uma descrição dos diversos tipos de automóveis

Um carro é um tipo de veículo automotor que possui, além dos atributos e métodos de um veículo automotor, adicionalmente:

Atributos:
int quantidade de portas.  
bool UtilizandoReboque ;
Métodos:
O método ToString deve refletir todos os atributos da classe.
No método de cálculo do pedágio: caso esteja usando reboque cobrar R$ 10,00. Caso contrário, cobrar R$7,00. Exibir o valor pago em vídeo.


Uma moto é um tipo de veículo automotor que possui, além dos atributos e métodos de um veículo automotor, adicionalmente:

Atributos:
int cilindradas
Métodos
string Empinar() -> exibe no console "Empinando...";
O método ToString deve refletir todos os atributos da classe.
Cálculo do pedágio: Para moto, considerar o valor R$ 2,00. Exibir o valor pago em vídeo


Um caminhão é um tipo de veículo automotor que possui, além dos atributos e métodos de um veículo automotor, adicionalmente:

Atributos:
int QuantidadeEixos;

Métodos
double Carregar(double peso) -> exibe no console "Carregado". Caso o peso ultrapasse o peso máximo,  NÃO gere uma exceção, mas exiba em vídeo a mensagem “Sobrecarregado”;
O método Acelerar não deve acelerar o caminhão caso o peso carregado no caminhão ultrapasse o peso máximo. Neste caso, gere uma exceção com o texto “Sobrecarregado!”.
O método ToString deve refletir todos os atributos da classe.

Crie o método  Descarregar() , que irá retirar todo o peso e escrever "Vazio" no console;
Cálculo do pedágio: Considerar o valor R$ 5,00 por eixo. Exibir o valor pago em vídeo.

Crie também botões  para executar os métodos  específicos de cada classe, como o descarregar do caminhão.
Esses métodos deverão atuar sobre 1 objeto na lista. Para isso, você precisará primeiro efetuar uma pesquisa pelo nome do veículo, achá-lo na lista e então executar o método escolhido.



Após terminado o sistema, foi solicitado que fossem incluídas algumas funcionalidades no carro e no caminhão:
int VelocidadeLimpador 
void AcionarLimpador();
void AbrirPorta();

Implemente estas funcionalidades nos veículos onde elas se aplicam e crie os botões para testá-las.

/**/
    }
}
