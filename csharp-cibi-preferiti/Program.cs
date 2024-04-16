namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = {"pizza","pasta","lasagna","gelato","bolognese","cioccolato","timballo pasta","caffè","latte"};
            Console.WriteLine("Cibi preferiti: " + cibiPreferiti.Length + " ");
            for (var i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + cibiPreferiti[i] + " ");
            }
            Console.WriteLine("Preferito in assoluto: " + cibiPreferiti[0]);
            Console.WriteLine("Meno preferito: " + cibiPreferiti[cibiPreferiti.Length - 1]);

            int classificaMedia = cibiPreferiti.Length / 2;
            if(cibiPreferiti.Length % 2 == 0)
            {
                Console.WriteLine("Il cibo di mezza classifica è: " + cibiPreferiti[classificaMedia -1] + " e " + cibiPreferiti[classificaMedia]);
            }
            else{
                Console.WriteLine("Il cibo di mezza classifica è: " + cibiPreferiti[classificaMedia]);
            }
        }
    }
}
