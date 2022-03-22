﻿using System;


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

        }


        /// <summary>
        /// Stampa la matrice
        /// </summary>
        /// <param name="mat"></param>
        static void StampaMatrice(int [,] mat)
        {

        }

        /// <summary>
        /// Cerca il valore passato nella matrice e restituisce il numero di occorrenze
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="valoreDaCercare"></param>
        /// <returns></returns>
        public static int ContaValore(int[,] mat, int valoreDaCercare)
        {

        }


        /// <summary>
        /// Calcola il valore minimo, massimo e medio (ritornato) dei valori inseriti nella matrice
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static double CalcolaMinMaxMedio(int[,] mat, ref int min, ref int max)
        {
            
        }
    }
}
