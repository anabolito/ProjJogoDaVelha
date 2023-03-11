internal class Program
{
    private static void Main(string[] args)
    {
        char[,] jogo = new char[3, 3];
        char xOuO = 'X', posicao = jogo[0, 0];
        int rodada = 1;
        bool vitoria = false;

        jogo[0, 0] = 'A';
        jogo[0, 1] = 'B';
        jogo[0, 2] = 'C';
        jogo[1, 0] = 'D';
        jogo[1, 1] = 'E';
        jogo[1, 2] = 'F';
        jogo[2, 0] = 'G';
        jogo[2, 1] = 'H';
        jogo[2, 2] = 'I';


        for (rodada = 1; rodada <= 9; rodada++)
        {

            if (rodada < 5)
            {
                MostrarTabuleiro();
                EscolherPosicao(posicao);
            }
            else
            {
                while (vitoria == false)
                {
                    MostrarTabuleiro();
                    EscolherPosicao(posicao);
                    if (VerificarVitoria())
                    {
                        Console.WriteLine(xOuO + " ganhou!");
                        MostrarTabuleiro();
                    }
                }
            }
            
        }



        // a partir daqui é declaração de funções para o jogo


        bool VerificarVitoria()
        {
            if ((jogo[0, 0] == jogo[0, 1] && jogo[0, 1] == jogo[0, 2]) ||      //vitória na primeira linha
                 (jogo[1, 0] == jogo[1, 1] && jogo[1, 1] == jogo[1, 2]) ||   //vitória na segunda linha
                 (jogo[2, 0] == jogo[2, 1] && jogo[2, 1] == jogo[2, 2]) ||   //vitória na terceira linha
                 (jogo[0, 0] == jogo[1, 0] && jogo[1, 0] == jogo[2, 0]) ||   //vitória na primeira coluna
                 (jogo[0, 1] == jogo[1, 1] && jogo[1, 1] == jogo[2, 1]) ||   //vitória na segunda coluna
                 (jogo[0, 2] == jogo[1, 2] && jogo[1, 2] == jogo[2, 2]) ||   //vitória na terceira coluna
                 (jogo[0, 0] == jogo[1, 1] && jogo[1, 1] == jogo[2, 2]) ||   //vitória na primeira diagonal
                 (jogo[0, 2] == jogo[1, 1] && jogo[1, 1] == jogo[2, 0]))     //vitória na segunda diagonal
            {
                vitoria = true;
            }
            return vitoria;
        }


        void MostrarTabuleiro()
        {
            Console.WriteLine($"{jogo[0, 0]} | {jogo[0, 1]} | {jogo[0, 2]}");
            Console.WriteLine("----------");
            Console.WriteLine($"{jogo[1, 0]} | {jogo[1, 1]} | {jogo[1, 2]}");
            Console.WriteLine("----------");
            Console.WriteLine($"{jogo[2, 0]} | {jogo[2, 1]} | {jogo[2, 2]}");
        }

        char TrocarPeca(int rodada)
        {
            if (rodada % 2 == 0)
                xOuO = 'O';
            else
                xOuO = 'X';
            return xOuO;
        }

        char[,] EscolherPosicao(char posicao)
        {
            Console.Write("Escolha uma posição: ");
            posicao = char.Parse(Console.ReadLine().ToUpper());

            switch (posicao)
            {
                case 'A':
                    if (jogo[0, 0] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[0, 0] = TrocarPeca(rodada);
                    break;

                case 'B':
                    if (jogo[0, 1] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[0, 1] = TrocarPeca(rodada);
                    break;

                case 'C':
                    if (jogo[0, 2] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[0, 2] = TrocarPeca(rodada);
                    break;

                case 'D':
                    if (jogo[1, 0] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[1, 0] = TrocarPeca(rodada);
                    break;

                case 'E':
                    if (jogo[1, 1] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[1, 1] = TrocarPeca(rodada);
                    break;

                case 'F':
                    if (jogo[1, 2] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[1, 2] = TrocarPeca(rodada);
                    break;

                case 'G':
                    if (jogo[2, 0] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[2, 0] = TrocarPeca(rodada);
                    break;

                case 'H':
                    if (jogo[2, 1] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[2, 1] = TrocarPeca(rodada);
                    break;

                case 'I':
                    if (jogo[2, 2] == 'X' || jogo[0, 0] == 'O')
                    {
                        Console.WriteLine("O local ja tem valor, digite outro.");
                        EscolherPosicao(posicao);
                    }

                    else
                        jogo[2, 2] = TrocarPeca(rodada);
                    break;

                default:
                    Console.WriteLine(" Posição inválida.");
                    EscolherPosicao(posicao);
                    break;
            }

            return jogo;
        }
    }
}