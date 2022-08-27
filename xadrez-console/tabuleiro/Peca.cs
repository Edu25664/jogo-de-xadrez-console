
using xadrez_console.tabuleiro;

namespace tabuleiro
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public Color Color { get; private set; }

        public int QuantidadeMovimento { get; private set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Color color,  Tabuleiro tab)
        {
            this.Posicao = posicao;
            this.Color = color;
            this.QuantidadeMovimento = 0;
            this.Tab = tab;
        }
    }
}
