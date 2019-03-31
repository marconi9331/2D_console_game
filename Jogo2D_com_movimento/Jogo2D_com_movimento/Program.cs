namespace Jogo2D_com_movimento
{
    class Program
    {
        private const int largura = 10, altura = 10;
        public static Jogo jogo;
        static void Main(string[] args)
        {
            jogo = new Jogo(largura,altura);
            while (true)
            {
                jogo.atualiza();
            }
        }
    }
}
