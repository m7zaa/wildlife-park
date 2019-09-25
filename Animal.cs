namespace Park
{

    class Animal
    {
        private string _Species;
        private string _Type;
        private int _Age;
        private int _TimeInCaptivity;
        private string _Temperment;

        public Animal(string species, string type, int age, int timeInCaptivity, string temperment)
        {
            _Species = species;
            _Type = type;
            _Age = age;
            _TimeInCaptivity = timeInCaptivity;
            _Temperment = temperment;

        }


    public static string DangerLevel(string level)
    {
        return "Today's threat level is: " + level;
    }

    // public static int AmountOfAnimals()
    // {
        
    // }

    // public bool CaptiveBorn(int age, int timeInCaptivity)
    // {
    //     bool captiveBorn = age - timeInCaptivity = 0;
    //     return captiveBorn;
    // }
    public int GetAge()
    {
        return _Age;
    }

    public string GetSpecies()
    {
        return _Species;
    }

    public bool GetType(string type)
    {
        return (_Type == type);
    }
    
    }

}