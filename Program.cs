using System;
using System.Diagnostics;
using System.Linq;

namespace AgenteInteligente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgenteSimplesIA agenteSimplesIa = new AgenteSimplesIA();
            Random random = new Random();
            double quantidadeDeSujeira = 0;
            double quantidadeDeSujeiraLimpa = 0;
            int interacoes = 20;
            int quantidadesDeEstadosDosQuadrados = interacoes;
            Quadrado quadradoEscolhido;
            EstadoDoQuadrado estadoDoQuadradoEscolhido;
            int tamanhoDoQuadrado = Enum.GetValues(typeof(Quadrado)).Length;
            int tamanhoDoEstadoDoQuadrado = Enum.GetValues(typeof(EstadoDoQuadrado)).Length;
            EstadoDoQuadrado[] sujeiras = new EstadoDoQuadrado[quantidadesDeEstadosDosQuadrados];
            quantidadeDeSujeira = prencheArrayDeSujeiras(quantidadesDeEstadosDosQuadrados, sujeiras, 
                random, tamanhoDoEstadoDoQuadrado, quantidadeDeSujeira);
            for(int i = 0; i < interacoes; ++i)
            {
                quadradoEscolhido = (Quadrado)random.Next(tamanhoDoQuadrado);
                estadoDoQuadradoEscolhido = sujeiras[i];
                var acao = agenteSimplesIa.interpretarEntradaEFazAcao(new Percepcao(quadradoEscolhido,
                    estadoDoQuadradoEscolhido));
                if (acao != Acao.aspirar) continue;
                quantidadeDeSujeiraLimpa++;
            }
            double acuracia = (quantidadeDeSujeiraLimpa / quantidadeDeSujeira) * 100;
            Console.WriteLine(acuracia.ToString() + "%");
        }
        private static double prencheArrayDeSujeiras(int quantidadesDeEstadosDosQuadrados, EstadoDoQuadrado[] sujeiras, Random random,
            int tamanhoDoEstadoDoQuadrado, double quantidadeDeSujeira)
        {
            for (int i = 0; i < quantidadesDeEstadosDosQuadrados; ++i)
            {
                sujeiras[i] = (EstadoDoQuadrado) random.Next(tamanhoDoEstadoDoQuadrado);
                if (sujeiras[i] != EstadoDoQuadrado.sujo) continue;
                quantidadeDeSujeira++;
            }

            return quantidadeDeSujeira;
        }
    }
}