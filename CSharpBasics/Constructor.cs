namespace AllAboutClasses
{
    public class Country
    {

        public string Name { get; set; }
        public int Population { get; set; }
        public readonly double AREA = 343243.23423;         
        public static readonly bool IsOnEarth;
        //default constructor
        public Country()
        {
            IsOnEarth = true;
        }

        //parameterized constructor
        public Country(string name, int population, double area)
        {
            name = Name;
            population = Population;
            AREA = area;
        }

        static Country()
        {

        }
    }

    public class ModifierDemo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal", 343242343, 2342342.342343);

        }
    }
}