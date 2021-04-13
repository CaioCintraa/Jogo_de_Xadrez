namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            this.tab = tab;
            QtdMovimentos = 0;
        }

        public void IncrementarQtdMovimntos()
        {
            QtdMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();



    } 
}
