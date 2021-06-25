
namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }//atributo
        public int coluna { get; set; }//atributo

        public Posicao(int linha, int coluna)//construtor
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()//sobreoposição
        {
            return linha
                + ","
                + coluna;
        }
    }
}
