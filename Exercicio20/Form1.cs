using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercicio20
{
    public partial class Form1 : Form
    {
        List<BaseVeiculo> Listagem;
        int cont;
        public Form1()
        {
            InitializeComponent();
            Listagem = new List<BaseVeiculo>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbCadastro.Enabled = gbPesquisa.Enabled = gbCarroadc.Enabled = false;
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

     


        private void CbVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVeiculos.SelectedIndex == 1)
            {
                gbCarro.Enabled = true;
                gbMoto.Enabled = gbCaminhao.Enabled = false;

            }
            else if (cbVeiculos.SelectedIndex == 2)
            {
                gbMoto.Enabled = true;
                gbCarro.Enabled = gbCaminhao.Enabled = false;
            }
            else if (cbVeiculos.SelectedIndex == 3)
            {
                gbCaminhao.Enabled = true;
                gbMoto.Enabled = gbCarro.Enabled = false;
            }

        }

        private void BtnCarro_Click(object sender, EventArgs e)
        {
            bool reboque = true;
            if (rbReboqueT.Checked)
                reboque = true;
            else if (rbReboqueF.Checked)
            {
                reboque = false;
            }
            try
            {
                var novocarro = new Carro(txtDescricao.Text, Convert.ToDouble(txtCapMax.Text), Convert.ToInt32(txtCarro1.Text), reboque,Convert.ToInt32(txtCarro2.Text));
                Listagem.Add(novocarro);
                Limpar(this);
                MessageBox.Show("cadastrado!");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro"+erro, "Alerta", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnMoto_Click(object sender, EventArgs e)
        {
            try
            {
                var novamoto = new Moto(txtDescricao.Text, Convert.ToDouble(txtCapMax.Text), Convert.ToInt32(txtMoto1.Text));
                Listagem.Add(novamoto);
                Limpar(this);
                MessageBox.Show("cadastrado!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro, "Alerta", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnCaminhao_Click(object sender, EventArgs e)
        {
            try
            {
                var novocaminhao = new Caminhao(txtDescricao.Text, Convert.ToDouble(txtCapMax.Text), Convert.ToInt32(txtCaminhao1.Text));
                Listagem.Add(novocaminhao);
                Limpar(this);
                MessageBox.Show("cadastrado!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro.Message, "Alerta", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnNovaTela_Click(object sender, EventArgs e)
        {
            gbMotoadc.Enabled = gbCaminhaoadc.Enabled = false;
            cont = 0;
            foreach (var dado in Listagem)
            {
                if (dado.Descricao != txtPesquisa.Text)
                {
                    cont++;
                }
                else
                {
                    if(Listagem[cont] is Moto)
                    {
                        gbMotoadc.Enabled = true;
                    }
                    else if(Listagem[cont] is Caminhao)
                    {
                        gbCaminhaoadc.Enabled = true;
                    }
                    else if(Listagem[cont] is Carro)
                    {
                        gbCarroadc.Enabled = true;
                    }
                    MessageBox.Show("Encontrado!");
                    return;
                    
                }
               

            }
            
            MessageBox.Show("Não encontrado! ");




        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                gbCadastro.Enabled = true;
                gbPesquisa.Enabled = false;
                Limpar(this);
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                gbCadastro.Enabled = false;
                gbPesquisa.Enabled = true;
                Limpar(this);
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                gbCadastro.Enabled = gbPesquisa.Enabled = false;
            }
        }

        private void GbPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            string msg;
            if (Listagem[cont] is Caminhao)
            {
                Listagem[cont].Carregar(Convert.ToDouble(txtMetodos.Text));
                if (Listagem[cont].CapacidadeCarregadaemKg > Listagem[cont].CapacidadeMaximaEmKg)
                    msg = "Sobrecarregado " + Listagem[cont].CapacidadeCarregadaemKg.ToString();
                else
                    msg = "Carregado " + Listagem[cont].CapacidadeCarregadaemKg.ToString();
            }
            else
            {
                msg = Listagem[cont].Carregar(Convert.ToDouble(txtMetodos.Text)).ToString() + " kG carregados...";
            }
            MessageBox.Show(msg);
        }
               
                






           




        private void BtnAcelerar(object sender, EventArgs e)
        {
            MessageBox.Show("Velocidade atual "+Listagem[cont].Acelerar().ToString() + "KM");
        }

        private void BtnPedagio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("R$"+Listagem[cont].PagarPedagio().ToString("F2"));
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            string texto = Listagem[cont].ToString();
            Exibicao novatela = new Exibicao(texto);
            novatela.ShowDialog();
            
        }

        private void BtnEmpinar_Click(object sender, EventArgs e)
        {
            string msg = (Listagem[cont] as Moto).Empinar();
            MessageBox.Show(msg);
        }

        private void BtnDescarregar_Click(object sender, EventArgs e)
        {
            string msg = (Listagem[cont] as Caminhao).Descarregar().ToString();
            MessageBox.Show(msg);
        }

        private void Limpar(Control clean)
        {

            if (clean is TextBoxBase)
            {
                (clean as TextBoxBase).Clear();
            }
            foreach (Control control in clean.Controls)
            {
                Limpar(control);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Listagem[cont] as Caminhao).AcionarLimpador());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Listagem[cont] as Caminhao).AbrirPorta());
        }

        private void BtnLimpadorCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Listagem[cont] as Carro).AcionarLimpador());
        }

        private void BtnAbrirPortaCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Listagem[cont] as Carro).AbrirPorta());
        }
    }
}




