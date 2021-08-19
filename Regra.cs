using System;
using System.Collections.Generic;
using System.Linq;

namespace AgenteInteligente
{
    public class Regra
    {
        private Dictionary<Percepcao, Acao> _dicionarioDeRegras;
        private List<Percepcao> _percepcaoes;
        public Regra()
        {
            _dicionarioDeRegras = new Dictionary<Percepcao, Acao>();
            _percepcaoes = new List<Percepcao>();
        }

        public void adicionaRegra(Percepcao percepcao, Acao acao)
        {
            _dicionarioDeRegras.Add(percepcao,acao);
            _percepcaoes.Add(percepcao);
        }

        public Acao acaoDaRegra(Percepcao percepcao)
        {
            foreach (var unicaPercepcao in _percepcaoes.Where(unicaPercepcao => unicaPercepcao.eIgual(percepcao)))
            {
                return _dicionarioDeRegras[unicaPercepcao];
            }
            Console.WriteLine(percepcao.quadrado.ToString() + percepcao.estadoDoQuadrado);
            throw new ArgumentException("Nao a acao reverente a percepcao passada");
        }
    }
}