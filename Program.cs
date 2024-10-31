namespace Set1Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea lui k (a catea cifra de la sfarsit pe care o doriti): ");
            int k = int.Parse(Console.ReadLine());

            if (k <= 0)
            {
                Console.WriteLine("Valoarea lui k trebuie sa fie mai mare decat 0");
            }
            else
            {
                int cifraDorita = (numar / (int)Math.Pow(10, k-1)) % 10;
                Console.WriteLine($"A {k}-a cifra de la sfarsitul numarului este {cifraDorita}");
            } 
            


        }
    }
}
