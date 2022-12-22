namespace Opdracht04
{
    class Persoon
    {
        // Velden
        public string voornaam;
        private char geslacht;
        
        // Properties
        public char Geslacht
        {
            get { return geslacht; }
            set { geslacht = value; }
        }

        public string Naam
        {
            get; set;
        }
        
        // Constructoren
        public Persoon()
        {
            LogOutput();
        }

        public Persoon(string voornaam, string naam)
        {
            this.voornaam = voornaam;
            this.Naam = naam;
            LogOutput();
        }

        public Persoon(string voornaam, string naam, char geslacht)
        {
            this.voornaam = voornaam;
            this.Naam = naam;
            this.Geslacht = geslacht;
            LogOutput();
        }

        // Methoden/Functies
        public void LogOutput()
        {
            Console.WriteLine("Persoon aangemaakt: voornaam: " + this.voornaam + ", Naam: " + this.Naam + ", Geslacht: " + this.Geslacht);
        }
    }
}