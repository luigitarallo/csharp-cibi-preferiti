namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = { "pizza", "pasta", "lasagna", "gelato", "bolognese", "cioccolato", "timballo pasta","caffè" };
            Console.WriteLine("Cibi preferiti: " + cibiPreferiti.Length + " ");
            for (var i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + cibiPreferiti[i] + " ");
            }
            Console.WriteLine("Preferito in assoluto: " + cibiPreferiti[0]);
            Console.WriteLine("Meno preferito: " + cibiPreferiti[7]);
        }
    }
}
