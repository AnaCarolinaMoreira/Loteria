using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Loteria
    {
        private int qtdDezenas;
        private int totalJgos;
        private int[][] jogos;
        private int[] resultado;
        Random r = new Random();

        public Loteria(int dezenas, int tjogos)
        {
            QtdDezenas = dezenas;
            TotalJgos = tjogos;
        }

        public int QtdDezenas
        {
            get => qtdDezenas;
            set
            {
                if (value >= 6 && value <= 10)
                    qtdDezenas = value;
                else
                    throw new InvalidOperationException();
            }
        }
        public int TotalJgos { get => totalJgos; set => totalJgos = value; }
        public int[][] Jogos { get => jogos; set => jogos = value; }
        public int[] Resultado { get => resultado; set => resultado = value; }

        private int[] sortearNumeros()
        {


            int[] numeros = new int[QtdDezenas];
            for (int i = 0; i < QtdDezenas; i++)
            {
                int n = r.Next(1, 61);
                while (numeros.Contains(n))
                    n = r.Next(1, 61);

                numeros[i] = n;
            }

            return numeros;
        }

        public void SortearJogos()
        {
            jogos = new int[TotalJgos][];
            for (int i = 0; i < TotalJgos; i++)
            {
                jogos[i] = sortearNumeros();
            }
        }

        public void ExecutarSorteio()
        {
            Random r = new Random();

            int[] numeros = new int[6];
            for (int i = 0; i < 6; i++)
            {
                int n = r.Next(1, 61);
                while (numeros.Contains(n))
                    n = r.Next(1, 61);

                numeros[i] = n;
            }

            Resultado = numeros.OrderBy(i => i).ToArray();
        }

        public int[,] ApurarResultado()
        {
            int[,] result = new int[totalJgos, QtdDezenas + 1];

            int x = 0;

            for (int i = 0; i < totalJgos; i++)
            {

                for (int j = 0; j < qtdDezenas; j++)
                {
                    if (jogos[i].Contains(Resultado[j]))
                        result[i, QtdDezenas]++;

                    result[i, j] = jogos[i][j];

                }


            }



            return result;
        } 

        }
}
