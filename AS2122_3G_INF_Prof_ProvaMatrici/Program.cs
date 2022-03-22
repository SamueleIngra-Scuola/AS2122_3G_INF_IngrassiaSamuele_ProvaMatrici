using System;


namespace AS2122_3G_INF_Prof_ProvaMatrici
{
    public class Program
    {

        const int MIN_VALUE_MAT = -100;
        const int MAX_VALUE_MAT = 75;

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la dimensione della matrice quadrata");
            int matSize = Convert.ToInt32(Console.ReadLine());

            // definizione e istanziazione matrice in base alle dimensioni indicate dall'utente
            int[,] mat = new int[matSize, matSize];

            // carica la matrice quadrata mat di una dimensione generica con numeri casuali come indicati 
            CaricaMatrice(ref mat);

            // visualizza la matrice
            StampaMatrice(mat);

            // conta valori nella matrice
            Console.WriteLine("Inserire il numero per cui desidera cercare il numero di occorrenze");
            int numero = Convert.ToInt32(Console.ReadLine());

            int nValori = ContaValore(mat, numero);
            Console.WriteLine($"Dentro la matrice ci sono {nValori} elementi con valore {numero}");

            int min = 0, max = 0;
            double medio = 0;

            // calcola il valore medio (ritornato) e il min e max della matrice
            medio = CalcolaMinMaxMedio(mat, ref min, ref max);
            Console.WriteLine("Il valore massimo è " + max);
            Console.WriteLine("Il valore minimo è " + min);
            Console.WriteLine("Il valore medio della matrice è " + medio);

            // inverte i valori della prima colonna della matrice con l'ultima
            InvertiColonne(ref mat);
            // visualizza la matrice
            StampaMatrice(mat);

            // stampa la cornice della matrice in senso orario a partire da [0,0]
            StampaCornice(mat);
        }


        /// <summary>
        /// Carica i valori casuali nella matrice
        /// </summary>
        /// <param name="mat"></param>
        public static void CaricaMatrice(ref int[,] mat)
        {
            Random numRandom = new Random();
            int nRigheColonne = mat.GetLength(0);
            for (int i = 0; i < nRigheColonne; i++)
                for (int j = 0; j < nRigheColonne; j++)
                    mat[i, j] = numRandom.Next(MIN_VALUE_MAT, MAX_VALUE_MAT + 1);


        }

        /// <summary>
        /// Stampa la cornice della matrice da [0,0] in senso orario
        /// </summary>
        /// <param name="mat"></param>
        public static void StampaCornice(int[,] mat)
        {

        }

        /// <summary>
        /// inverte i valori della prima colonna della matrice con l'ultima
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static void InvertiColonne(ref int[,] mat)
        {
            int[] vetPassaggio = new int[];
        }


        /// <summary>
        /// Stampa la matrice
        /// </summary>
        /// <param name="mat"></param>
        static void StampaMatrice(int [,] mat)
        {
            int nRigheColonne = mat.GetLength(0);
            for (int i = 0; i < nRigheColonne; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < nRigheColonne; j++)
                    Console.Write($"{mat[i, j]}\t");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Cerca il valore passato nella matrice e restituisce il numero di occorrenze
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="valoreDaCercare"></param>
        /// <returns></returns>
        public static int ContaValore(int[,] mat, int valoreDaCercare)
        {
            int nRigheColonne = mat.GetLength(0);
            int occasioni = 0;
            for (int i = 0; i < nRigheColonne; i++)
                for (int j = 0; j < nRigheColonne; j++)
                    if (valoreDaCercare == mat[i, j])
                        occasioni += 1;
            
            return occasioni;
        }


        /// <summary>
        /// Calcola il valore minimo, massimo e medio (ritornato) dei valori inseriti nella matrice
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static double CalcolaMinMaxMedio(int[,] mat, ref int min, ref int max)
        {
            min = mat[0, 0];
            max = mat[0, 0];
            int nRigheColonne = mat.GetLength(0);
            int sommaMatrice = 0;
            for (int i = 0; i < nRigheColonne; i++)
                for (int j = 0; j < nRigheColonne; j++)
                {
                    sommaMatrice += mat[i, j];
                    if (mat[i, j] > max)
                        max = mat[i, j];
                    else if (mat[i, j] < min)
                        min = mat[i, j];
                }

            return sommaMatrice / Math.Pow(nRigheColonne, 2); //Ritorna il numero medio
        }
    }
}
