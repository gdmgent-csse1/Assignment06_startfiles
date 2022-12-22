namespace Opdracht04
{
    class Klasse
    {
        // Velden
        private string variabele;
        
        // Properties
        public string Property
        {
            get { return variabele; }
            set { variabele = value; }
        }
        
        // Constructoren
        public Klasse()
        {
        }

        // Methoden/Functies
        public void Methode()
        {
            Console.WriteLine("Methode uitgevoerd");
        }
    }
}