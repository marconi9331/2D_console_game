using System;
using System.Collections.Generic;

namespace Jogo2D_com_movimento
{
    class Jogo
    {
        char[,] canvas;
        string buffer;
        int larguraDaTela;

        List<ObjetoDeJogo> listaDeObjetosDeJogo;
        ObjetoDeJogo jogador, pedra;

        ConsoleKeyInfo teclaPressionada;
        //constructor da classe. é chamado quando se cria um novo jogo
        //new Jogo();//
        public Jogo(int larguraDaTela, int alturaDaTela)
        {
            this.larguraDaTela = larguraDaTela;
            Console.SetWindowSize(larguraDaTela, alturaDaTela);
            canvas = new char[larguraDaTela, alturaDaTela];
            listaDeObjetosDeJogo = new List<ObjetoDeJogo>();
            jogador = new ObjetoDeJogo('O', 5, 10);
            listaDeObjetosDeJogo.Add(jogador);
            pedra = new ObjetoDeJogo('x', 3, 10);
            listaDeObjetosDeJogo.Add(pedra);
        }

        public void atualiza()
        {
            LeInput();
            LimpaTela();
            DesenhaObjetosDeJogo();
            DesenhaCanvas();
        }

        void LeInput()
        {
            teclaPressionada = Console.ReadKey();
            switch (teclaPressionada.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (jogador.posX > 0)
                        jogador.Move(-1);
                    break;
                case ConsoleKey.RightArrow:
                    if (jogador.posX < larguraDaTela - 1)
                        jogador.Move(1);
                    break;
                default:
                    break;
            }

        }

        void LimpaTela()
        {
            for (int x = 0; x < canvas.GetLength(0); x++)
            {
                for (int y = 0; y < canvas.GetLength(1); y++)
                {
                    canvas[x, y] = '\u2588';
                }
            }
            buffer = string.Empty;
            Console.Clear();
        }

        void DesenhaObjetosDeJogo()
        {
            for (int ObjetoAtual = 0; ObjetoAtual < listaDeObjetosDeJogo.Count; ObjetoAtual++)
            {
                AdicionaElementoNoCanvas(listaDeObjetosDeJogo[ObjetoAtual].sprite, listaDeObjetosDeJogo[ObjetoAtual].posX, listaDeObjetosDeJogo[ObjetoAtual].posY);
            }
        }
        void DesenhaCanvas()
        {
            for (int x = 0; x < canvas.GetLength(0); x++)
            {
                for (int y = 0; y < canvas.GetLength(1); y++)
                {

                    buffer += canvas[x, y];
                }
            }
            Console.Write(buffer);
        }

        void AdicionaElementoNoCanvas(char elemento, int posX, int posY)
        {
            if (posX < 0 || posX >= larguraDaTela)
                return;
            canvas[posX, posY] = elemento;
        }
    }
}
