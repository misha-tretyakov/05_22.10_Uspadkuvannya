namespace Practice
{
    internal class Human
    {
        private string _name;
        private int _age;

        public Human(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Print()
        {
            Console.WriteLine($"{_name}, {_age}.");
        }
    }


    internal class Builder : Human
    { 
        private int _homesBuilt;

        public Builder(string name, int age, int homesBuilt) : base(name, age)
        {
            _homesBuilt = homesBuilt;
        }

        public void Print()
        {
            Console.WriteLine($"Is a builder. {_homesBuilt} homes built.");
        }
    }
    
    
    internal class Sailor : Human
    { 
        private string _rank;
        private int _distanceTravelled;

        public Sailor(string name, int age, string rank, int distanceTravelled) : base(name, age)
        {
            _rank = rank;
            _distanceTravelled = distanceTravelled;
        }

        public void Print()
        {
            Console.WriteLine($"Is a sailor. Rank - {_rank}.  {_distanceTravelled}km travelled.");
        }
    }
}