namespace _1012.Entitie;
public class City
    {
        public int CountryCount { get; set; }

        public static City operator +(City city1, City city2)
        {
            return new City
            {
                CountryCount = city1.CountryCount + city2.CountryCount
            };
        }

        public static City operator -(City city1, City city2)
        {
            return new City
            {
                CountryCount = city1.CountryCount - city2.CountryCount
            };
        }

        public static City operator ==(City city1, City city2)
        {
            return new City
            {
                CountryCount = city1.CountryCount == city2.CountryCount ? 1 : 0
            };
        }

        public static City operator !=(City city1, City city2)
        {
            return new City
            {
                CountryCount = city1.CountryCount != city2.CountryCount ? 1 : 0
            };
        }
    }