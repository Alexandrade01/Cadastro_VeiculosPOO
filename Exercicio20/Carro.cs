using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    class Carro : BaseVeiculo,IMetodoExtra
    {
        private int quantidadedePortas;
        private int velocidadeLimpador;
        
        public int QuantidadedePortas { get => quantidadedePortas; set => this.quantidadedePortas = Validacao.ValidaPortas(value); }
        public bool UtilizandoReboque { get; set; }
        public int VelocidadeLimpador { get=>velocidadeLimpador; set => this.velocidadeLimpador=Validacao.Validainteiros(value); }
        public Carro(string descricao, double capacidadeMaximaEmKg, int quantidadedePortas, bool utilizandoreboque, int velocidadelimpador) : base(descricao, capacidadeMaximaEmKg)
        {
            QuantidadedePortas = quantidadedePortas;
            UtilizandoReboque = utilizandoreboque;
            VelocidadeLimpador = velocidadelimpador;

        }

        public override double Carregar(double peso)
        {
            if (CapacidadeCarregadaemKg + peso > CapacidadeMaximaEmKg)
            {
                throw new Exception("Carro sobrecarregado!");
            }
            else
            {
                capacidadeCarregadaemKg += peso;
                return CapacidadeCarregadaemKg;
            }
        }

        public override double PagarPedagio()
        {
            if (UtilizandoReboque == true)

                return 10;

            else
                return 7;
        }

        public override string ToString()
        {
            return base.ToString()
                + " Quantidade de portas "
                + QuantidadedePortas
                + Environment.NewLine
                + " Utilizando reboque? "
                + (UtilizandoReboque ? "SIM" : "NÃO")
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
