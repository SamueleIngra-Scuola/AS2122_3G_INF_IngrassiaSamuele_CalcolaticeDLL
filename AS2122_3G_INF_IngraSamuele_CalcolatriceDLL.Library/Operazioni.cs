using System;

namespace AS2122_3G_INF_IngraSamuele_CalcolatriceDLL.Library
{
    public class Operazioni
    {
        /// <summary>
        /// Ritorna la somma fra due operandi
        /// </summary>
        /// <param name="operando1"></param>
        /// <param name="operando2"></param>
        /// <returns></returns>
        public int Somma(int operando1, int operando2)
        {
            return operando1 + operando2;
        }

        /// <summary>
        /// Ritorna la differenza fra due operandi
        /// </summary>
        /// <param name="operando1"></param>
        /// <param name="operando2"></param>
        /// <returns></returns>
        public int Differenza(int operando1, int operando2)
        {
            return operando1 - operando2;
        }

        /// <summary>
        /// Ritorna la moltiplicazione fra due operandi
        /// </summary>
        /// <param name="operando1"></param>
        /// <param name="operando2"></param>
        /// <returns></returns>
        public int Moltiplicazione(int operando1, int operando2)
        {
            return operando1 * operando2;
        }

        /// <summary>
        /// Ritorna la divisione fra due operandi
        /// </summary>
        /// <param name="operando1"></param>
        /// <param name="operando2"></param>
        /// <returns></returns>
        public int Divisione(int operando1, int operando2)
        {
            return operando1 / operando2;
        }

    }
}
