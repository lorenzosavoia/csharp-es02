namespace esercizio2
{
    public static class metodi
    {
       public static void PopolamentoArray(ref double[] iArray)
       {
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.WriteLine("inserisci numero:");
                iArray[i] = Convert.ToDouble(Console.ReadLine());
            };
        }
    }
}