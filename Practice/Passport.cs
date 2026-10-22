namespace Practice
{
    internal class Passport
    {
        private string _name;
        private int _age;
        private string _country;

        public Passport(string name, int age, string country)
        {
            _name = name;
            _age = age;
            _country = country;
        }

        public void Print()
        {
            Console.WriteLine($"{_name}, {_age}, {_country}");
        }
    }


    internal class ForeignPassport : Passport
    {
        private int _visasAmount;
        private int _id;

        public ForeignPassport(string name, int age, string country, int visasAmount, int id) : base(name, age, country)
        {
            _visasAmount = visasAmount;
            _id = id;
        }

        public void Print()
        {
            Console.WriteLine($"Visas: {_visasAmount}, ID: {_id}");
        }
    }
}