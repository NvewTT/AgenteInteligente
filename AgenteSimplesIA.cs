using System;

namespace AgenteInteligente
{
    public class AgenteSimplesIA
    {
        private Regra _regra;
        public AgenteSimplesIA()
        {
            _regra = new Regra();
            _regra.adicionaRegra(new Percepcao(Quadrado.a,EstadoDoQuadrado.limpo),Acao.moverDireita);
            _regra.adicionaRegra(new Percepcao(Quadrado.a,EstadoDoQuadrado.sujo),Acao.aspirar);
            _regra.adicionaRegra(new Percepcao(Quadrado.b,EstadoDoQuadrado.limpo),Acao.moverCima);
            _regra.adicionaRegra(new Percepcao(Quadrado.b,EstadoDoQuadrado.sujo),Acao.aspirar);
            _regra.adicionaRegra(new Percepcao(Quadrado.c,EstadoDoQuadrado.limpo),Acao.moverEsquerda);
            _regra.adicionaRegra(new Percepcao(Quadrado.c,EstadoDoQuadrado.sujo),Acao.aspirar);
            _regra.adicionaRegra(new Percepcao(Quadrado.d,EstadoDoQuadrado.limpo),Acao.moverBaixo);
            _regra.adicionaRegra(new Percepcao(Quadrado.d,EstadoDoQuadrado.sujo),Acao.aspirar);
        }
        public Acao interpretarEntradaEFazAcao(Percepcao percepcao)
        {
            var acao = _regra.acaoDaRegra(percepcao);
            return acao;
        }
    }
}