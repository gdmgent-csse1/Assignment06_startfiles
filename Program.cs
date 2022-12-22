namespace Opdracht04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Hash.GetHashString("Test1"));
            Persoon p1 = new Persoon("Kristof", "Raes", 'M');

            Gebruiker g1 = new Gebruiker("Kristof", "Raes", 'M');
            Gebruiker g2 = new Gebruiker("Bert", "Maes", 'M', "Test3");
            Gebruiker g3 = new Gebruiker("Julie", "Boom", 'V', "", "");
        }
    }
}

