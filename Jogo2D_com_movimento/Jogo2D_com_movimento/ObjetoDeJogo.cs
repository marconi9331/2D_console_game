namespace Jogo2D_com_movimento
{
    class ObjetoDeJogo
    {
        public char sprite;
        public int posX,posY;

        public ObjetoDeJogo(char novoSprite, int posInicialX, int posInicialY)
        {
            sprite = novoSprite;
            posX = posInicialX;
            posY = posInicialX;
        }

        public void Move(int dirX)
        {
            posX += dirX;
        }
    }
}
