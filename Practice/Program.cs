namespace Practice
{
    internal class Program
    {
        static void Main()
        {
            Figure[] f =
            {
                new Rectangle(4, 5),
                new Circle(3),
                new RightTriangle(6, 8),
                new Trapezoid(4, 8, 5)
            };

            foreach (Figure i in f)
            {
                Console.WriteLine($"Area: {i.GetArea()}");
            }
            
            
            
            Document[] documents =
            {
                new Document("djewdjweoi"),
                new Report("dewdwedew", 101),
                new Invoice("dewdedewd", 1001, 20261022)
            };

            foreach (Document document in documents)
            {
                document.Print();
                Console.WriteLine();
            }
        }
    }
}