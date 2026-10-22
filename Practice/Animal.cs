namespace Practice
{
    internal class Animal
    {
        private string _name;
        private int _age;

        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Animal: {_name} - {_age}");
        }
    }


    internal class Tiger : Animal
    {
        private int _animalsKilled;

        public Tiger(string name, int age, int animalsKilled) : base(name, age)
        {
            _animalsKilled = animalsKilled;
        }

        public void Print()
        {
            Console.WriteLine($"Tiger kill streak: {_animalsKilled}");
        }
    }


    internal class Crocodile : Animal
    {
        private int _distanceSwum;

        public Crocodile(string name, int age, int distanceSwum) : base(name, age)
        {
            _distanceSwum = distanceSwum;
        }

        public void Print()
        {
            Console.WriteLine($"Crocodile distance swum: {_distanceSwum}km.");
        }
    }


    internal class Kangaroo : Animal
    {
        private int _distanceJumped;

        public Kangaroo(string name, int age, int distanceJumped) : base(name, age)
        {
            _distanceJumped = distanceJumped;
        }

        public void Print()
        {
            Console.WriteLine($"Kangaroo distance swum: {_distanceJumped}");
        }
    }
}