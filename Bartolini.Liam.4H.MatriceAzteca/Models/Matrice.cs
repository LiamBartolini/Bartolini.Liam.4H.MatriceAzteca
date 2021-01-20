using System;
using System.Collections.Generic;
using System.Text;

namespace Bartolini.Liam._4H.MatriceAzteca.Models
{
    class Matrice
    {
        int _n;
        int[,] _matrix;

        public int N
        {
            get => _n;
            set => _n = value;
        }

        public int[,] Matrix
        {
            get => _matrix;
            private set => _matrix = value;
        }

        // Metto di default una matrice 10x10
        public Matrice()
        {
            N = 10;
        }

        // Scrivo la matrice e la inserisco nel campo
        public void ScriviMatrice()
        {
            int[,] matrix = new int[N, N];

            int numAnello = 1, inizio = 0, cont = 0, num = 1;

            // Finchè il contatore di anelli non raggiunge la metà del lato della matrice
            while(true)
            {
                // Inserisce i valori solamente se corrispondono all'annello corrente
                for (int i = inizio; i < N - inizio; i++)
                    for (int j = inizio; j < N - inizio; j++)
                        if (i == inizio || j == inizio || i == N - numAnello || j == N - numAnello)
                            matrix[i, j] = num;

                inizio++;
                numAnello++;
                num++;

                if (cont == N / 2)
                    break;

                cont++;
            }

            Matrix = matrix;
        }

        // Costruisce una matrice e poi la ritorna
        public string StampaMatrice()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    sb.Append(Matrix[i, j] + "   ");

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}