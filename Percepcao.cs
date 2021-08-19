namespace AgenteInteligente
{
    public class Percepcao
    {
        public Quadrado quadrado { get; private set; }
        public EstadoDoQuadrado estadoDoQuadrado { get; private set; }
        public Percepcao(Quadrado quadrado, EstadoDoQuadrado estadoDoQuadrado)
        {
            this.quadrado = quadrado;
            this.estadoDoQuadrado = estadoDoQuadrado;
        }

        public bool eIgual(Percepcao percepcao)
        {
            return this.quadrado == percepcao.quadrado && this.estadoDoQuadrado == percepcao.estadoDoQuadrado;
        }
    }
}