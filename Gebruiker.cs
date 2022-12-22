namespace Opdracht04
{
    class Gebruiker : Persoon
    {
        // Velden
        private string gebruikersnaam;
        private string login;
        private string wachtwoord;
        
        // Properties
        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
        }

        public string Login
        {
            get { return login; }
        }

        public string Wachtwoord
        {
            get { return wachtwoord; }
        }
        
        // Constructoren
        public Gebruiker(string voornaam, string naam, char geslacht)
        {
            this.voornaam = voornaam;
            this.Naam = naam;
            this.Geslacht = geslacht;
            LogOutput();
        }

        public Gebruiker(string voornaam, string naam, char geslacht, string wachtwoord)
        {
            this.voornaam = voornaam;
            this.Naam = naam;
            this.Geslacht = geslacht;
            this.gebruikersnaam = GenereerGebruikersnaam(voornaam, naam);
            this.login = GenereerLogin(this.gebruikersnaam);
            this.wachtwoord = GenereerWachtwoord(wachtwoord);
            LogOutput();
        }

        // Andere manier om de basisklasse zijn constructor aan te roepen!
        // Let op het aantal argumenten die we doorgeven aan base!!!
        public Gebruiker(string voornaam, string naam, char geslacht, string test, string test1) : base(voornaam, naam, geslacht)
        {
            LogOutput();
        }

        // Methoden/Functies
        public void LogOutput()
        {
            Console.WriteLine("Gebruiker aangemaakt: voornaam: " + this.voornaam + ", Naam: " + this.Naam + ", Geslacht: " + this.Geslacht + ", Gebruikersnaam: " + this.Gebruikersnaam + ", Login: " + this.Login + ", Wachtwoord (hash): " + this.Wachtwoord);
        }

        public string GenereerWachtwoord(string wachtwoord)
        {
            return Hash.GetHashString(wachtwoord);
        }

        public string GenereerLogin(string gebruikersnaam)
        {
            return gebruikersnaam+"@arteveldehs.be";
        }

        public string GenereerGebruikersnaam(string voornaam, string naam)
        {
            return voornaam.Substring(0, 2).ToLower() + naam.Substring(0, 3).ToLower();
        }
    }
}