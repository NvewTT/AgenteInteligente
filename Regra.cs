using System;
using System.Collections.Generic;
using System.Linq;

namespace AgenteInteligente
{
    public class Regra
    {
        private Dictionary<Percepcao, Acao> _dicionarioDeRegras;
        private List<Percepcao> _percepcoes;
        public Regra()
        {
            _dicionarioDeRegras = new Dictionary<Percepcao, Acao>();
            _percepcoes = new List<Percepcao>();
        }

        public void adicionaRegra(Percepcao percepcao, Acao acao)
        {
            _dicionarioDeRegras.Add(percepcao,acao);
            _percepcoes.Add(percepcao);
        }

        public Acao acaoDaRegra(Percepcao percepcao)
        {
            foreach (var unicaPercepcao in _percepcoes.Where(unicaPercepcao => unicaPercepcao.eIgual(percepcao)))
            {
                return _dicionarioDeRegras[unicaPercepcao];
            }
            Console.WriteLine(percepcao.quadrado.ToString() + percepcao.estadoDoQuadrado);
            throw new ArgumentException("Nao a acao reverente a percepcao passada");
        }
    }
}