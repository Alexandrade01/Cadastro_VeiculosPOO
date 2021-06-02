using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    class Caminhao:BaseVeiculo,IMetodoExtra
    {
        private int quantidadedeEixos;
        private int velocidadeLimpador;
        public int QuantidadeEixos { get => quantidadedeEixos; set => this.quantidadedeEixos = Validacao.Validainteiros(value); }
        public int VelocidadeLimpador { get => velocidadeLimpador; set => this.velocidadeLimpador = Validacao.Validainteiros(value); }
        public Caminhao(string descricao, double capacidadeMaximaEmKg, int quantidadedeEixos) : base(descricao, capacidadeMaximaEmKg)
        {
            QuantidadeEixos = quantidadedeEixos;
        }
        public override double Carregar(double peso)
        {

           
            
                capacidadeCarregadaemKg += peso;
                return CapacidadeCarregadaemKg;
            
        }

        public override double PagarPedagio()
        {
            return 5 * QuantidadeEixos;
        }
        public override double Acelerar()
        {
            if (CapacidadeCarregadaemKg > CapacidadeMaximaEmKg)
            {
                throw new Exception("Sobrecarregado!");
            }
            else
            {
                velocidadeAtualEmKM++;
                return VelocidadeAtualEmKM;
            }
        }
        public string Descarregar()
        {
            capacidadeCarregadaemKg = 0;
            return "Vazio";
        }
        public override string ToString()
        {
            return base.ToString()
                + " Quantidade de eixos "
                + QuantidadeEixos
                + Environment.NewLine
                + "Velocidade Limpador "
                + VelocidadeLimpador.ToString();
        }

        public string AcionarLimpador()
        {
            return "Limpador acionado....";
        }

        public string AbrirPorta()
        {
            return "Porta aberta....";
        }

      
    }
}
              
            
